// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace v8file.net
{
    /// <summary>
    ///  Implements a node of a <see cref='Tree'/>.
    /// </summary>
    [DefaultProperty(nameof(Text))]
    public partial class TreeNode
    {
        //the threshold value used to optimize AddRange and Clear operations for a big number of nodes
        internal const int MAX_TREENODES_OPS = 200;

        // we use it to store font and color data in a minimal-memory-cost manner
        // ie. nodes which don't use fancy fonts or colors (ie. that use the TreeView settings for these)
        //     will take up less memory than those that do.
        internal string text;
        internal string name;

        internal bool nodesCleared;

        internal int index;                  // our index into our parents child array
        internal int childCount;
        internal TreeNode[] children;
        internal TreeNode parent;
        internal Tree tree;
        private TreeNodeCollection nodes;
        object userData;

        /// <summary>
        ///  Creates a TreeNode object.
        /// </summary>
        public TreeNode()
        {
        }

        internal TreeNode(Tree tree) : this()
        {
            this.tree = tree;
        }

        /// <summary>
        ///  Creates a TreeNode object.
        /// </summary>
        public TreeNode(string text) : this()
        {
            this.text = text;
        }

        /// <summary>
        ///  Creates a TreeNode object.
        /// </summary>
        public TreeNode(string text, TreeNode[] children) : this(text)
        {
            Nodes.AddRange(children);
        }

        /// <summary>
        ///  The first child node of this node.
        /// </summary>
        [Browsable(false)]
        public TreeNode FirstNode => childCount == 0 ? null : children[0];

        /// <summary>
        ///  Returns the full path of this node.
        ///  The path consists of the labels of each of the nodes from the root to this node,
        ///  each separated by the pathSeparator.
        /// </summary>
        [Browsable(false)]
        public string FullPath
        {
            get
            {
                Tree tree = Tree;
                if (tree is not null)
                {
                    StringBuilder path = new();
                    GetFullPath(path, tree.PathSeparator);
                    return path.ToString();
                }
                else
                {
                    throw new InvalidOperationException("Full path can only be retrieved when a TreeNode has been added to a TreeView. This TreeNode has not been added to a TreeView.");
                }
            }
        }

        /// <summary>
        ///  Returns the full OS path of this node.
        ///  The path consists of the labels of each of the nodes from the root to this node,
        ///  each separated by the pathSeparator.
        /// </summary>
        [Browsable(false)]
        public string FullOsPath
        {
            get
            {
                Tree tree = Tree;
                if (tree is not null)
                {
                    StringBuilder path = new();
                    GetFullOsPath(path, tree.PathSeparator);
                    return path.ToString();
                }
                else
                {
                    throw new InvalidOperationException("Full path can only be retrieved when a TreeNode has been added to a TreeView. This TreeNode has not been added to a TreeView.");
                }
            }
        }

        /// <summary>
        ///  The last child node of this node.
        /// </summary>
        [Browsable(false)]
        public TreeNode LastNode
        {
            get
            {
                if (childCount == 0)
                {
                    return null;
                }

                return children[childCount - 1];
            }
        }

        /// <summary>
        ///  This denotes the depth of nesting of the TreeNode.
        /// </summary>
        [Browsable(false)]
        public int Level
        {
            get
            {
                if (Parent is null)
                {
                    return 0;
                }
                else
                {
                    return Parent.Level + 1;
                }
            }
        }

        /// <summary>
        ///  The next sibling node.
        /// </summary>
        [Browsable(false)]
        public TreeNode NextNode
        {
            get
            {
                if (parent is not null && index + 1 < parent.Nodes.Count)
                {
                    return parent.Nodes[index + 1];
                }
                else
                {
                    return null;
                }
            }
        }

        [ListBindable(false)]
        [Browsable(false)]
        public TreeNodeCollection Nodes
        {
            get
            {
                if (nodes is null)
                {
                    nodes = new TreeNodeCollection(this);
                }

                return nodes;
            }
        }

        /// <summary>
        ///  Retrieves parent node.
        /// </summary>
        [Browsable(false)]
        public TreeNode Parent
        {
            get
            {
                Tree tree = Tree;

                // Don't expose the virtual root publicly
                if (tree is not null && parent == tree.root)
                {
                    return null;
                }

                return parent;
            }
        }

        /// <summary>
        ///  The previous sibling node.
        /// </summary>
        [Browsable(false)]
        public TreeNode PrevNode
        {
            get
            {
                if (parent is null)
                {
                    return null;
                }

                //fixedIndex is used for perf. optimization in case of adding big ranges of nodes
                int currentInd = index;
                int fixedInd = parent.Nodes.FixedIndex;

                if (fixedInd > 0)
                {
                    currentInd = fixedInd;
                }

                if (currentInd > 0 && currentInd <= parent.Nodes.Count)
                {
                    return parent.Nodes[currentInd - 1];
                }
                else
                {
                    return null;
                }
            }
        }

        [Localizable(false)]
        [DefaultValue(null)]
        [TypeConverter(typeof(StringConverter))]
        public object Tag
        {
            get
            {
                return userData;
            }
            set
            {
                userData = value;
            }
        }

        /// <summary>
        ///  The label text for the tree node
        /// </summary>
        [Localizable(true)]
        public string Text
        {
            get
            {
                return text ?? "";
            }
            set
            {
                text = value;
            }
        }

        /// <summary>
        ///  The name for the tree node - useful for indexing.
        /// </summary>
        public string Name
        {
            get
            {
                return name ?? "";
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        ///  Return the TreeView control this node belongs to.
        /// </summary>
        [Browsable(false)]
        public Tree Tree
        {
            get
            {
                if (tree is null)
                {
                    tree = FindTree();
                }

                return tree;
            }
        }

        /// <summary>
        ///  Called by the tree node collection to clear all nodes.  We optimize here if
        ///  this is the root node.
        /// </summary>
        internal void Clear()
        {
            // This is a node that is a child of some other node.  We have
            // to selectively remove children here.
            //
            bool isBulkOperation = false;
            Tree tree = Tree;

            try
            {
                if (tree is not null)
                {
                    tree.nodesCollectionClear = true;

                    if (tree is not null && childCount > MAX_TREENODES_OPS)
                    {
                        isBulkOperation = true;
                    }
                }

                while (childCount > 0)
                {
                    children[childCount - 1].Remove(true);
                }

                children = null;

                if (tree is not null && isBulkOperation)
                {
                }
            }
            finally
            {
                if (tree is not null)
                {
                    tree.nodesCollectionClear = false;
                }

                nodesCleared = true;
            }
        }

        /// <summary>
        ///  Makes sure there is enough room to add n children
        /// </summary>
        internal void EnsureCapacity(int num)
        {
            Debug.Assert(num > 0, "required capacity can not be less than 1");
            int size = num;
            if (size < 4)
            {
                size = 4;
            }

            if (children is null)
            {
                children = new TreeNode[size];
            }
            else if (childCount + num > children.Length)
            {
                int newSize = childCount + num;
                if (num == 1)
                {
                    newSize = childCount * 2;
                }

                TreeNode[] bigger = new TreeNode[newSize];
                System.Array.Copy(children, 0, bigger, 0, childCount);
                children = bigger;
            }
        }

        /// <summary>
        ///  Locate this tree node's containing tree view control by scanning
        ///  up to the virtual root, whose treeView pointer we know to be
        ///  correct
        /// </summary>
        internal Tree FindTree()
        {
            TreeNode node = this;
            while (node.parent is not null)
            {
                node = node.parent;
            }

            return node.tree;
        }

        /// <summary>
        ///  Helper function for getFullPath().
        /// </summary>
        private void GetFullPath(StringBuilder path, string pathSeparator)
        {
            if (parent is not null)
            {
                parent.GetFullPath(path, pathSeparator);
                if (parent.parent is not null)
                {
                    path.Append(pathSeparator);
                }

                path.Append(text);
            }
        }

        /// <summary>
        ///  Helper function for getFullPath().
        /// </summary>
        private void GetFullOsPath(StringBuilder path, string pathSeparator)
        {
            if (parent is not null)
            {
                parent.GetFullOsPath(path, pathSeparator);
                if (parent.parent is not null)
                {
                    path.Append(pathSeparator);
                }

                path.Append(((OLETag)Tag)?.OSName);
            }
        }

        /// <summary>
        ///  Returns number of child nodes.
        /// </summary>
        public int GetNodeCount(bool includeSubTrees)
        {
            int total = childCount;
            if (includeSubTrees)
            {
                for (int i = 0; i < childCount; i++)
                {
                    total += children[i].GetNodeCount(true);
                }
            }

            return total;
        }

        /// <summary>
        ///  Check for any circular reference in the ancestors chain.
        /// </summary>
        internal void CheckParentingCycle(TreeNode candidateToAdd)
        {
            TreeNode node = this;

            while (node is not null)
            {
                if (node == candidateToAdd)
                {
                    throw new ArgumentException("A circular reference has been made. A TreeNode cannot be added as a descendant of itself.");
                }

                node = node.parent;
            }
        }

        /// <summary>
        ///  Helper function to add node at a given index after all validation has been done
        /// </summary>
        internal void InsertNodeAt(int index, TreeNode node)
        {
            EnsureCapacity(1);
            node.parent = this;
            node.index = index;
            for (int i = childCount; i > index; --i)
            {
                (children[i] = children[i - 1]).index = i;
            }

            children[index] = node;
            childCount++;
        }

        /// <summary>
        ///  Remove this node from the TreeView control.  Child nodes are also removed from the
        ///  TreeView, but are still attached to this node.
        /// </summary>
        public void Remove()
        {
            Remove(true);
        }

        internal void Remove(bool notify)
        {
            // unlink our children
            //
            for (int i = 0; i < childCount; i++)
            {
                children[i].Remove(false);
            }

            // children = null;
            // unlink ourself
            if (notify && parent is not null)
            {
                for (int i = index; i < parent.childCount - 1; ++i)
                {
                    (parent.children[i] = parent.children[i + 1]).index = i;
                }

                parent.children[parent.childCount - 1] = null;
                parent.childCount--;
                parent = null;
            }

            tree = null;
        }

        /// <summary>
        ///  Returns the label text for the tree node
        /// </summary>
        public override string ToString()
        {
            return "TreeNode: " + (text ?? "");
        }
    }
}

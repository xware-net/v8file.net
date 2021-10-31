// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace v8file.net
{
    /// <summary>
    ///  Displays a hierarchical list of items, or nodes. Each
    ///  node includes a caption and an optional bitmap. The user can select a node. If
    ///  it has sub-nodes, the user can collapse or expand the node.
    /// </summary>
    [DefaultProperty(nameof(Nodes))]
    public class Tree
    {
        private const string backSlash = "\\";

        private string pathSeparator = backSlash;

        internal TreeNodeCollection nodes;
        internal TreeNode root;
        internal Hashtable _nodeTable = new();
        internal bool nodesCollectionClear; //this is set when the treeNodeCollection is getting cleared and used by TreeView

        /// <summary>
        ///  Creates a TreeView control
        /// </summary>
        public Tree()
        : base()
        {
            root = new TreeNode(this);
        }

        /// <summary>
        ///  The collection of nodes associated with this TreeView control
        /// </summary>
        [Localizable(true)]
        [MergableProperty(false)]
        public TreeNodeCollection Nodes
        {
            get
            {
                if (nodes is null)
                {
                    nodes = new TreeNodeCollection(root);
                }

                return nodes;
            }
        }

        /// <summary>
        ///  The delimeter string used by TreeNode.getFullPath().
        /// </summary>
        [DefaultValue("\\")]
        public string PathSeparator
        {
            get
            {
                return pathSeparator;
            }
            set
            {
                pathSeparator = value;
            }
        }

        /// <summary>
        ///  Returns count of nodes at root, optionally including all subtrees.
        /// </summary>
        public int GetNodeCount(bool includeSubTrees)
        {
            return root.GetNodeCount(includeSubTrees);
        }

        /// <summary>
        ///  Returns a string representation for this control.
        /// </summary>
        public override string ToString()
        {
            string s = base.ToString();
            if (Nodes is not null)
            {
                s += ", Nodes.Count: " + Nodes.Count.ToString(CultureInfo.CurrentCulture);
                if (Nodes.Count > 0)
                {
                    s += ", Nodes[0]: " + Nodes[0].ToString();
                }
            }

            return s;
        }
    }
}

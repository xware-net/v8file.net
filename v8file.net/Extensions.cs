using OpenMcdf.Extensions.OLEProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v8file.net
{
    public static class Extensions
    {
        // Return all of the TreeView's nodes.
        public static IEnumerable<TreeNode> Descendants(this Tree tree)
        {
            foreach (TreeNode node in tree.Nodes.Descendants())
                yield return node;
        }

        // Return the nodes in this collection and their descendants.
        public static IEnumerable<TreeNode> Descendants(
            this TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                yield return node;
                foreach (TreeNode child in node.Nodes.Descendants())
                {
                    yield return child;
                }
            }
        }

        // Return this node and its descendants.
        public static IEnumerable<TreeNode> Descendants(this TreeNode node)
        {
            yield return node;
            foreach (TreeNode child in node.Nodes.Descendants())
            {
                yield return child;
            }
        }

        public static String GetDescription(this uint identifier, ContainerType map, Dictionary<uint, string> customDict = null)
        {
            Dictionary<uint, string> NameDictionary = new Dictionary<uint, string>();

            if (customDict == null)
            {
                switch (map)
                {
                    case ContainerType.SummaryInfo:
                        NameDictionary = CommonIdentifiers.PropertyIdentifiersSummaryInfo;
                        break;
                    case ContainerType.DocumentSummaryInfo:
                        NameDictionary = CommonIdentifiers.PropertyIdentifiersDocumentSummaryInfo;
                        break;
                    case ContainerType.AppSpecific:
                        NameDictionary = CommonIdentifiers.PropertyIdentifiersAppSpecificInfo;
                        break;
                }
            }
            else
            {
                NameDictionary = customDict;
            }

            if (NameDictionary.ContainsKey(identifier))
            {
                return NameDictionary[identifier];
            }

            return "0x" + identifier.ToString("x8");
        }
    }
}

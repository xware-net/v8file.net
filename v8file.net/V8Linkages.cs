using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v8file.net
{
    public class V8Linkages
    {
        public static Linkage[] V8GetLinkages(BinaryReader br, Elm_hdr ehdr)
        {
            Linkage[] linkages = new Linkage[0];

            // saves/restores current reader position
            // so we can call it whenever we want
            var currentReaderPosition = br.BaseStream.Position;
            // read element header
            int attributesSize = (int)(ehdr.ElementSize - ehdr.AttrOffset);
            if (attributesSize == 0)
                return linkages;

            // seek at beginning of attributes
            br.BaseStream.Seek(ehdr.HeaderPosition + 2 * ehdr.AttrOffset, SeekOrigin.Begin);
            int i = 0;
            do
            {
                Array.Resize(ref linkages, linkages.Length + 1);
                var linkage = new Linkage().Read(br);
                linkages[linkages.Length - 1] = linkage;
                int exponent = 0; // linkage.LinkageHeader.WdExponent;
                int length = linkage.LinkageHeader.WdMantissa * Utils.V8Power2(exponent);
                if (exponent == 0)
                {
                    i += length + 1;
                }
                else
                {
                    i += length;
                }
            } while (i < attributesSize);

            br.BaseStream.Seek(currentReaderPosition, SeekOrigin.Begin);
            return linkages;
        }

        public static string V8GetStringLinkage(Linkage[] linkages, LinkageKeyValuesString key)
        {
            foreach (var linkage in linkages)
            {
                if (linkage.Type == LinkageIds.LINKAGEID_String)
                {
                    StringLinkage stringLinkage = new(linkage.Data);
                    if (stringLinkage.Key == key)
                        return stringLinkage.String;
                }
            }

            return string.Empty;
        }
   }
}

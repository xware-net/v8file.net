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
        public static Linkage[] V8GetLinkages(BinaryReader br, Elm_hdr ehdr, bool is3d = false)
        {
            Linkage[] linkages = Array.Empty<Linkage>();

            // saves/restores current reader position
            // so we can call it whenever we want
            var currentReaderPosition = br.BaseStream.Position;
            // read element header
            int attributesSize = (int)(ehdr.ElementSize - ehdr.AttrOffset);
            if (attributesSize == 0)
            {
                br.BaseStream.Seek(currentReaderPosition, SeekOrigin.Begin);
                return linkages;
            }

            // seek at beginning of attributes
            br.BaseStream.Seek(ehdr.HeaderPosition + 2 * ehdr.AttrOffset, SeekOrigin.Begin);
            int i = 0;
            while (i < attributesSize)
            {
                // Peek the linkage header first. C++ stops at the element's
                // attribute-word bound (na), so a linkage that claims more
                // words than remain must not be read as a linkage.
                var headerPosition = br.BaseStream.Position;
                var probe = new LinkageHeader().Read(br);
                br.BaseStream.Seek(headerPosition, SeekOrigin.Begin);

                if (probe.IsEmpty)
                {
                    // V8 zero padding ends the linkage area; the rest of the
                    // attribute words are not linkages.
                    break;
                }

                int length = Linkage.GetTotalWordCount(probe);
                if (length <= 0 || i + length > attributesSize)
                    break;

                var linkage = new Linkage().Read(br, is3d);
                Array.Resize(ref linkages, linkages.Length + 1);
                linkages[^1] = linkage;
                i += length;
            }

            br.BaseStream.Seek(currentReaderPosition, SeekOrigin.Begin);
            return linkages;
        }

        public static string V8GetStringLinkage(Linkage[] linkages, LinkageKeyValuesString key)
        {
            foreach (var linkage in linkages)
            {
                if (linkage.Type == LinkageIds.LINKAGEID_String)
                {
                    StringLinkage stringLinkage = new(linkage, linkage.Data);
                    if (stringLinkage.Key == key)
                        return stringLinkage.String;
                }
            }

            return string.Empty;
        }
   }
}

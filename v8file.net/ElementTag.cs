using System;
using System.Collections.Generic;
using System.Text;

namespace v8file.net
{
    public class ElementTag
    {
        public string CacheType { get; set; }
        public int ModelNum { get; set; }
        public int CacheNum { get; set; }
        public int CachePos { get; set; }
        public Elm_hdr ElementHeader { get; set; }
        public Disp_hdr DisplayHeader { get; set; }
        public int ComponenetCount { get; set; }
        public UInt64 ParentId { get; set; }
        public UInt64 ElementId { get; set; }
    }
}

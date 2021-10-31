using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v8file.net
{

    public enum Status : int
    {
        Unchanged = 0,
        New = 1,
        Modified = 2,
    }

    public class OLETag
    {
        public string Name { get; set; }
        public string OSName { get; set; }
        public int Type { get; set; }
        public string TypeString { get; set; }
        public long Size { get; set; }
        public Status Status { get; set; }
        public bool Compressed { get; set; }
    }
}

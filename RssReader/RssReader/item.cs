using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader {
    class item {
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime pubData { get; set; }
        public string Description {get;set;}
    }
}

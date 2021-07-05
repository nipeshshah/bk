using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONFw.Models
{
    public class RequestNewEntry
    {
        public string formtype { get; set; }
        public string title { get; set; }

        public string text2 { get; set; }

        public string text3 { get; set; }

        public string text4 { get; set; }
    }

    public class RequestForm2
    {
        public string key1 { get; set; }
        public string formtype { get; set; }
        public string title { get; set; }
        public string text1 { get; set; }
        public string text2 { get; set; }
    }
}

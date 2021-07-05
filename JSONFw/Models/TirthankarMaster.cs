using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONFw.Models
{
    public enum TirthType
    {
        Tirthankar,
        Yaksh,
        Devi,
        GuruMaharaj,
        Other
    }
    public class IdolMaster
    {
        internal int id { get; set; }
        public string title { get; set; }
        public TirthType type { get; set; }
    }

    public class TrustMaster
    {
        internal int id { get; set; }
        public string title { get; set; }
    }

    public class CityMaster
    {
        internal int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

    public enum NewEntryType
    {
        ttk,
        tru,
        cty
    }

    public class SubmitNewEntity
    {
        public int id { get; set; }
        public NewEntryType newentrytype { get; set; }
        public string value { get; set; }
        public DateTime requestdate { get; set; }
        public string status { get; set; }
    }
}

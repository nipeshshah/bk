using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONFw.Models
{
    public class ResponseSearchedTemples
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Moolnayak { get; set; }
        public string City { get; set; }
        public int DharmshalaCount { get; set; }
        public int BhojanshalaCount { get; set; }
    }

    public class ResponseDropDownItem
    {
        public int value { get; set; }
        public string title { get; set; }
    }

    public class Temple
    {
        public int id { get; set; }
        public string Title { get; set; }
        public IdolMaster MoolnayakId { get; set; }
        public List<IdolMaster> OtherBhagwant { get; set; }
        public List<IdolMaster> Yakshs { get; set; }
        public List<IdolMaster> Devis { get; set; }
        public List<IdolMaster> GuruMaharaj { get; set; }
        public List<IdolMaster> Pagla { get; set; }
        public string ContactNumber { get; set; }
        public string ContactDetails { get; set; }
        public TrustMaster Trust { get; set; }
        public CityMaster City { get; set; }
        public List<string> MoolnayakImage { get; set; }
        public List<string> TempleImage { get; set; }
    }

    public class BSh
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string ContactNumbers { get; set; }
        public string EmailAddress { get; set; }
        public TrustMaster Trust { get; set; }
        public string ContactPerson { get; set; }
    }

    public class DSh
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string ContactNumbers { get; set; }
        public string EmailAddress { get; set; }
        public TrustMaster Trust { get; set; }
        public string ContactPerson { get; set; }
    }

    public class Apsr
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public string ContactNumbers { get; set; }
        public string EmailAddress { get; set; }
        public TrustMaster Trust { get; set; }
        public string ContactPerson { get; set; }
    }

    public class Desc
    {
        public string Content { get; set; }
        public string UserDisplayName { get; set; }
        public DateTime SubmittedOn { get; set; }
    }
}

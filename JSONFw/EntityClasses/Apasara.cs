//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JSONFw.EntityClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apasara
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string ContactNumbers { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> TrustId { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<int> CityId { get; set; }
    
        public virtual CityMaster CityMaster { get; set; }
    }
}

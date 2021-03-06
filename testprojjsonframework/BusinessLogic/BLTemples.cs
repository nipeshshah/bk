using JSONFw.EntityClasses;
using JSONFw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace testprojjsonframework.BusinessLogic
{
    public class BLTemples
    {
        JSONFw.EntityClasses.jinsasan2db db = new JSONFw.EntityClasses.jinsasan2db();
        internal List<ResponseSearchedTemples> GetSearchedTemples(RequestSearchModal searchModal)
        {
            var dbtemples = db.SearchTemple
                (searchModal.IdolId, 
                searchModal.CityId, 
                searchModal.TrustId, 
                searchModal.HasDshala, 
                searchModal.HasBshala);
                //db.TempleTables.Where(
                //    t => t.Title != null && 
                //    t.TempleIdolMappings.Any(x => x.IdolId == searchModal.IdolId) &&
                //    t.TrustId == searchModal.TrustId &&
                //    t.CityId == searchModal.CityId &&
                //    (
                //        (searchModal.HasBshala && t.CityMaster.Bhojanshalas.Count > 0) ||
                //        (!searchModal.HasBshala)
                //    ) &&
                //    (
                //        (searchModal.HasDshala && t.CityMaster.Dharmshalas.Count > 0) ||
                //        (!searchModal.HasDshala)
                //    )
                //    );

            List<ResponseSearchedTemples> temples = new List<ResponseSearchedTemples>();
            foreach(SearchTemple_Result item in dbtemples)
            {
                temples.Add(new ResponseSearchedTemples()
                {
                    Id = item.Id,
                    Title = item.Title,
                    City = item.City,
                    Moolnayak = item.Moolnayak,
                    BhojanshalaCount = item.HasBhojanshala.Value,
                    DharmshalaCount = item.HasDharmshala.Value
                });
            }
            return temples;
        }

        internal List<ResponseDropDownItem> GetIdolTypes()
        {
            List<IdolType> idols = db.IdolTypes.ToList();
            List<ResponseDropDownItem> items = new List<ResponseDropDownItem>();
            foreach(IdolType idol in idols)
            {
                items.Add(new ResponseDropDownItem()
                {
                    value = idol.Id,
                    title = idol.Title
                });
            }
            return items;
        }

        internal List<ResponseDropDownItem> GetIdols(int IdolTypeId, string searchstring)
        {
            List<JSONFw.EntityClasses.IdolMaster> idols = db.IdolMasters.Where(t => t.IdolTypeId == IdolTypeId).ToList();
            List<ResponseDropDownItem> items = new List<ResponseDropDownItem>();
            foreach(JSONFw.EntityClasses.IdolMaster idol in idols)
            {
                items.Add(new ResponseDropDownItem()
                {
                    value = idol.Id,
                    title = idol.Title
                });
            }
            return items;
        }

        internal void AddCity(string title, string state, string country)
        {
            CountryMaster countryMaster;
            StateMaster stateMaster;
            
            if(db.StateMasters.Where(t => t.Title.ToLower() == state.ToLower() && t.CountryMaster.Title == country).Count() == 0)
            {
                if(db.CountryMasters.Where(t => t.Title.ToLower() == country.ToLower()).Count() == 0)
                {
                    countryMaster = db.CountryMasters.Add(new CountryMaster()
                    {
                        Title = country
                    });
                    db.SaveChanges();
                }
                else
                {
                    countryMaster = db.CountryMasters.Where(t => t.Title.ToLower() == country.ToLower()).First();
                }

                stateMaster = db.StateMasters.Add(new StateMaster()
                {
                    Title = state,
                    CountryId = countryMaster.Id
                });

                db.SaveChanges();
            }
            else
            {
                stateMaster = db.StateMasters.Where(t => t.Title.ToLower() == state.ToLower()).First();
            }

            db.CityMasters.Add(new JSONFw.EntityClasses.CityMaster
            {
                Name = title,
                StateMaster = stateMaster
            });
            db.SaveChanges();
        }

        internal void AddTrust(string title)
        {
            db.TrustMasters.Add(new JSONFw.EntityClasses.TrustMaster
            {
                Title = title
            });
            db.SaveChanges();
        }

        internal void AddTemple(string title)
        {
            db.TempleTables.Add(new TempleTable()
            {
                Title = title
            });
            db.SaveChanges();
        }

        internal List<ResponseDropDownItem> GetCities(string searchstring)
        {
            List<JSONFw.EntityClasses.CityMaster> cities = db.CityMasters.Where(t => t.Name.Contains(searchstring)).ToList();
            List<ResponseDropDownItem> items = new List<ResponseDropDownItem>();
            foreach(JSONFw.EntityClasses.CityMaster city in cities)
            {
                items.Add(new ResponseDropDownItem()
                {
                    value = city.Id,
                    title = city.Name + ", " + city.StateMaster.Title + ", " + city.StateMaster.CountryMaster.Title
                });
            }
            return items;
        }

        internal TempleTable GetTemple(int templeid)
        {
            return db.TempleTables.Where(t => t.Id == templeid)
                .FirstOrDefault();
        }
    }
}
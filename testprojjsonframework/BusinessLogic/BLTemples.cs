using JSONFw.EntityClasses;
using JSONFw.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace testprojjsonframework.BusinessLogic
{
    public class BLTemples
    {
        JSONFw.EntityClasses.jinsasan2db db = new JSONFw.EntityClasses.jinsasan2db();
        internal List<ResponseSearchedTemples> GetSearchedTemples(string v)
        {
            List<TempleTable> dbtemples = db.TempleTables.Where(t => t.Title != null).ToList();
            List<ResponseSearchedTemples> temples = new List<ResponseSearchedTemples>();
            foreach(TempleTable item in dbtemples)
            {
                temples.Add(new ResponseSearchedTemples()
                {
                    Id = item.Id,
                    City = item.CityMaster.Name + ", " + item.CityMaster.StateMaster.Title + ", " + item.CityMaster.StateMaster.CountryMaster.Title,
                    Moolnayak = item.TempleIdolMappings.First().IdolMaster.Title,
                    BhojanshalaCount = item.CityMaster.Bhojanshalas.Count,
                    DharmshalaCount = item.CityMaster.Dharmshalas.Count
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
    }
}
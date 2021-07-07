using JSONFw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testprojjsonframework.BusinessLogic
{
    public class BLMaster
    {
        JSONFw.EntityClasses.jinsasan2db db = new JSONFw.EntityClasses.jinsasan2db();
        internal List<ResponseDropDownItem> GetCities()
        {
            List<ResponseDropDownItem> responses = new List<ResponseDropDownItem>();
            foreach(var cm in db.CityMasters)
            {
                responses.Add(new ResponseDropDownItem()
                {
                    title = cm.Name + ", " + cm.StateMaster.Title + ", " + cm.StateMaster.CountryMaster.Title,
                    value = cm.Id
                });
            }
            return responses;
        }

        internal List<ResponseDropDownItem> GetMoolnayaks()
        {
            List<ResponseDropDownItem> responses = new List<ResponseDropDownItem>();
            foreach(var cm in db.IdolMasters)
            {
                responses.Add(new ResponseDropDownItem()
                {
                    title = cm.Title + " (" + cm.IdolType.Title + ")",
                    value = cm.Id
                });
            }
            return responses; 
        }

        internal List<ResponseDropDownItem> GetTrusts()
        {
            List<ResponseDropDownItem> responses = new List<ResponseDropDownItem>();
            foreach(var cm in db.TrustMasters)
            {
                responses.Add(new ResponseDropDownItem()
                {
                    title = cm.Title,
                    value = cm.Id
                });
            }
            return responses;
        }

        internal List<ResponseDropDownItem> GetIdols(int idolTypeId)
        {
            List<ResponseDropDownItem> responses = new List<ResponseDropDownItem>();
            foreach(var cm in db.IdolMasters.Where(t => t.IdolTypeId == idolTypeId))
            {
                responses.Add(new ResponseDropDownItem()
                {
                    title = cm.Title,
                    value = cm.Id
                });
            }
            return responses;
        }

    }
}
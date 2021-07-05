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
        internal void GetCities()
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
        }
    }
}
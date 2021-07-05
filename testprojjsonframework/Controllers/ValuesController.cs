using JSONFw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testprojjsonframework.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [Route("api/searchtps")]
        public IHttpActionResult GetSearchedTemples()
        {
            BusinessLogic.BLTemples temples = new BusinessLogic.BLTemples();
            return Ok(temples.GetSearchedTemples(""));
        }

        [Route("api/idoltypes")]
        public IHttpActionResult GetIdolTypes()
        {
            BusinessLogic.BLTemples temples = new BusinessLogic.BLTemples();
            return Ok(temples.GetIdolTypes());
        }

        [Route("api/idol/{idoltypeid}/searchstring")]
        public IHttpActionResult GetIdols(int idoltypeid, string searchstring)
        {
            BusinessLogic.BLTemples temples = new BusinessLogic.BLTemples();
            return Ok(temples.GetIdols(idoltypeid, searchstring));
        }

        [Route("api/cities/searchstring")]
        public IHttpActionResult GetCities(string searchstring)
        {
            BusinessLogic.BLTemples temples = new BusinessLogic.BLTemples();
            return Ok(temples.GetCities(searchstring));
        }

        [HttpPost]
        [Route("api/submitnewentry")]
        public IHttpActionResult SubmitNewEntry(RequestNewEntry newEntry)
        {
            BusinessLogic.BLEntryRequests entryRequests = new BusinessLogic.BLEntryRequests();
            //System.IO.File.AppendAllText(@"C:\Users\nipesh.shah\source\repos\testprojjsonframework\testprojjsonframework\Temp.csv", "Type," + newEntry.formtype + "\n");
            if (newEntry.formtype == "temple")
            {
                entryRequests.AddRequestWith1Field(newEntry.formtype, newEntry.title);                
            }
            else if (newEntry.formtype == "city")
            {
                entryRequests.AddRequestWith3Field(newEntry.formtype, newEntry.title, newEntry.text3, newEntry.text2);
            }
            else if(newEntry.formtype == "trust")
            {
                entryRequests.AddRequestWith1Field(newEntry.formtype, newEntry.title);
            }
            else if(newEntry.formtype == "trust")
            {
                entryRequests.AddRequestWith1Field(newEntry.formtype, newEntry.title);
            }
            else if(newEntry.formtype == "idol")
            {
                entryRequests.AddRequestWith2Field(newEntry.formtype, newEntry.title, newEntry.text4);
            }
            
            return Ok(newEntry);
        }

        [HttpPost]
        [Route("api/submitform2")]
        public IHttpActionResult SubmitForm2(RequestForm2 newEntry)
        {
            BusinessLogic.BLEntryRequests entryRequests = new BusinessLogic.BLEntryRequests();
            if (newEntry.formtype == "temple-contactdetails" ||
                newEntry.formtype == "temple-contactnumber" ||
                newEntry.formtype == "bhs-address")
            {
                entryRequests.AddRequestWith1FieldAndKey(newEntry.formtype, newEntry.key1, newEntry.title);
            }
            else if (newEntry.formtype == "temple-city" ||
                newEntry.formtype == "temple-mainidol" ||
                    newEntry.formtype == "temple-trust" ||
                newEntry.formtype == "temple-otheridol" ||
                newEntry.formtype == "temple-yaksh" ||
                newEntry.formtype == "temple-devis" ||
                newEntry.formtype == "temple-gurumaharaj" ||
                newEntry.formtype == "temple-charanpagla"
                )
            {
                entryRequests.AddRequestWith1FieldAndKey(newEntry.formtype, newEntry.key1, newEntry.text1);
            }
            else if(newEntry.formtype == "temple-mainidolimage" ||
                newEntry.formtype == "temple-image")
            {
                entryRequests.AddRequestWith2FieldAndKey(newEntry.formtype, newEntry.key1, newEntry.text1, newEntry.text2);
            }
                return Ok(newEntry);
        }

        [HttpPost]
        [Route("api/submitform3")]
        public IHttpActionResult SubmitForm3(RequestForm2 newEntry)
        { 
            BusinessLogic.BLEntryRequests entryRequests = new BusinessLogic.BLEntryRequests();
            if (newEntry.formtype == "city-location")
            {
                entryRequests.AddRequestWith2FieldAndKey(newEntry.formtype, newEntry.key1, newEntry.title, newEntry.text1);
            }
            else if (newEntry.formtype == "city-bhojanshala" ||
                newEntry.formtype == "city-dharmshala" ||
                newEntry.formtype == "city-apasara")
            {
                entryRequests.AddRequestWith1FieldAndKey(newEntry.formtype, newEntry.key1, newEntry.title);
            }
            return Ok(newEntry);
        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}

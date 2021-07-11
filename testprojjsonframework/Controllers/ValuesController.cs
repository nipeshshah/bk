using JSONFw.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace testprojjsonframework.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpPost]
        [Route("api/searchtps")]
        public IHttpActionResult GetSearchedTemples(RequestSearchModal searchModal)
        {
            BusinessLogic.BLTemples temples = new BusinessLogic.BLTemples();
            return Ok(temples.GetSearchedTemples(searchModal));
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
            if(newEntry.formtype == "temple")
            {
                entryRequests.AddRequestWith1Field(newEntry.formtype, newEntry.title);
            }
            else if(newEntry.formtype == "city")
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
            if(newEntry.formtype == "temple-contactdetails" ||
                newEntry.formtype == "temple-contactnumber" ||
                newEntry.formtype == "bhs-address" ||
                newEntry.formtype == "bhs-contactnumbers" ||
                newEntry.formtype == "bhs-contactperson" ||
                newEntry.formtype == "dhs-address" ||
                newEntry.formtype == "dhs-contactnumbers" ||
                newEntry.formtype == "dhs-contactperson" ||
                newEntry.formtype == "aps-address" ||
                newEntry.formtype == "aps-contactnumbers" ||
                newEntry.formtype == "aps-contactperson")
            {
                entryRequests.AddRequestWith1FieldAndKey(newEntry.formtype, newEntry.key1, newEntry.title);
            }
            else if(newEntry.formtype == "temple-city" ||
                newEntry.formtype == "temple-mainidol" ||
                    newEntry.formtype == "temple-trust" ||
                newEntry.formtype == "temple-otheridol" ||
                newEntry.formtype == "temple-yaksh" ||
                newEntry.formtype == "temple-devis" ||
                newEntry.formtype == "temple-gurumaharaj" ||
                newEntry.formtype == "temple-charanpagla" ||
                newEntry.formtype == "bhs-trust" ||
                newEntry.formtype == "dhs-trust" ||
                newEntry.formtype == "aps-trust"
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
            if(newEntry.formtype == "city-location")
            {
                entryRequests.AddRequestWith2FieldAndKey(newEntry.formtype, newEntry.key1, newEntry.title, newEntry.text1);
            }
            else if(newEntry.formtype == "city-bhojanshala" ||
                newEntry.formtype == "city-dharmshala" ||
                newEntry.formtype == "city-apasara")
            {
                entryRequests.AddRequestWith1FieldAndKey(newEntry.formtype, newEntry.key1, newEntry.title);
            }
            return Ok(newEntry);
        }

        [HttpGet]
        [Route("api/load/{tag}")]
        public IHttpActionResult LoadDropdown(string tag)
        {
            List<ResponseDropDownItem> dropdownlist = new List<ResponseDropDownItem>();
            BusinessLogic.BLMaster master = new BusinessLogic.BLMaster();
            if(tag == "city")
            {
                dropdownlist = master.GetCities();
            }
            else if(tag == "idol")
            {
                dropdownlist = master.GetMoolnayaks();
            }
            else if(tag == "trust")
            {
                dropdownlist = master.GetTrusts();
            }
            else if(tag == "yaksh")
            {
                dropdownlist = master.GetIdols(3);
            }
            else if(tag == "devis")
            {
                dropdownlist = master.GetIdols(4);
            }
            else if(tag == "gurumaharaj")
            {
                dropdownlist = master.GetIdols(5);
            }
            else if(tag == "pagla")
            {
                dropdownlist = master.GetIdols(5);
            }


            return Ok(dropdownlist);
        }

        [HttpGet]
        [Route("api/loadtirth/{templeid}")]
        public IHttpActionResult LoadTirth(int templeid)
        {
            BusinessLogic.BLTemples temples = new BusinessLogic.BLTemples();
            return Ok(temples.GetTemple(templeid));
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

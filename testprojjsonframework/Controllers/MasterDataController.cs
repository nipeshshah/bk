using JSONFw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testprojjsonframework.Controllers
{
    public class MasterDataController : ApiController
    {
        [HttpGet]
        [Route("api/masters/ttk/load")]
        public IHttpActionResult GetTTKMasters()
        {
            JSONFw.DataManager dm = new JSONFw.DataManager();
            List<IdolMaster> tm = dm.LoadTirthMaster();
            return Ok(new
            {
                status = "Success",
                message = "Data retrieved successfully",
                data = tm
            });
        }

        [HttpGet]
        [Route("api/masters/ttk/load/{searchstring}")]
        public IHttpActionResult GetSearchedTTKMasters(string searchstring)
        {
            JSONFw.DataManager dm = new JSONFw.DataManager();
            List<IdolMaster> tm = dm.LoadTirthMaster(searchstring);
            return Ok(new
            {
                status = "Success",
                message = "Data retrieved successfully",
                data = tm
            });
        }

        [HttpGet]
        [Route("api/masters/tru/load")]
        public IHttpActionResult GetTrustMasters()
        {
            JSONFw.DataManager dm = new JSONFw.DataManager();
            List<TrustMaster> tm = dm.LoadTrustMaster();
            return Ok(new
            {
                status = "Success",
                message = "Data retrieved successfully",
                data = tm
            });
        }

        [HttpGet]
        [Route("api/masters/tru/load/{searchstring}")]
        public IHttpActionResult GetSearchedTrustMasters(string searchstring)
        {
            JSONFw.DataManager dm = new JSONFw.DataManager();
            List<TrustMaster> tm = dm.LoadTrustMaster(searchstring);
            return Ok(new
            {
                status = "Success",
                message = "Data retrieved successfully",
                data = tm
            });
        }

        [HttpGet]
        [Route("api/masters/cty/load")]
        public IHttpActionResult GetCityMasters()
        {
            JSONFw.DataManager dm = new JSONFw.DataManager();
            List<CityMaster> tm = dm.LoadCityMaster();
            return Ok(new
            {
                status = "Success",
                message = "Data retrieved successfully",
                data = tm
            });
        }

        [HttpGet]
        [Route("api/masters/cty/load/{searchstring}")]
        public IHttpActionResult GetSearchedCityMasters(string searchstring)
        {
            JSONFw.DataManager dm = new JSONFw.DataManager();
            List<CityMaster> tm = dm.LoadCityMaster(searchstring);
            return Ok(new
            {
                status = "Success",
                message = "Data retrieved successfully",
                data = tm
            });
        }


        [HttpPost]
        [Route("api/data/new")]
        public IHttpActionResult SubmitNewData(SubmitNewEntity newEntity)
        {
            JSONFw.DataManager dm = new JSONFw.DataManager();
            bool tm = dm.SubmitNewEntity(newEntity);
            return Ok(new
            {
                status = "Success",
                message = "Data retrieved successfully",
                data = tm
            });
        }



        //[HttpPost]
        //[Route("api/masters/create")]
        //public IHttpActionResult AddTTKMasters(TirthankarMaster newtm)
        //{
        //    JSONFw.DataManager dm = new JSONFw.DataManager();
        //    List<TirthankarMaster> tm = dm.LoadTirthMaster();
        //    newtm.id = tm.Max(t => t.id) + 1;
        //    tm.Add(newtm);

        //    dm.AddTirthMaster(tm);
        //    return Ok(new
        //    {
        //        status = "Success",
        //        message = "Data retrieved successfully",
        //        data = tm
        //    });
        //}
    }
}

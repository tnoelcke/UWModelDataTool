using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UWDataApi.Repos;

namespace UWDataApi.Controllers
{
    [Route("api/UwDataController")]
    [ApiController]
    public class UwDataController : ControllerBase
    {
        private IUwModelRunRepo uwRepo;

        UwDataController(IUwModelRunRepo repo)
        {
            uwRepo = repo;
        }

        [Route("GetList")]
        public ActionResult GetList()
        {
            return null;
        }

        [Route("GetIds")]
        public ActionResult GetIds()
        {
            return null;
        }

        [Route("GetById/{Id}")]
        public ActionResult GetById( int Id)
        {
            return null;
        }

        [HttpPost]
        [Route("GetByDataRange")]
        public ActionResult GetByDateRange()
        {
            return null;
        }

        [HttpPost]
        [Route("Create")]
        public ActionResult Create()
        {
            return null;
        }

        [Route("Delete/{Id}")]
        public ActionResult Delete(int Id)
        {
            return null;
        }
    }
}
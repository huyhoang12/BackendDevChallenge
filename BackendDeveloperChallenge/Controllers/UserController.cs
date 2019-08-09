using BenchmarkDotNet.Reports;
using Prometheus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendDeveloperChallenge.Controllers
{
    public class UserController : ApiController
    {

        /// fetch all User
        [AllowAnonymous]
        [HttpGet]
             public List<tbl_User> GetUserLists()
             {
            DBPhotoDataContext db = new DBPhotoDataContext();
            return db.tbl_Users.ToList();
             }
      
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BackendDeveloperChallenge.Controllers
{
    public class PhotoController : ApiController
    {
        /// fetch all Photo
      
        [HttpGet]
        public List<tbl_Photo> GetPhotoLists()
        {
            DBPhotoDataContext db = new DBPhotoDataContext();
            return db.tbl_Photos.ToList();

        }
        //fetch  Photo by id
        [HttpGet]
        public tbl_Photo GetPhoto(int id)
        {
            DBPhotoDataContext db = new DBPhotoDataContext();
            return db.tbl_Photos.FirstOrDefault(x => x.PhotoId == id);
        }

    }
}

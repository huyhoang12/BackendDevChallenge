using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BackendDeveloperChallenge.Controllers
{
    public class AlbumController : ApiController
    {
        /// fetch all Album

        [HttpGet]
        public List<tbl_Album> GetAlbumLists()
        {
            DBPhotoDataContext db = new DBPhotoDataContext();
            return db.tbl_Albums.ToList();
        }
        //fetch  album by id
        [HttpGet]
        public tbl_Album GetAlbum(int id)
        {
            DBPhotoDataContext db = new DBPhotoDataContext();
            return db.tbl_Albums.FirstOrDefault(x => x.AlbumId == id);
        }

    }
}

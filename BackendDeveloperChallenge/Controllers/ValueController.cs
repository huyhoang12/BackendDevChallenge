using BackendDeveloperChallenge.Filters;
using System.Web.Http;

namespace WebApi.Jwt.Controllers
{
    public class ValueController : ApiController
    {
        [JwtAuthentication]
        public string Get()
        {
            return "value";
        }
    }
}

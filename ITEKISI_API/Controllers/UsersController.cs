using ITEKISI_DATA_LIBRARY.DataAccess;
using ITEKISI_DATA_LIBRARY.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;


namespace ITEKISI_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        UserData userData = new UserData();
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            return userData.GetUserById(userId).First();
        }


    }
}

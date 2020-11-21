using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ITEKISI_DATA_LIBRARY.Models;
using ITEKISI_DATA_LIBRARY.DataAccess;


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

        public void PostUser(UserModel val)
        {
            UserData userData = new UserData();
            userData.PostUserInfo(val);
        }

    }
}

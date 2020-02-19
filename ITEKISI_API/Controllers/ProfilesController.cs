using ITEKISI_API.Models;
using ITEKISI_DATA_LIBRARY.DataAccess;
using ITEKISI_DATA_LIBRARY.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProfileModel = ITEKISI_DATA_LIBRARY.Models.ProfileModel;

namespace ITEKISI_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/Profile")]
    public class ProfilesController : ApiController
    {
        // GET: api/Profiles
        public ProfileModel GetProfileId()
        {
            ProfileData profileData = new ProfileData();
            string userId = RequestContext.Principal.Identity.GetUserId();
            return profileData.GetProfileById(userId).First();
        }
    }
}

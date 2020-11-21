
using ITEKISI_DATA_LIBRARY.DataAccess;
using ITEKISI_DATA_LIBRARY.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;


namespace ITEKISI_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/Profile")]
    public class ProfilesController : ApiController
    {
        // GET: api/Profile/{id}
        [HttpGet]
        public ProfileModel GetById()
        {
            ProfileData profileData = new ProfileData();
            string userId = RequestContext.Principal.Identity.GetUserId();
            return profileData.GetProfileById(userId).First();
        }
        // GET: api/Profiles
        [HttpGet]
        public List<ProfileModel> GetAll()
        {
            ProfileData profile = new ProfileData();
            return profile.GetAllProfiles().ToList();
        }

        //Post:api/Profile/{id}
        [HttpPost]
        public void PostProfile(UserModel userModel, ProfileModel profileModel)
        {
      
            ProfileData profileData = new ProfileData();
            profileModel.UserId = userModel.Id;
            profileData.PostProfile(profileModel);
        }

        //Delete:api/Profile/{id}
        [HttpDelete]
        public int DeleteProfile(ITEKISI_DATA_LIBRARY.Models.DeleteProfileBindingModel model)
        {
            ProfileData profile = new ProfileData();
            int rowsAfected = profile.DeleteProfile(model);
            return rowsAfected;
        }

    }

}

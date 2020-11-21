
using ITEKISI_DATA_LIBRARY.DataAccess;
using ITEKISI_DATA_LIBRARY.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProfileModel = ITEKISI_DATA_LIBRARY.Models.ProfileModel;


namespace ITEKISI_API.Controllers
{
    [Authorize]
    [RoutePrefix("api/Profile")]
    public class ProfilesController : ApiController
    {
        // GET: api/Profile/{id}
        [Route("ProfileInfo")]
        [HttpGet]
        public ProfileModel GetById()
        {
            ProfileData profileData = new ProfileData();
            string userId = RequestContext.Principal.Identity.GetUserId();
            return profileData.GetProfileById(userId).First();
        }
        // GET: api/Profiles
        [Route("Profiles")]
        [HttpGet]
        public List<ProfileModel> GetAll()
        {
            ProfileData profile = new ProfileData();
            return profile.GetAllProfiles().ToList();
        }
        [Route("RegisterProfile")]
        //Post:api/Profile/{id}
        [HttpPost]
        public void PostProfile(ProfileModel profileModel)
        {
      
            ProfileData profileData = new ProfileData();
           // ProfileBindingModel pbm = new ProfileBindingModel();
            try
            {
                //This is temporary since the userId will be gotten via the pbm
                            //getting the current logged user id
                string userId = RequestContext.Principal.Identity.GetUserId();
                profileModel.UserId = userId;

                profileData.PostProfile(profileModel);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        [Route("DeleteProfile")]
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

using ITEKISI_DATA_LIBRARY.Internal.DataAcces;
using ITEKISI_DATA_LIBRARY.Models;
using System;
using System.Collections.Generic;

namespace ITEKISI_DATA_LIBRARY.DataAccess
{
    public class ProfileData
    {
        //get a profile
        public List<ProfileBindingModel> GetProfileById(string userId)
        {
            var p = new { UserId = userId };
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<ProfileBindingModel, dynamic>("dbo.spProfileLookUp",p, "ITEKISI_DB");
            return output;
        }

        //get all profiles
        public List<ProfileModel> GetAllProfiles()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<ProfileModel, dynamic>("dbo.spProfilesLookUP", new { }, "ITEKISI_DB");
            return output;
        }

        public void PostProfile(ProfileModel val)
        {
            SqlDataAccess sql = new SqlDataAccess();
            sql.SaveData<ProfileModel>("dbo.spProfileInsert", val, "ITEKISI_DB");
        }


        public int DeleteProfile(DeleteProfileBindingModel model)
        {
            SqlDataAccess sql = new SqlDataAccess();
            int rowsAffected = sql.SaveData("dbo.spProfileRemove", model, "ITEKISI_DB");
            return rowsAffected;
        }

        public void PostProfileInfo(ProfileModel profileModel)
        {
            throw new NotImplementedException();
        }
    }
}

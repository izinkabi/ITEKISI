using ITEKISI_DATA_LIBRARY.Internal.DataAcces;
using ITEKISI_DATA_LIBRARY.Models;
using System.Collections.Generic;

namespace ITEKISI_DATA_LIBRARY.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            var p = new { Id = Id };

            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<UserModel, dynamic>("dbo.spUserLookUp", p, "ITEKISI_DB");
            return output;
        }

        private List<UserModel> GetUserByUsername(string email)
        {
            var p = new { Email = email };

            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<UserModel, dynamic>("dbo.spASPUserLoopUp", p, "DefaultConnection");
            return output; 
        }
        //con-st-name [DefaultConnection]


        public void PostUser(UserModel val)
        {
            SqlDataAccess sql = new SqlDataAccess();
            sql.SaveData<UserModel>("dbo.spUserInsert", val, "ITEKISI_DB");
        }

    }
}

using ITEKISI_DATA_LIBRARY.Internal.DataAcces;
using ITEKISI_DATA_LIBRARY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEKISI_DATA_LIBRARY.DataAccess
{
   public class ProfileData
    {
        public List<ProfileModel> GetProfileById(string Id)
        {
            var p = new { Id = Id };

            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<ProfileModel, dynamic>("dbo.spUserInfor", p, "ITEKISI_DB");
            return output;
        }
    }
}

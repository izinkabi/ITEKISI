using System;
using System.Collections.Generic;
using ITEKISI_DATA_LIBRARY.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEKISI_DATA_LIBRARY.Internal.DataAcces;

namespace ITEKISI_DATA_LIBRARY.DataAccess
{
   public class TaxiData
    {

        public List<TaxiModel> GetTaxiById(int Id)
        {
            var p = new { Id = Id };
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<TaxiModel, dynamic>("dbo.spTaxiLookUp", p, "ITEKISI_DB");
            return output;
        }
        public List<TaxiModel> GetTaxis()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<TaxiModel, dynamic>("dbo.spTaxisLookUP", new { }, "ITEKISI_DB");
            return output;
        }

        public void PostTaxiInfo(TaxiModel val)
        {
            SqlDataAccess sql = new SqlDataAccess();
            sql.SaveData<TaxiModel>("dbo.spTaxiInsert", val, "ITEKISI_DB");
        }

        public int DeleteTaxiInfor(DeleteTaxiBindingModel model)
        {
            SqlDataAccess sql = new SqlDataAccess();
            int rowsAffected = sql.SaveData("dbo.spTaxiRemove", model, "ITEKISI_DB");
            return rowsAffected;
        }

    }
}

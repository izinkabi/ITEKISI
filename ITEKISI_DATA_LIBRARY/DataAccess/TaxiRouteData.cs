using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEKISI_DATA_LIBRARY.Internal.DataAcces;
using ITEKISI_DATA_LIBRARY.Models;
namespace ITEKISI_DATA_LIBRARY.DataAccess
{
    public class TaxiRouteData
    {
        public List<TaxiRouteModel> GetTaxiRouteById(int Id)
        {
            var p = new { Id = Id };
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<TaxiRankModel, dynamic>("dbo.spTaxiRouteLookUp", p, "ITEKISI_DB");
            return output;
        }
        public List<TaxiRouteModel> GetAllTaxiRoute()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<TaxiRouteModel, dynamic>("dbo.spTaxiRoutesLookUP", new { }, "ITEKISI_DB");
            return output;
        }

        public void PostRouteData(TaxiRouteModel val)
        {
            SqlDataAccess sql = new SqlDataAccess();
            sql.SaveData<TaxiRouteModel>("dbo.spTaxiRouteInsert", val, "ITEKISI_DB");
        }
        public int RemoveTaxiRoute(int id)
        {

            SqlDataAccess sqlData = new SqlDataAccess();
            int rowsaffected = sqlData.SaveData("dbo.spTaxiRouteRemove", new { Id = id }, "ITEKISI_DB");
            return rowsaffected;

        }
    }
}
}

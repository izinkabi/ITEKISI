using ITEKISI_DATA_LIBRARY.Internal.DataAcces;
using ITEKISI_DATA_LIBRARY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEKISI_DATA_LIBRARY.DataAccess
{
    public class TaxiRankData
    {
        public List<TaxiRankModel> GetTaxiRankById(int Id)
        {
            var p = new { Id = Id };
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<TaxiRankModel, dynamic>("dbo.spTaxiRankLookUp", p, "ITEKISI_DB");
            return output;
        }
        public List<TaxiRankModel> GetAllTaxiRank()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<TaxiRankModel, dynamic>("dbo.spTaxiRanksLookUP", new { }, "ITEKISI_DB");
            return output;
        }

        public void PostRankData(TaxiRankModel val)
        {
            SqlDataAccess sql = new SqlDataAccess();
            sql.SaveData<TaxiRankModel>("dbo.spTaxiRankInsert", val, "ITEKISI_DB");
        }
        public int RemoveTaxiRank(int id)
        {
           
            SqlDataAccess sqlData = new SqlDataAccess();
            int rowsaffected = sqlData.SaveData("dbo.spTaxiRankRemove",new { Id=id}, "ITEKISI_DB");
            return rowsaffected;
            
        }
    }
}

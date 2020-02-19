﻿using ITEKISI_DATA_LIBRARY.Internal.DataAcces;
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
            var output = sql.LoadData<TaxiRankModel, dynamic>("dbo.spTaxiRanksLookUp", new { }, "ITEKISI_DB");
            return output;
        }
    }
}
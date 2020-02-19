using ITEKISI_API.Models;
using ITEKISI_DATA_LIBRARY.DataAccess;
using ITEKISI_DATA_LIBRARY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITEKISI_API.Controllers
{
    public class TaxiRankController : ApiController
    {
             // GET: api/TaxiRank/5
        public TaxiRankModel GetById(int id)
        {
            TaxiRankData taxiRank = new TaxiRankData();
            return taxiRank.GetTaxiRankById(id).First();
        }
        public List<TaxiRankModel> GetAll()
        {
            TaxiRankData taxiRanks = new TaxiRankData();
            return taxiRanks.GetAllTaxiRank().ToList();
        }
    }
}

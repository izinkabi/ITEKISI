using ITEKISI_DATA_LIBRARY.DataAccess;
using ITEKISI_DATA_LIBRARY.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ITEKISI_API.Controllers
{

    
    [RoutePrefix("api/TaxiRanks")]
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
        // POST: api/TaxiRank/5
        [HttpPost]
        public void PostTaxiRank(TaxiRankModel val)
        {
            TaxiRankData taxiRank = new TaxiRankData();
            taxiRank.PostRankData(val);


        }

        [HttpDelete]
        public int DeleteTaxiRank(int id)
        {
            TaxiRankData rankData = new TaxiRankData();

            int rowsaffected = rankData.RemoveTaxiRank(id);
            return rowsaffected;
        }
    }
}

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
    [Authorize]
    public class TaxiRouteController : ApiController
    {
        [HttpGet]
        public TaxiRouteModel GetTaxiRouteById (int Id)
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            return taxiRoute.GetTaxiRouteById(Id).FirstOrDefault();
        }
        [HttpGet]
        public List<TaxiRouteModel> GetAllTaxiotes()
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            return taxiRoute.GetAllTaxiRoute().ToList();
        }
        [HttpPost]
        public void PostTaxiRoute(TaxiRouteModel val)
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            taxiRoute.PostTaxiRouteData(val);
        }
        [HttpDelete]
        public int DeleteTaxiRoute(int Id)
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            int rowsAffected = taxiRoute.RemoveTaxioute(Id);
            return rowsAffected;
  
        }

    }
}
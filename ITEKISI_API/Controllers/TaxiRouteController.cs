using ITEKISI_DATA_LIBRARY.DataAccess;
using ITEKISI_DATA_LIBRARY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ITEKISI_API.Controllers
{
    [RoutePrefix("api/TaxiRoute")]
    public class TaxiRouteController : ApiController
    {
        // GET: api/Taxi
        public TaxiRouteModel GetTaxiRouteById(int id)
        {

            try
            {
                TaxiRouteData taxiRoute = new TaxiRouteData();
                return taxiRoute.GetTaxiRouteById(id).First();

            }
            catch (Exception ex)
            {

                throw new ArgumentException("We cannot find the Route you are looking for", ex);

            }
            finally
            {


                TaxiRouteData taxiRoute = new TaxiRouteData();
                taxiRoute.GetTaxiRouteById(id).First();
            }

        }

        // GET: api/Taxis/5
        public List<TaxiRouteModel> GetTaxiRoutes()
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            return taxiRoute.GetAllTaxiRoute().ToList();
        }

        [HttpPost]

        public void PostTaxiRoute(TaxiRouteModel val)
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            taxiRoute.PostRouteData(val);
        }

        public int DeleteTaxiRoute(DeleteTaxiRouteBindingModel model)
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            int rowsAfected = taxiRoute.RemoveTaxiRoute(model);
            return rowsAfected;
        }



    }
}
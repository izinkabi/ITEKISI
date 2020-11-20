﻿using ITEKISI_API.Models;
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
    public class TaxiRouteController : Controller
    {
        // GET: api/Taxi
        public TaxiRouteModel GetTaxiRouteById(int id)
        {

            try
            {
                TaxiRouteData taxiRoute = new TaxiData();
                return taxiRoute.GetTaxiRouteById(id).First();

            }
            catch (Exception ex)
            {

                throw new ArgumentException("We cannot find the Route you are looking for", ex);

            }
            finally
            {
                //DO SOMETHING HERE LATEr


            }

        }

        // GET: api/Taxis/5
        public List<TaxiRouteModel> GetTaxiRoutes()
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            return taxiRoute.GetTaxiRoutes().ToList();
        }
        [HttpPost]
        public void PostTaxiRoute(TaxiRouteModel val)
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            taxiRoute.PostTaxiRouteInfo(val);
        }

        public int DeleteTaxiRoute(DeleteTaxiRouteBindingModel model)
        {
            TaxiRouteData taxiRoute = new TaxiRouteData();
            int rowsAfected = taxiRoute.DeleteTaxiRouteInfor(model);
            return rowsAfected;
        }
  
        }

    }
}
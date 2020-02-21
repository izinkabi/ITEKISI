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

    public class TaxisController : ApiController
    {
        // GET: api/Taxis
        public TaxiModel GetTaxiById(int id)
        {
            TaxiData taxi = new TaxiData();
            return taxi.GetTaxiById(id).First();
        }

        // GET: api/Taxis/5
        public List<TaxiModel> GetTaxis()
        {
            TaxiData taxi = new TaxiData();
            return taxi.GetTaxis().ToList();
        }

       
    }
}

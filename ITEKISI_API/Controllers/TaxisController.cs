using ITEKISI_DATA_LIBRARY.DataAccess;
using ITEKISI_DATA_LIBRARY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ITEKISI_API.Controllers
{
    

    public class TaxisController : ApiController
    {
        // GET: api/Taxi
        public TaxiModel GetTaxiById(int id)
        {

            try
            {
                TaxiData taxi = new TaxiData();
                return taxi.GetTaxiById(id).First();

            }
            catch (Exception ex)
            {

                throw new ArgumentException("We cannot find the taxi you are looking for", ex);

            }
            finally
            {
                //DO SOMETHING HERE LATEr


            }

        }

        // GET: api/Taxis/5
        public List<TaxiModel> GetTaxis()
        {
            TaxiData taxi = new TaxiData();
            return taxi.GetTaxis().ToList();
        }
        public void PostTaxi(InsertBinding val)
        {
            TaxiData taxi = new TaxiData();
            taxi.PostTaxiInfo(val);
        }

        public int DeleteTaxi(ITEKISI_DATA_LIBRARY.Models.DeleteTaxiBindingModel model)
        {
            TaxiData taxi = new TaxiData();
            int rowsAfected = taxi.DeleteTaxiInfor(model);
            return rowsAfected;
        }

    }
}

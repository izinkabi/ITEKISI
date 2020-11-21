namespace ITEKISI_API.Models
{
    public class TaxiRoute
    {
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _from;

        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        private string _to;

        public string To
        {
            get { return _to; }
            set { _to = value; }
        }


    }
    public class DeleteTaxiRouteBindingModel
    {
        public int Id { get; set; }
    }
}
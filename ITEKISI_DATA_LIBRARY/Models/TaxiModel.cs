namespace ITEKISI_DATA_LIBRARY.Models
{
    public class TaxiModel
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
    }

    public class InsertBinding
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
    }
    public class DeleteTaxiBindingModel
    {
        [Required]
        public int Id { get; set; }
    }
}

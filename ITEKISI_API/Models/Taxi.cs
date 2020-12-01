using System.ComponentModel.DataAnnotations;

namespace ITEKISI_API.Models
{
    public class Taxi
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Price { get; set; }
        public string Location { get; set; }

    }
    public class DeleteTaxiBindingModel
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
    }
}
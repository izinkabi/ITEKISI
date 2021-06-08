using System.ComponentModel.DataAnnotations;


namespace ITEKISI_API.Models
{
    public class ProfileModel
    {
        
       
        public string UserId { get; set; }
        public string Name { get; set; }
        [Required]
        [Display(Name = "IdNumber")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "IdNumber")]
        public string IdNumber { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "AccessId")]
        public int AccessId { get; set; }
    }

    public class ProfileBindingModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        [Required]
        [Display(Name = "IdNumber")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "IdNumber")]
        public string IdNumber { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "AccessId")]
        public int AccessId { get; set; }
    }


    public class DeleteProfileBindingModel
    {
        [Required]
        public int Id { get; set; }
    }
}

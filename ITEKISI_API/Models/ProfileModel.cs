using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace ITEKISI_API.Models
{
    public class ProfileModel
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
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
        [Required]
        [Display(Name = "UserId")]
        public string UserId { get; set; }

    }
    public class DeleteProfileBindingModel
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }
    }
}

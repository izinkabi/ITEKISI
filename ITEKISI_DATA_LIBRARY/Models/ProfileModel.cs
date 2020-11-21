namespace ITEKISI_DATA_LIBRARY.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int AccessId { get; set; }
    }

    public class DeleteProfileBindingModel
    {
        [Required]
        public int Id { get; set; }
    }
}

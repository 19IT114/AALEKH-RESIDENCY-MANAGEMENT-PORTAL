using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AALEKH_SOCIETY_COOP
{
    public class Residents
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "House No.")]
        public string Block_no { get; set; } = "x/x";
        [Display(Name = "Owner")]
        [Required(ErrorMessage = "Owner Name cannot be Empty..!")]
        public string Owner_name { get; set; }
        [Display(Name = "Contact No.")]
        [Required(ErrorMessage = "Contact Number cannot be Empty..!")]
        public string Mobile_no { get; set; }
        [Display(Name = "Is a Street Member?")]
        public bool Is_a_Streetmember { get; set; } = false;
        [Display(Name = "Rentals")]
        public bool has_Rentals { get; set; } = false;

        [NotMapped]
        
        [Display(Name ="House Number Initials")]
        public string? Initals { get; set; }
        [NotMapped]
       
        [Display(Name = "House Number")]
        public string? Number { get; set; }

    }
}

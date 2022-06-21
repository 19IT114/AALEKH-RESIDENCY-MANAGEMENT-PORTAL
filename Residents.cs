using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AALEKH_SOCIETY_COOP
{
    public class Residents
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        [Display(Name = "House No.")]
        [Required(ErrorMessage = "House Number cannot be Empty..!")]
        public string Block_no { get; set; }
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
        [Required(ErrorMessage ="It cannot be Empty")]
        [Display(Name ="House Number Initials")]
        public string Initals { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "It cannot be Empty")]
        [Display(Name = "House Number")]
        public int Number { get; set; }

    }
}

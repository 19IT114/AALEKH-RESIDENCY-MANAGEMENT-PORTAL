using System.ComponentModel.DataAnnotations;

namespace AALEKH_SOCIETY_COOP
{
    public class FixedCharges
    {
        [Key]
       [Display(Name ="ID")]
        public int id { get; set;}
        [Display(Name = "Type")]
        public string? Type { get; set; }
        [Display(Name = "Fixed-Charges")]
        public int? FixedCharge { get; set; } = 0;
        [Display(Name = "Last-Updated On")]
        public DateTime? Updatedon { get; set; } 
        [Display(Name = "Status")]
        public bool Status { get; set; } = false;
    }
}

using System.ComponentModel.DataAnnotations;

namespace BasicVersion1.Models
{
    public class COMPANY
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "CompanyName")]
        public string? CompanyName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "CompanyAddress")]
        public string? CompanyAddress { get; set; }


        //---------------- ForeignKey for POSITION Modles -----------------------//
        // public ICollection<DEPARTMENT> DEPARTMENT { get; set; }
    }
}

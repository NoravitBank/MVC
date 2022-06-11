using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicVersion1.Models
{
    public class EMPLOYEE
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "EmployeeNamme")]
        public string? EmployeeName { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "EmployeeAddress")]
        public string? EmployeeAddress { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "EmployeeTel")]
        public string? EmployeeTel { get; set; }

        //---------------- ForeignKey Entity -----------------------//

        //public POSITION? Position_Id { get; set; }


    }
}

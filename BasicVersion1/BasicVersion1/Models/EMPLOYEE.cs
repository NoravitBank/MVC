using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicVersion1.Models
{
    [Table("Employee")]
    public class EMPLOYEE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"EmployeeId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        public int EmployeeId { get; set; }


        [Column(@"EmployeeName", Order = 2, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? EmployeeName { get; set; }

        [Column(@"EmployeeAddress", Order = 3, TypeName = "varchar(200)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? EmployeeAddress { get; set; }

        [Column(@"EmployeeTel", Order = 4, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? EmployeeTel { get; set; }

        //---------------- ForeignKey Entity -----------------------//
        [Column(@"PositionId", Order = 5, TypeName = "int")]
        [Required]
        public int PositionId { get; set; }

        [Column(@"DepartmentId", Order = 6, TypeName = "int")]
        [Required]
        public int DepartmentId { get; set; }

        [Column(@"CompanyId", Order = 7, TypeName = "int")]
        [Required]
        public int CompanyId { get; set; }

        public virtual POSITION Position { get; set; }
        public virtual DEPARTMENT Department { get; set; }
        public virtual COMPANY Company { get; set; }

        public EMPLOYEE()
        {

        }
    }
}
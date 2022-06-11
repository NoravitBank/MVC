using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicVersion1.Models
{
    [Table("Employee")]
    public class EMPLOYEE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"EmployeeId", Order = 1 , TypeName = "int")]
        [Required]
        [Key]   
        public int EmployeeId { get; set; }


        [Column(@"EmployeeName", Order = 2, TypeName = "varchar(50)")]
        [Required]
        [StringLength(30)]        
        public string? EmployeeName { get; set; }


        [Column(@"EmployeeAddress", Order = 3, TypeName = "varchar(50)")]
        [StringLength(100)]
        [MaxLength(100)]
        public string? EmployeeAddress { get; set; }


        [Column(@"EmployeeTel", Order = 4, TypeName = "varchar(50)")]
        [StringLength(10)]
        public string? EmployeeTel { get; set; }

        //---------------- ForeignKey Entity -----------------------//

        [Required]
        public int PositionId { get; set; }

        [Required]
        public int DepartmentId { get; set; }


        public virtual POSITION Position { get; set; }
        public virtual DEPARTMENT Department { get; set; }

      




    }
}

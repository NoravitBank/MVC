using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicVersion1.Models
{
    [Table("Department")]
    public class DEPARTMENT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"DepartmentId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        public int DepartmentId { get; set; }

        [Column(@"DepartmentName", Order = 2, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string DepartmentName { get; set; }

        [Column(@"DepartmentAddress", Order = 3, TypeName = "varchar(200)")]        
        [MaxLength(200)]
        [StringLength(200)]
        public string DepartmentAddress { get; set; }

        //---------------- PrimaryKey From Another Models -----------------------//       
        //   public COMPANY Company_Id { get; set; }



        //---------------- ForeignKey for POSITION Modles -----------------------//
        //    public ICollection<POSITION> POSITION { get; set; }

        public virtual ICollection<EMPLOYEE> Employees { get; set; }

        public DEPARTMENT()
        {
            this.Employees = new List<EMPLOYEE>();
        }
    }
}

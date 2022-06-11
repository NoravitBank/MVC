using System.ComponentModel.DataAnnotations;

namespace BasicVersion1.Models
{
    public class DEPARTMENT
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "DepartmentName")]
        public string DepartmentName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "DepartmentAddress")]
        public string DepartmentAddress { get; set; }

        //---------------- PrimaryKey From Another Models -----------------------//       
     //   public COMPANY Company_Id { get; set; }



        //---------------- ForeignKey for POSITION Modles -----------------------//
    //    public ICollection<POSITION> POSITION { get; set; }
    }
}

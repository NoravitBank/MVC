using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicVersion1.Models
{
    [Table("Position")]
    public class POSITION
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"PositionId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        public int PositionId { get; set; }

        [Column(@"PositionName", Order = 2, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string PositionName { get; set; }

        [Column(@"PositionDescription", Order = 3, TypeName = "varchar(50)")]
        [MaxLength(50)]
        [StringLength(50)]
        public string PositionDescription { get; set; }


        //---------------- PrimaryKey From Another Models -----------------------//

        //   public DEPARTMENT Department_Id { get; set; }

        //---------------- ForeignKey for EMPLOYEE Modles -----------------------//
        //   public ICollection<EMPLOYEE> Employee { get; set; }

        public virtual ICollection<EMPLOYEE> Employees {get; set;}

        public POSITION()
        {
            this.Employees = new List<EMPLOYEE>();
        }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicVersion1.Models
{
    [Table("COMPANY")]
    public class COMPANY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"CompanyId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        public int CompanyId { get; set; }

        [Column(@"CompanyName", Order = 2, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? CompanyName { get; set; }

        [Column(@"CompanyAddress", Order = 3, TypeName = "varchar(200)")]
        [MaxLength(200)]
        [StringLength(200)]
        public string? CompanyAddress { get; set; }


        //---------------- ForeignKey for POSITION Modles -----------------------//
        // public ICollection<DEPARTMENT> DEPARTMENT { get; set; }
        public virtual ICollection<EMPLOYEE> Employees { get; set; }

        public COMPANY()
        {
            this.Employees = new List<EMPLOYEE>();
        }
    }
}

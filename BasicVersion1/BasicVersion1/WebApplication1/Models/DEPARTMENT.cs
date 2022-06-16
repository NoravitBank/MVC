using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("DEPARTMENT")]
    public class DEPARTMENT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"DEPARTMENT_CODE", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        public int DEPARTMENT_CODE { get; set; } = 1;

        [Column(@"DEPARTMENT_NAME_THA", Order = 2, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? DEPARTMENT_NAME_THA { get; set; }

        [Column(@"DEPARTMENT_NAME_ENG", Order = 3, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? DEPARTMENT_NAME_ENG { get; set; }

         public List<EMPLOYEE> EMPLOYEEs { get; set; }

    }
}

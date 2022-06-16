using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    [Table("POSITION")]
    public class POSITION
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"POSITION_CODE", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        public int POSITION_CODE { get; set; }

        [Column(@"POSITION_NAME_THA", Order = 2, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? POSITION_NAME_THA { get; set; }

        [Column(@"POSITION_NAME_ENG", Order = 3, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? POSITION_NAME_ENG { get; set; }
        [JsonIgnore]
        public List<EMPLOYEE> EMPLOYEEs { get; set; }
    }
}

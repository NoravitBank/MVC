using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DTO
{
    public class CreateEmployeeDTO
    {
        
        [Column(@"FIRST_NAME_THA", Order = 2, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? FIRST_NAME_THA { get; set; }

        [Column(@"LAST_NAME_THA", Order = 3, TypeName = "varchar(100)")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        public string? LAST_NAME_THA { get; set; }

        [Column(@"FIRST_NAME_ENG", Order = 4, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? FIRST_NAME_ENG { get; set; }

        [Column(@"LAST_NAME_ENG", Order = 5, TypeName = "varchar(100)")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        public string? LAST_NAME_ENG { get; set; }

        [Column(@"NICKNAME", Order = 6, TypeName = "varchar(20)")]
        [MaxLength(20)]
        [StringLength(20)]
        public string? NICKNAME { get; set; }

        [Column(@"GENDER", Order = 7, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? GENDER { get; set; }

        [Column(@"BIRTH_DATE", Order = 8, TypeName = "DATETIME")]
        [Required]
        public DateTime BIRTH_DATE { get; set; }


        [Column(@"NATIONALITY_ID", Order = 9, TypeName = "varchar(13)")]
        [Required]
        [MaxLength(13)]
        [StringLength(13)]
        public string? NATIONALITY_ID { get; set; }

        [Column(@"RACE_ID", Order = 10, TypeName = "varchar(8)")]
        [Required]
        [MaxLength(8)]
        [StringLength(8)]
        public string? RACE_ID { get; set; }

        [Column(@"RELIGION", Order = 11, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? RELIGION { get; set; }

        [Column(@"BLOOD_TYPE", Order = 12, TypeName = "varchar(10)")]
        [MaxLength(10)]
        [StringLength(10)]
        public string? BLOOD_TYPE { get; set; }

        [Column(@"PHONE_EMPLOYEE", Order = 13, TypeName = "varchar(10)")]
        [Required]
        [MaxLength(10)]
        [StringLength(10)]
        public string PHONE_EMPLOYEE { get; set; }

        [Column(@"EMAIL", Order = 14, TypeName = "varchar(50)")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        public string? EMAIL { get; set; }

        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
    }
}

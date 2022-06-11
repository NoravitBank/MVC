using System.ComponentModel.DataAnnotations;

namespace BasicVersion1.Models
{
    public class POSITION
    {
        [Key]
        public int PositionId { get; set; }

        [Required]        
        [StringLength(20)]
        [Display(Name = "PositionName")]
        public string PositionName { get; set; }

        [StringLength(20)]
        [Display(Name = "PositionDescription")]
        public string PositionDescription { get; set; }


        //---------------- PrimaryKey From Another Models -----------------------//
        
     //   public DEPARTMENT Department_Id { get; set; }

        //---------------- ForeignKey for EMPLOYEE Modles -----------------------//
     //   public ICollection<EMPLOYEE> Employee { get; set; }

    }
}

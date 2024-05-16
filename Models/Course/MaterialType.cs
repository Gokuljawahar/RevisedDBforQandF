using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproachForDB.Models.Course
{
    public class MaterialType
    {
        [Key]
        public Guid material_type_id { get; set; }
        [Required]
        [MaxLength(20)]
        public string type { get; set; }
    }
}

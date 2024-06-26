using System.ComponentModel.DataAnnotations;
using CodeFirstApproachForDB.Models.Course;

namespace LMS
{
    public class Material
    {
        [Key]
        public Guid material_id { get; set; }
        public Topic topic { get; set; }
        public MaterialType material_type { get; set; }

        [Required]
        [MaxLength(50)]
        public string name { get; set; }

        [Required]
        public string file_path { get; set; }

        [Required]
        public decimal duration { get; set; }

        [Required]
        public bool is_active { get; set; }

        [Required]
        public bool is_available { get; set; }

        [Required]
        public string created_by { get; set; }

        [Required]
        public DateTime created_at { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_at { get; set; }

        public ICollection<LearnerProgress> users { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class Category
    {
        [Key] // Data Annotations
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        // [StringLength(12, ErrorMessage = "The {0} value cannot exceed 12 characters. ")]
        public string Name { get; set; }
        // [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order solo deberia estar entre 1 a 100!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
    
}
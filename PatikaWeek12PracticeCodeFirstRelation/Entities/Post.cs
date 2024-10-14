using System.ComponentModel.DataAnnotations;

namespace PatikaWeek12PracticeCodeFirstRelation.Entities
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(500)]
        public string Content { get; set; }
        
        // Foreign key
        public int UserId { get; set; }
        
        // Navigation property
        public User User { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace PatikaWeek12PracticeCodeFirstRelation.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        // Relational Property

        public List<Post> Posts { get; set; }
    }
}

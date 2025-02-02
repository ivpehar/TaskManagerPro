using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerPro.Data
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Naslov je obavezan.")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Opis je obavezan.")]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? DueDate { get; set; } = null;

        [Required]
        public string Priority { get; set; } = "Srednji"; // Nizak, Srednji, Visok

        public string Tags { get; set; } = string.Empty; // Razni tagovi npr. "Posao, Važno"

        [ForeignKey("UserId")]
        public string? UserId { get; set; }

        public User? User { get; set; }

    }
}

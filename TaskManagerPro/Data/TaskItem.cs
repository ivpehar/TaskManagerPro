using System.ComponentModel.DataAnnotations;

namespace TaskManagerPro.Data
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naslov je obavezan.")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Opis je obavezan.")]
        public required string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? DueDate { get; set; }

        public bool IsCompleted { get; set; } = false;

        [Required(ErrorMessage = "UserId je obavezan.")]
        public required string UserId { get; set; }

        public User? User { get; set; }
    }
}

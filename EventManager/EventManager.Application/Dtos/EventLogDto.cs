using System.ComponentModel.DataAnnotations;

namespace EventManager.Application.Dtos
{
    public class EventLogDto
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public int EventTypeId { get; set; }
    }
}

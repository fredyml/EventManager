using System.ComponentModel.DataAnnotations;

namespace EventManager.Application.Dtos
{
    public class EventSearchDto
    {
        [Range(1, int.MaxValue, ErrorMessage = "EventTypeId must be greater than 0")]
        public int EventTypeId { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}

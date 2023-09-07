namespace EventManager.Domain.Entities
{
    public class EventLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string EventType { get; set; } 
    }

}
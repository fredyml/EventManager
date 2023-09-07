namespace EventManager.Domain.Entities
{
    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<EventLog> EventLogs { get; set; }
    }

}

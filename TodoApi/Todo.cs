using System.Text.Json.Serialization;

namespace TodoApi
{
    public enum Status
    {
        Complete,
        InProgress,
        OnHold,
        Pending
    }
    public class Todo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public int Priority { get; set; }
    }
}

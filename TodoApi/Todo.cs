using System.Text.Json.Serialization;

namespace TodoApi
{
    public enum Status
    {
        Complete = 0,
        InProgress = 1,
        OnHold = 2,
        Pending = 3
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

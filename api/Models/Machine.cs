using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api.Models
{
    public class Machine
    {
        [Key]
        public required string Id { get; init; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MachineState State { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? CurrentJobId { get; set; }
    }
}
using System.Text.Json.Serialization;

namespace deneme2.Models
{
    public enum RpgClass
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        Knight = 1,
        Mage = 2,
        Cleric = 3,
    }
}
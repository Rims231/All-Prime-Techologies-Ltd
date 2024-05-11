using System.Text.Json.Serialization;

namespace All_Prime_Techologies_Ltd.Models
{
    public enum Gender
    {

        [JsonConverter(typeof(JsonStringEnumConverter))]


        Male = 1,
        Female = 2,
    }
}

using System.Text.Json.Serialization;

namespace _24_RickyAndMortyApi_Razor_Pages.DTO
{
    public class RickAndMortyCharacterDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name  { get; set; }
        [JsonPropertyName("status")]
        public string Status  { get; set; }
        [JsonPropertyName("species")]
        public string Species  { get; set; }
        [JsonPropertyName("image")]
        public string Image  { get; set; }
    }
}

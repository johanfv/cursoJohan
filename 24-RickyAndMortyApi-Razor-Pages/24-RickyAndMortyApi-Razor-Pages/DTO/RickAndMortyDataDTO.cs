using System.Text.Json.Serialization;

namespace _24_RickyAndMortyApi_Razor_Pages.DTO
{
    public class RickAndMortyDataDTO
    {
        [JsonPropertyName("result")]
        public List<RickAndMortyCharacterDTO> Characters { get; set; }
    }
}

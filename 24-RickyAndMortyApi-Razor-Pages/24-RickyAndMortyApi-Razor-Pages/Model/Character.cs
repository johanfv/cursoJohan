using System.Text.Json.Serialization;

namespace _24_RickyAndMortyApi_Razor_Pages.Model
{
    public class Character
    {
        
        public int Id { get; set; }
       
        public string Name { get; set; }
      
        public string Status { get; set; }
       
        public string Species { get; set; }
      
        public string Image { get; set; }
    }
}

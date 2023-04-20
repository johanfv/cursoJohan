using System.ComponentModel.DataAnnotations;

namespace _17_Validation_Razor_Pages.Model
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo es requerido {0}")]
        [StringLength(50,MinimumLength = 3, ErrorMessage ="{0} debe ser estar entre {1} y {2}")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Verifique el formato")]
        public string Name { get; set; }
        [Required(ErrorMessage ="El campo es requerido")]
        [Range(18,200,ErrorMessage ="Debe ser mayor de edad")]
        public int? Age { get; set; }
    }
}

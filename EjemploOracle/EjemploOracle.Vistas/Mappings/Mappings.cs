using EjemploOracle.vistas.Models;

namespace EjemploOracle.vistas.Mappings
{
    public static partial class Mapper
    {
        public static CategoriaDTO ToDTO(this Categorium model)  // Convierte de ModelContext a DTO
        {
            return new CategoriaDTO()
            {
                Id = model.Id,
                Nombre = model.Nombre
            };
        }
    }

    public static partial class Mapper
    {
        public static Categorium ToDatabase(this CategoriaDTO dto)  // Convierte de DTO a ModelContext
        {
            return new Categorium()
            {
                Id = dto.Id,
                Nombre = dto.Nombre
            };
        }
    }
}
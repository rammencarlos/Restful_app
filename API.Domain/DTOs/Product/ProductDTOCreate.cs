using System.ComponentModel.DataAnnotations;

namespace API.Domain.DTOs.Product
{

    /// <summary>
    /// Seamos especificos, aunque tome un poco mas crear cada dto 
    /// es mejor dejarlo preparado para crecer
    /// </summary>
    public class ProductDTOCreate
    {
        [Required(ErrorMessage = "El campo SKU es requerido")]
        [StringLength(64, ErrorMessage = "SKU debe tener un maximo de {1} caracteres")]
        public string SKU { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(64, ErrorMessage = "Nombre debe tener un maximo de {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Descripción es requerido")]
        [StringLength(128, ErrorMessage = "Descripción debe tener un maximo de {1} caracteres")]
        public string Description { get; set; }

    }
}

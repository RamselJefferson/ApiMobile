using System.ComponentModel.DataAnnotations;

namespace ApiMobile.Models
{
    public class VwItemsCategoria
    {

        [Key]
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? Categoria { get; set; }
        public string? Imagen { get; set; }

    }
}

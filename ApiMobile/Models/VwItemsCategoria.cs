using System.ComponentModel.DataAnnotations;

namespace ApiMobile.Models
{
    public class VwItemsCategoria
    {

        [Key]
        public int ItemId { get; set; }
        public string? ItemDescripcion { get; set; }
        public decimal Precio { get; set; }
        public string? CatDescripcion { get; set; }
        public string? Imagen { get; set; }

    }
}

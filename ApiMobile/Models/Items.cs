using System.ComponentModel.DataAnnotations;

namespace ApiMobile.Models
{
    public class Items
    {

        [Key]
        public int ItemId { get; set; }
        public string? ItemDescripcion { get; set; }
        public int CatId { get; set; }
        public decimal Precio { get; set; }
        public string? Imagen { get; set; }
    
    }
}

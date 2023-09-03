using System.ComponentModel.DataAnnotations;

namespace ApiMobile.Models
{
    public class Items
    {

        [Key]
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int CatId { get; set; }
        public decimal Precio { get; set; }
        public string? Imagen { get; set; }
    
    }
}

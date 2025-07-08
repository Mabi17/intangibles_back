namespace Intangibles.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }

        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public int IdCatalogo { get; set; }
        public int IdCategoria { get; set; }
        public string? img { get; set; }



    }
}

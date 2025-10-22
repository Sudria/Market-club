using System.Drawing;

namespace Market_Club.Forms.CrudProduct
{
    internal class Producto
    {
        public string Nombre { get; internal set; }
        public string Descripcion { get; internal set; }
        public string Categoria { get; internal set; }
        public int Stock { get; internal set; }
        public int StockMinimo { get; internal set; }
        public Image Imagen { get; internal set; }
    }
}
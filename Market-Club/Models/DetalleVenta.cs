using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Club.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }            // Autogenerado
        public int VentaId { get; set; }       // FK a Venta
        public int ProductoId { get; set; }    // FK a Producto
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal
        {
            get { return Cantidad * PrecioUnitario; }
        }
    }
}


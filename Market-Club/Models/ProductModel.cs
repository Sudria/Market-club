using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Club.Models
{
    public class ProductModel 
    {
    public int Id { get; set; }  // Autogenerado en BD
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public int StockMinimo { get; set; }
    public string Categoria { get; set; }
    public string SubCategoria { get; set; } // Si manejás subcategorías
    public string UnidadMedida { get; set; }
    public string Proveedor { get; set; }
    public bool Activo { get; set; }   // true = disponible
    public string ImagenRuta { get; set; } // Guarda la ruta de la imagen
   }
}

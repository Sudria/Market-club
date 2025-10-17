using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Club.Models
{
    public class ProductModel 
    {
    public int CodProducto { get; set; }  
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
    public int CantidadMinima { get; set; }
    public string Categoria { get; set; }
    public bool Activo { get; set; }  
    public string ImagenRuta { get; set; }
   }
}

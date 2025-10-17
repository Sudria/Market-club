using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Club.Models
{
    public class Venta
    {
        public int Id { get; set; }                // Autogenerado
        public string CuitCliente { get; set; }    // Relación con Cliente
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public List<DetalleVenta> Detalles { get; set; } // Relación 1 a muchos

        public Venta()
        {
            Detalles = new List<DetalleVenta>();
        }
    }
}


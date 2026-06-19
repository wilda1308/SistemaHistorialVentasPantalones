using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHistorialVentasProyectoFinal.Models
{
    class Ventas
    {
        public int Codigo { get; set; }
        public string Cliente { get; set; }
        public string Talla { get; set; }
        public string Tela { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Genero { get; set; }

        public decimal Total => Precio * Cantidad; 
    }
}

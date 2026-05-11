using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitYGitHub
{
    public static class DatosVentas
    {
        public static List<VentaInfo> ventas = new List<VentaInfo>();
    }

    public class ProductoVenta
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }

    public class VentaInfo
    {
        public int Codigo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }

        public List<ProductoVenta> Productos { get; set; }
            = new List<ProductoVenta>();

        public double Total { get; set; }
    }
}

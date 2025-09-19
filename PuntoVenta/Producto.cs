using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string CodigoBarras { get; set; }
        public string Clave { get; set; }
        public string Codigo { get; set; }
    }

}

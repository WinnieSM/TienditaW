using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Rel_Ventas
    {
        public int iIdVenta { get; set; }
        public int iIdProducto { get; set; }
        public int iIdCliente { get; set; }
        public float iTotal { get; set; }
        public bool lPagado { get; set; }
        public DateTime dtVenta { get; set; }
        public DateTime dtModificacion { get; set; }
        public bool lActivo { get; set; }
    }
}

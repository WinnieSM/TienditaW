using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class Productos
    {
        public int iIdProducto { get; set; }
        public string cDescripcion { get; set; }
        public float iPrecio { get; set; }
        public float iCosto { get; set; }
        public int iCantidad { get; set; }
        public bool lActivo { get; set; }
        public int iIdProveedor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Clientes
    {
        public int iIdCliente { get; set; }
        public string cNombres { get; set; }
        public string cApellido { get; set; }
        public bool lDeuda { get; set; }
        public string cCorreo { get; set; }
        public bool lActivo { get; set; }
        public DateTime dtCreacion { get; set; }
        public DateTime dtModificacion { get; set; }

    }
}

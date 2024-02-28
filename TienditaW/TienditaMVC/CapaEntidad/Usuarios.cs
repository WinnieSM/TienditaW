using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public  class Usuarios
    {
        public int iIdUsuario { get; set; }
        public string cNombres { get; set; }
        public string cApellidos{ get; set; }
        public string cCorreo { get; set; }
        public string cUsuario { get; set; }
        public string cPassword { get; set; }
        public bool lReestablecer { get; set; }
        public bool lActivo { get; set; }
        public DateTime dtCreacion { get; set; }
        public DateTime dtModificacion { get; set; }

    }
}

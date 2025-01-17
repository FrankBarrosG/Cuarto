using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion.Datos
{
    public class dato_clase_usuario
    {
            //Usuario IdUsuario NombreUsuario Contrasenia  CreateAt ModifiedAt
            public int id_usuario { get; set; }
            public string NombreUsuario { get; set; }
            public string Contrasenia { get; set; }
            public DateTime CreateAt { get; set; }
            public DateTime ModifiedAt { get; set; }
     
    }
}

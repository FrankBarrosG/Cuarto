using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion.Datos
{
    public class dato_clase_personal
    {
        public int id_personal { get; set; }
        public string cedula { get; set; }
        public string nombres { get; set; }
        public string cargo { get; set; }
        public decimal sueldo { get; set; }
        public int id_pais { get; set; }
        public string detalle { get; set; } = null;
    }
}

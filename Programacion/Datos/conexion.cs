using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Programacion.Datos
{
    public class conexion
    {
        private readonly string conexion_s = 
            "Data Source= DESKTOP-26SQUV9\\SQLEXPRESS;Initial Catalog=sistema_cuarto;Integrated Security=True";
        public SqlConnection obtener_conexion()
        {
            return new SqlConnection(conexion_s);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Programacion.Datos;
using System.Data;
using System.Data.SqlClient;

namespace Programacion.Logica
{
    public class cls_pais
    {
        private readonly conexion cn = new conexion();

        public List<dato_clase_pais> leer()
        {
            var lista_pais = new List<dato_clase_pais>();
            using (var varconexion= cn.obtener_conexion())
            {
                string cadena = "select * from paises";
                using (var comando = new SqlCommand(cadena, varconexion))
                {
                    varconexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            
                            lista_pais.Add(new dato_clase_pais()
                            {
                                id_pais = Convert.ToInt32(lector["id_pais"]),
                                detalle = lector["detalle"].ToString()
                            });
                        }
                    }
                }
            }
            return lista_pais;
        }
        
    }
}

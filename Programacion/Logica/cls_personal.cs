using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Programacion.Datos;
using System.Windows.Markup;
using System.Reflection.Metadata.Ecma335;
using Programacion.Presentacion;
namespace Programacion.Logica
{

    public class cls_personal
    {
        private readonly conexion cn = new conexion();
        //private readonly Datos.conexion cn = new Datos.conexion();

        // procedimientos

        //insertar
        public string Insertar(dato_clase_personal personal)
        {
            using (var conexion = cn.obtener_conexion())
            {
                string cadena = "insert into Personales(cedula, nombres, cargo, sueldo, id_pais)values('" +
                    personal.cedula + "','" +
                    personal.nombres + "','" +
                    personal.cargo + "'," +
                    personal.sueldo + "," +
                    personal.id_pais + ")";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery(); //ejecuta y no devuelve 
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;

                    }
                }
            }
        }

        //selecionar y retornar lista
        public List<dato_clase_personal> todos()
        {
            var listapersonal = new List<dato_clase_personal>();
            using (var conexion = cn.obtener_conexion())//1 llamo a la conexion con la base
            {
                string cadena = "SELECT id_personal, cedula, nombres, cargo, sueldo, Paises.Detalle " +
                    "FROM Personales inner join Paises on Paises.id_pais = Personales.id_pais"; //2 creo la sentencia sql
                using (var comando = new SqlCommand(cadena, conexion)) //3 ejecuto el comando 
                {
                    conexion.Open(); //4 abrir la conexion
                    using (var lector = comando.ExecuteReader())//5 cargar el lector la informacion
                    {
                        while (lector.Read())  //6 recorrer el lector para obtener la iformacion
                        {
                            var personal = new dato_clase_personal //7  creo un objeto dto_personal para asiganr lo que trae de la base de datos
                            {
                                id_personal = (int)lector["id_personal"],
                                cedula = lector["cedula"].ToString(),
                                nombres = lector["nombres"].ToString(),
                                cargo = lector["cargo"].ToString(),
                                sueldo = (decimal)lector["sueldo"],
                                detalle = lector["detalle"].ToString()

                            };
                            listapersonal.Add(personal); //8 agregar a la lista el objeto
                        }
                    }
                }
            }

            return listapersonal;
        }

        //selecciona 
        public dato_clase_personal uno(int id)
        {
            using (var conexion = cn.obtener_conexion())
            {
                string cadena = "select * from Personales where id_personal =" + id;
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            var personal = new dato_clase_personal
                            {
                                id_personal = (int)lector["id_personal"],
                                cedula = lector["cedula"].ToString(),
                                nombres = lector["nombres"].ToString(),
                                cargo = lector["cargo"].ToString(),
                                sueldo = (decimal)lector["sueldo"],
                                id_pais = (int)lector["id_pais"]
                                //detalle = lector["detalle"].ToString()
                            };
                            return personal;
                        }
                        else
                        {
                            // Handle the case where no data is returned
                            return null;
                        }
                    }
                }
            }
        }
    }
}

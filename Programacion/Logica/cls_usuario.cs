using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programacion.Datos;
using Programacion.Logica;
namespace Programacion.Logica
{
    internal class cls_usuario
    {
        private readonly conexion cn = new conexion();
        //Usuario IdUsuario NombreUsuario Contrasenia CreateAt ModifiedAt

        //insertar CREATE
        public string Insertar(dato_clase_usuario Usuario)
        {
            using (var conexion = cn.obtener_conexion())
            {
                string cadena1 = "insert into Usuario (NombreUsuario, Contrasenia) values('" +
                    Usuario.NombreUsuario + "','" +
                    Usuario.Contrasenia + "')";
                using (var comando = new SqlCommand(cadena1, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
        }


        //listar READ
        public List<dato_clase_usuario> todos()
        {
            var listausuario = new List<dato_clase_usuario>();
            using (var conexion = cn.obtener_conexion())
            {
                //IsUsuario, NombreUsuario, Contasenia, CreateAt, ModifiedAt
                string cadena = "select *from Usuario";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var usuario = new dato_clase_usuario
                            {
                                //Usuario IdUsuario NombreUsuario Contrasenia  CreateAt ModifiedAt
                                
                                id_usuario = (int)lector["id_usuario"],
                                NombreUsuario = lector["NombreUsuario"].ToString(),
                                Contrasenia = lector["Contrasenia"].ToString(),
                                //CreateAt = (DateTime)lector["CreateAt"],
                                //ModifiedAt = (DateTime)lector["ModifiedAt"],
                            };
                            listausuario.Add(usuario);
                        }
                    }
                }
            }

            return listausuario;
        }


        //actualizar UPDATE
        public string actualizar(dato_clase_usuario usuario)
        {
            using (var conexion = cn.obtener_conexion())
            {
                string cadena = "update Usuario set " +
                    $"NombreUsuario='{usuario.NombreUsuario}', Contrasenia='{usuario.Contrasenia}'," +
                    $"ModifiedAt=GETDATE() where IdUsuario={usuario.id_usuario}";

                //$"ModifiedAt='{usuario.ModifiedAt.ToString("yyyy-MM-dd HH:mm:ss")}' where IdUsuario={usuario.IdUsuario}";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return "ok";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
            }
        }
        //Eliminar DELETE
        public bool eliminar(int id)
        {
            using (var conexion = cn.obtener_conexion())
            {
                string cadena = $"delete from usuario where id_usuario={id}";
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

        //buscar 
        public dato_clase_usuario buscarPorId(int id)
        {
            using (var conexion = cn.obtener_conexion())
            {
                string cadena = "select * from usuario where id_usuario=" + id;
                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();
                        var usuario = new dato_clase_usuario
                        {
                            id_usuario = (int)lector["id_usuario"],
                            NombreUsuario = lector["NombreUsuario"].ToString(),
                            Contrasenia = lector["Contrasenia"].ToString(),
                            ModifiedAt = (DateTime)lector["ModifiedAt"],
                            CreateAt = (DateTime)lector["CreateAt"],
                        };
                        return usuario;
                    }
                }
            }
        }
        public List<dato_clase_usuario> buscador(string texto)
        {
            List<dato_clase_usuario> listausuario = new List<dato_clase_usuario>();

            using (var conexion = cn.obtener_conexion())
            {
                //string cadena = "SELECT * FROM Usuario" +
                // $"where NombreUsuario like '%{texto}%'";
                string cadena = "SELECT * FROM Usuario " +
                    $"WHERE NombreUsuario LIKE '%{texto}%'";

                using (var comando = new SqlCommand(cadena, conexion))
                {
                    conexion.Open();
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            var usuario = new dato_clase_usuario
                            {
                                id_usuario = (int)lector["id_usuario"],
                                NombreUsuario = lector["NombreUsuario"].ToString(),
                                Contrasenia = lector["Contrasenia"].ToString(),
                                CreateAt = (DateTime)lector["CreateAt"],
                                ModifiedAt = (DateTime)lector["ModifiedAt"],
                            };
                            listausuario.Add(usuario);
                        }
                    }
                }
            }

            return listausuario;

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programacion.Datos;
using Programacion.Logica;

namespace Programacion.Presentacion.Usuario
{
    public partial class frmUsuario : Form
    {
        public bool modoEdision = false;
        public int id = 0;
        public frmUsuario(string modo)
        {
            InitializeComponent();
            if (modo != "n")
            {
                this.modoEdision = true;
                this.id = int.Parse(modo);
            }
        }
        
        private void bot_guardar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == " " || txt_contrasenia.Text == " ")
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }
            try
            {
                var dato_usuario = new Datos.dato_clase_usuario
                {
                    NombreUsuario = txt_usuario.Text,
                    Contrasenia = txt_contrasenia.Text,
                };
                var cls_usuario = new cls_usuario();
                if (!this.modoEdision)
                {
                    var resultado = cls_usuario.Insertar(dato_usuario);
         
                    if (resultado == "ok")
                    {
                        MessageBox.Show("Se guardó con éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar");
                    }
                }
                else
                {
                    dato_usuario.id_usuario = this.id;
                    var resultado = cls_usuario.actualizar(dato_usuario);
                    if (resultado == "ok")
                    {
                        MessageBox.Show("Se actualizó con éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Error al actualizar");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            if (!this.modoEdision)
            {
                lbl_usuario.Text = "Ingreso de Nuevo Usuario";
            }
            else
            {

                lbl_usuario.Text = " Actualizacion de Usuario";
                var clsUsuario = new cls_usuario();
                var usuario = clsUsuario.buscarPorId(this.id);
                txt_usuario.Text = usuario.NombreUsuario;
                txt_contrasenia.Text = usuario.Contrasenia;
            }
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

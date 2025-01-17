using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programacion.Logica;
using Programacion.Presentacion.Personal;
using Programacion.Presentacion.Usuario;


namespace Programacion.Presentacion
{
    public partial class CUUsuario : UserControl
    {
        public CUUsuario()
        {
            InitializeComponent();
        }

        private void bot_nuevo_Click(object sender, EventArgs e)
        {
            frmUsuario frmusuario = new frmUsuario("n");
            frmusuario.Text = "Nuevo Ingreso de Personal";
            frmusuario.ShowDialog();
        }

        private void CUUsuario_Load(object sender, EventArgs e)
        {
            this.cargagrilla();
        }
        public void cargagrilla()
        {
            var logicapersonal = new cls_usuario();
            var autoincremento = new DataGridViewTextBoxColumn
            {
                HeaderText = "N.-",
                ReadOnly = true
            };
            dataGridView1.Columns.Add(autoincremento);

            //botones data grid

            var btn_editar = new DataGridViewButtonColumn
            {
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };


            var btn_eliminar = new DataGridViewButtonColumn
            {
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            // fin botones grid

            //cambio de etiquetas cabecera
            dataGridView1.DataSource = logicapersonal.todos();
            dataGridView1.Columns["NombreUsuario"].HeaderText = "Usuario";
            dataGridView1.Columns["Contrasenia"].HeaderText = "Contraseña";
            dataGridView1.Columns["CreateAt"].HeaderText = "Fecha de Creación";
            dataGridView1.Columns["ModifiedAt"].HeaderText = "Fecha de Modificación";

            //ocultar columnas
            dataGridView1.Columns["id_usuario"].Visible = false;
            //dataGridView1.Columns["id_pais"].Visible = false;

            //llamada botones
            dataGridView1.Columns.Add(btn_editar);
            dataGridView1.Columns.Add(btn_eliminar);

            //para que se ejecute los eventos en orden y cargue la numeración
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }
        public void EditarPersonal(int id)
        {
            MessageBox.Show("Desea editar y el ID es: " + id);
            frmUsuario frmusuario = new frmUsuario(id.ToString());
            frmusuario.ShowDialog();
        }

        public void EliminarPersonal(int id)
        {
            MessageBox.Show("Desea eliminar y el ID es: " + id);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

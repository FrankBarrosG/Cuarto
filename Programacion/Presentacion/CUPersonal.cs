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

namespace Programacion.Presentacion
{
    public partial class CUPersonal : UserControl
    {
        public CUPersonal()
        {
            InitializeComponent();
        }

        private void bot_nuevo_Click(object sender, EventArgs e)
        {
            FrmPersonal frmpersonal = new FrmPersonal("n");
            frmpersonal.Text = "Nuevo Ingreso de Personal";
            frmpersonal.ShowDialog();
        }

        private void CUPersonal_Load(object sender, EventArgs e)
        {
            // llamr al cls_personal
            this.cargagrilla();

        }
        public void cargagrilla()
        {
            var logicapersonal = new cls_personal();
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
            dataGridView1.Columns["cedula"].HeaderText = "Cédula";
            dataGridView1.Columns["nombres"].HeaderText = "Nombres";
            dataGridView1.Columns["cargo"].HeaderText = "Cargo";
            dataGridView1.Columns["sueldo"].HeaderText = "Salario";

            //ocultar columnas
            dataGridView1.Columns["id_personal"].Visible = false;
            dataGridView1.Columns["id_pais"].Visible = false;

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
            FrmPersonal frmpersonal = new FrmPersonal(id.ToString());
            frmpersonal.ShowDialog();
        }

        public void EliminarPersonal(int id)
        {
            MessageBox.Show("Desea eliminar y el ID es: " + id);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if(dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var filaseleciona = dataGridView1.Rows [e.RowIndex];
                var id_personal = filaseleciona.Cells["id_personal"].Value;
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    EditarPersonal((int)id_personal);
                }
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Eliminar")
                {
                    EliminarPersonal((int)id_personal);
                }

            }

        }
    }
}

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

namespace Programacion.Presentacion.Personal
{
    public partial class FrmPersonal : Form
    {
        public bool modoEdision = false;
        public int id = 0;
        public FrmPersonal(string modo)
        {
            InitializeComponent();
            if (modo != "n")
            {
                this.modoEdision = true;
                this.id = int.Parse(modo);
            }
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            cargapais();
            if (this.modoEdision)
            {
                lbl_personal.Text = "Ingreso nuevo personal";
            }
            else
            {
                lbl_personal.Text = "Actualización de personal";
                var cls_personal = new cls_personal();
                var personal = cls_personal.uno(this.id);
                txt_cargo.Text = personal.cargo;
                txt_cedula.Text = personal.cedula;
                txt_nombres.Text = personal.nombres;
                txt_salario.Text= personal.sueldo.ToString();
                cmb_pais.Text= personal.id_pais.ToString();
            } 

        }
        public void cargapais()
        {
            var listapaises = new cls_pais();
            //cmb_pais.DataSource = "";
            cmb_pais.DataSource = listapaises.leer();
            cmb_pais.ValueMember = "id_pais";
            cmb_pais.DisplayMember = "detalle";
        }
        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ingresar solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bot_guardar_Click(object sender, EventArgs e)
        {
            var dato_clase_personal = new Datos.dato_clase_personal
            {
                cargo = txt_cargo.Text,
                cedula = txt_cedula.Text,
                id_pais= (int)cmb_pais.SelectedValue,
                nombres = txt_nombres.Text,
                sueldo = Convert.ToDecimal(txt_salario.Text)
            
            };
            var cls_personal = new cls_personal();

            if(cls_personal.Insertar(dato_clase_personal)== "ok")
            {
                MessageBox.Show("Se guardó con Exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("");
            }
        }
    }
}

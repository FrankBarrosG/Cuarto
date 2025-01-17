using Programacion.Presentacion;

namespace Programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bot_personal_Click(object sender, EventArgs e)
        {
            CUPersonal frmPrueba = new CUPersonal();
            panel_gen.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            panel_gen.Controls.Add(frmPrueba);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CUUsuario frmUsuarios = new CUUsuario();
            panel_gen.Controls.Clear();
            frmUsuarios.Dock = DockStyle.Fill;
            panel_gen.Controls.Add(frmUsuarios);
            

        }
    }
}

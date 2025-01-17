namespace Programacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_gen = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            bot_asistencia = new Button();
            bot_personal = new Button();
            bot_restaurar = new Button();
            bot_respaldos = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel_gen.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_gen
            // 
            panel_gen.BackColor = Color.LightSlateGray;
            panel_gen.Controls.Add(label2);
            panel_gen.Dock = DockStyle.Fill;
            panel_gen.Location = new Point(221, 0);
            panel_gen.Name = "panel_gen";
            panel_gen.Size = new Size(1013, 772);
            panel_gen.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(403, 237);
            label2.Name = "label2";
            label2.Size = new Size(439, 299);
            label2.TabIndex = 10;
            label2.Text = "SISTEMA DE INGRESOS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 104);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.IndianRed;
            button1.Image = Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(221, 104);
            button1.TabIndex = 5;
            button1.Text = "Usuarios";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bot_asistencia
            // 
            bot_asistencia.BackColor = SystemColors.ControlLight;
            bot_asistencia.Dock = DockStyle.Top;
            bot_asistencia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bot_asistencia.ForeColor = Color.IndianRed;
            bot_asistencia.Image = Properties.Resources.pautas__1_;
            bot_asistencia.ImageAlign = ContentAlignment.BottomCenter;
            bot_asistencia.Location = new Point(0, 104);
            bot_asistencia.Name = "bot_asistencia";
            bot_asistencia.Size = new Size(221, 100);
            bot_asistencia.TabIndex = 4;
            bot_asistencia.Text = "Asistencia";
            bot_asistencia.TextImageRelation = TextImageRelation.TextAboveImage;
            bot_asistencia.UseVisualStyleBackColor = false;
            // 
            // bot_personal
            // 
            bot_personal.BackColor = SystemColors.ControlLight;
            bot_personal.Dock = DockStyle.Top;
            bot_personal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bot_personal.ForeColor = Color.IndianRed;
            bot_personal.Image = Properties.Resources.equipo_medico;
            bot_personal.Location = new Point(0, 204);
            bot_personal.Name = "bot_personal";
            bot_personal.Size = new Size(221, 100);
            bot_personal.TabIndex = 5;
            bot_personal.Text = "Personal";
            bot_personal.TextImageRelation = TextImageRelation.TextAboveImage;
            bot_personal.UseVisualStyleBackColor = false;
            bot_personal.Click += bot_personal_Click;
            // 
            // bot_restaurar
            // 
            bot_restaurar.BackColor = SystemColors.ControlLight;
            bot_restaurar.Dock = DockStyle.Top;
            bot_restaurar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bot_restaurar.ForeColor = Color.IndianRed;
            bot_restaurar.Image = Properties.Resources.actualizar;
            bot_restaurar.Location = new Point(0, 304);
            bot_restaurar.Name = "bot_restaurar";
            bot_restaurar.Size = new Size(221, 100);
            bot_restaurar.TabIndex = 6;
            bot_restaurar.Text = "Restaurar BD";
            bot_restaurar.TextImageRelation = TextImageRelation.TextAboveImage;
            bot_restaurar.UseVisualStyleBackColor = false;
            // 
            // bot_respaldos
            // 
            bot_respaldos.BackColor = SystemColors.ControlLight;
            bot_respaldos.Dock = DockStyle.Top;
            bot_respaldos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bot_respaldos.ForeColor = Color.IndianRed;
            bot_respaldos.Image = Properties.Resources.big_data;
            bot_respaldos.Location = new Point(0, 404);
            bot_respaldos.Name = "bot_respaldos";
            bot_respaldos.Size = new Size(221, 114);
            bot_respaldos.TabIndex = 7;
            bot_respaldos.Text = "Respaldos";
            bot_respaldos.TextImageRelation = TextImageRelation.TextAboveImage;
            bot_respaldos.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 518);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(0, 666);
            label1.Name = "label1";
            label1.Size = new Size(221, 76);
            label1.TabIndex = 9;
            label1.Text = "SISTEMA DE INGRESOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(bot_respaldos);
            panel1.Controls.Add(bot_restaurar);
            panel1.Controls.Add(bot_personal);
            panel1.Controls.Add(bot_asistencia);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 772);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1234, 772);
            Controls.Add(panel_gen);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            panel_gen.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_gen;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Button bot_asistencia;
        private Button bot_personal;
        private Button bot_restaurar;
        private Button bot_respaldos;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
    }
}

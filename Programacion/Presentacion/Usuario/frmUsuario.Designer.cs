namespace Programacion.Presentacion.Usuario
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_repite = new TextBox();
            txt_contrasenia = new TextBox();
            txt_usuario = new TextBox();
            bot_guardar = new Button();
            bot_cancelar = new Button();
            lbl_usuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_repite);
            panel1.Controls.Add(txt_contrasenia);
            panel1.Controls.Add(txt_usuario);
            panel1.Controls.Add(bot_guardar);
            panel1.Controls.Add(bot_cancelar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 437);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(117, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 288);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 8;
            label3.Text = "Repita la contraseña:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 248);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 7;
            label2.Text = "Ingrese su contraseña :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 208);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 6;
            label1.Text = "Ingrese Usuario :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_repite
            // 
            txt_repite.BackColor = SystemColors.Menu;
            txt_repite.Location = new Point(241, 282);
            txt_repite.Name = "txt_repite";
            txt_repite.Size = new Size(282, 27);
            txt_repite.TabIndex = 3;
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.BackColor = SystemColors.Menu;
            txt_contrasenia.Location = new Point(241, 242);
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.Size = new Size(282, 27);
            txt_contrasenia.TabIndex = 2;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = SystemColors.Menu;
            txt_usuario.Location = new Point(241, 202);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(282, 27);
            txt_usuario.TabIndex = 1;
            // 
            // bot_guardar
            // 
            bot_guardar.Dock = DockStyle.Bottom;
            bot_guardar.Location = new Point(0, 345);
            bot_guardar.Name = "bot_guardar";
            bot_guardar.Size = new Size(545, 46);
            bot_guardar.TabIndex = 6;
            bot_guardar.Text = "Guardar";
            bot_guardar.UseVisualStyleBackColor = true;
            bot_guardar.Click += bot_guardar_Click;
            // 
            // bot_cancelar
            // 
            bot_cancelar.Dock = DockStyle.Bottom;
            bot_cancelar.Location = new Point(0, 391);
            bot_cancelar.Name = "bot_cancelar";
            bot_cancelar.Size = new Size(545, 46);
            bot_cancelar.TabIndex = 7;
            bot_cancelar.Text = "Cancelar";
            bot_cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = SystemColors.ActiveCaptionText;
            lbl_usuario.Dock = DockStyle.Top;
            lbl_usuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = SystemColors.ControlLightLight;
            lbl_usuario.Location = new Point(0, 0);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(81, 31);
            lbl_usuario.TabIndex = 2;
            lbl_usuario.Text = "label1";
            lbl_usuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 468);
            Controls.Add(panel1);
            Controls.Add(lbl_usuario);
            Name = "frmUsuario";
            Text = "frmUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private ComboBox cmb_pais;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_salario;
        private TextBox txt_repite;
        private TextBox txt_contrasenia;
        private TextBox txt_usuario;
        private Button bot_guardar;
        private Button bot_cancelar;
        private Label lbl_usuario;
        private PictureBox pictureBox1;
    }
}
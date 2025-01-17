namespace Programacion.Presentacion.Personal
{
    partial class FrmPersonal
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
            lbl_personal = new Label();
            panel1 = new Panel();
            label5 = new Label();
            cmb_pais = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_salario = new TextBox();
            txt_cargo = new TextBox();
            txt_nombres = new TextBox();
            txt_cedula = new TextBox();
            bot_guardar = new Button();
            bot_cancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_personal
            // 
            lbl_personal.AutoSize = true;
            lbl_personal.BackColor = SystemColors.ActiveCaptionText;
            lbl_personal.Dock = DockStyle.Top;
            lbl_personal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_personal.ForeColor = SystemColors.ControlLightLight;
            lbl_personal.Location = new Point(0, 0);
            lbl_personal.Name = "lbl_personal";
            lbl_personal.Size = new Size(81, 31);
            lbl_personal.TabIndex = 0;
            lbl_personal.Text = "label1";
            lbl_personal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmb_pais);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_salario);
            panel1.Controls.Add(txt_cargo);
            panel1.Controls.Add(txt_nombres);
            panel1.Controls.Add(txt_cedula);
            panel1.Controls.Add(bot_guardar);
            panel1.Controls.Add(bot_cancelar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 367);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 194);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 11;
            label5.Text = "País :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_pais
            // 
            cmb_pais.BackColor = SystemColors.ActiveBorder;
            cmb_pais.FormattingEnabled = true;
            cmb_pais.Location = new Point(246, 186);
            cmb_pais.Name = "cmb_pais";
            cmb_pais.Size = new Size(282, 36);
            cmb_pais.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 152);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 9;
            label4.Text = "Sueldo//hora :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 112);
            label3.Name = "label3";
            label3.Size = new Size(154, 28);
            label3.TabIndex = 8;
            label3.Text = "Cargo //Puesto :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 72);
            label2.Name = "label2";
            label2.Size = new Size(204, 28);
            label2.TabIndex = 7;
            label2.Text = "Nombres y Apellidos :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 6;
            label1.Text = "Cédula :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_salario
            // 
            txt_salario.BackColor = SystemColors.ActiveBorder;
            txt_salario.Location = new Point(246, 146);
            txt_salario.Name = "txt_salario";
            txt_salario.Size = new Size(282, 34);
            txt_salario.TabIndex = 4;
            // 
            // txt_cargo
            // 
            txt_cargo.BackColor = SystemColors.ActiveBorder;
            txt_cargo.Location = new Point(246, 106);
            txt_cargo.Name = "txt_cargo";
            txt_cargo.Size = new Size(282, 34);
            txt_cargo.TabIndex = 3;
            // 
            // txt_nombres
            // 
            txt_nombres.BackColor = SystemColors.ActiveBorder;
            txt_nombres.Location = new Point(246, 66);
            txt_nombres.Name = "txt_nombres";
            txt_nombres.Size = new Size(282, 34);
            txt_nombres.TabIndex = 2;
            // 
            // txt_cedula
            // 
            txt_cedula.BackColor = SystemColors.ActiveBorder;
            txt_cedula.Location = new Point(246, 26);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(282, 34);
            txt_cedula.TabIndex = 1;
            txt_cedula.KeyPress += txt_cedula_KeyPress;
            // 
            // bot_guardar
            // 
            bot_guardar.BackColor = Color.LightSkyBlue;
            bot_guardar.Dock = DockStyle.Bottom;
            bot_guardar.Location = new Point(0, 275);
            bot_guardar.Name = "bot_guardar";
            bot_guardar.Size = new Size(612, 46);
            bot_guardar.TabIndex = 6;
            bot_guardar.Text = "Guardar";
            bot_guardar.UseVisualStyleBackColor = false;
            bot_guardar.Click += bot_guardar_Click;
            // 
            // bot_cancelar
            // 
            bot_cancelar.BackColor = SystemColors.HotTrack;
            bot_cancelar.Dock = DockStyle.Bottom;
            bot_cancelar.Location = new Point(0, 321);
            bot_cancelar.Name = "bot_cancelar";
            bot_cancelar.Size = new Size(612, 46);
            bot_cancelar.TabIndex = 7;
            bot_cancelar.Text = "Cancelar";
            bot_cancelar.UseVisualStyleBackColor = false;
            // 
            // FrmPersonal
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(612, 398);
            Controls.Add(panel1);
            Controls.Add(lbl_personal);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPersonal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmPersonal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_personal;
        private Panel panel1;
        private Button bot_guardar;
        private Button bot_cancelar;
        private ComboBox cmb_pais;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_salario;
        private TextBox txt_cargo;
        private TextBox txt_nombres;
        private TextBox txt_cedula;
        private Label label5;
    }
}
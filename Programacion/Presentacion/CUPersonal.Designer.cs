namespace Programacion.Presentacion
{
    partial class CUPersonal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            bot_nuevo = new Button();
            bot_buscar = new Button();
            txt_buscar = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(bot_nuevo);
            panel1.Controls.Add(bot_buscar);
            panel1.Controls.Add(txt_buscar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 103);
            panel1.TabIndex = 0;
            // 
            // bot_nuevo
            // 
            bot_nuevo.Font = new Font("Segoe UI", 12F);
            bot_nuevo.Image = Properties.Resources.nuevo_reg;
            bot_nuevo.ImageAlign = ContentAlignment.TopCenter;
            bot_nuevo.Location = new Point(692, 7);
            bot_nuevo.Name = "bot_nuevo";
            bot_nuevo.Size = new Size(123, 41);
            bot_nuevo.TabIndex = 2;
            bot_nuevo.Text = "Nuevo";
            bot_nuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            bot_nuevo.UseVisualStyleBackColor = true;
            bot_nuevo.Click += bot_nuevo_Click;
            // 
            // bot_buscar
            // 
            bot_buscar.Font = new Font("Segoe UI", 12F);
            bot_buscar.Location = new Point(162, 56);
            bot_buscar.Name = "bot_buscar";
            bot_buscar.Size = new Size(104, 41);
            bot_buscar.TabIndex = 1;
            bot_buscar.Text = "Buscar";
            bot_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Segoe UI", 12F);
            txt_buscar.Location = new Point(61, 14);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(296, 34);
            txt_buscar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 593);
            panel2.Name = "panel2";
            panel2.Size = new Size(981, 100);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(978, 486);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // CUPersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "CUPersonal";
            Size = new Size(981, 693);
            Load += CUPersonal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button bot_buscar;
        private TextBox txt_buscar;
        private Button bot_nuevo;
        private DataGridView dataGridView1;
    }
}

namespace BD_Grupo3_VS
{
    partial class ConsultarPlanTratamiento
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
            this.components = new System.ComponentModel.Container();
            this.LINK_Menu = new System.Windows.Forms.LinkLabel();
            this.LINK_AgregaPlan = new System.Windows.Forms.LinkLabel();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.Location = new System.Drawing.Point(852, 34);
            this.LINK_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(117, 17);
            this.LINK_Menu.TabIndex = 0;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Al Menú Principal";
            // 
            // LINK_AgregaPlan
            // 
            this.LINK_AgregaPlan.AutoSize = true;
            this.LINK_AgregaPlan.Location = new System.Drawing.Point(796, 78);
            this.LINK_AgregaPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LINK_AgregaPlan.Name = "LINK_AgregaPlan";
            this.LINK_AgregaPlan.Size = new System.Drawing.Size(191, 17);
            this.LINK_AgregaPlan.TabIndex = 1;
            this.LINK_AgregaPlan.TabStop = true;
            this.LINK_AgregaPlan.Text = "Agregar Plan de Tratamiento";
            this.LINK_AgregaPlan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LINK_AgregaPlan_LinkClicked);
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Titulo.Location = new System.Drawing.Point(145, 34);
            this.LBL_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(603, 42);
            this.LBL_Titulo.TabIndex = 2;
            this.LBL_Titulo.Text = "Consulta de Planes de Tratamiento";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(33, 151);
            this.LBL_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(56, 17);
            this.LBL_Cedula.TabIndex = 3;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_Cedula.Location = new System.Drawing.Point(125, 148);
            this.TXT_Cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(193, 22);
            this.TXT_Cedula.TabIndex = 4;
            this.toolTip1.SetToolTip(this.TXT_Cedula, "Digite el número de cédula a consultar");
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(532, 148);
            this.TXT_Padecimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(193, 22);
            this.TXT_Padecimiento.TabIndex = 6;
            this.toolTip1.SetToolTip(this.TXT_Padecimiento, "Digite el padecimiento a consultar");
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(401, 151);
            this.LBL_Padecimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(97, 17);
            this.LBL_Padecimiento.TabIndex = 5;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(911, 345);
            this.dataGridView1.TabIndex = 7;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(807, 140);
            this.BTN_Buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(141, 38);
            this.BTN_Buscar.TabIndex = 8;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InicioToolStripMenuItem,
            this.buscarPacienteToolStripMenuItem,
            this.crearPacienteToolStripMenuItem,
            this.avanzadoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 28);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.InicioToolStripMenuItem.Text = "Inicio";
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            // 
            // crearPacienteToolStripMenuItem
            // 
            this.crearPacienteToolStripMenuItem.Name = "crearPacienteToolStripMenuItem";
            this.crearPacienteToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.crearPacienteToolStripMenuItem.Text = "Crear Paciente";
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ConsultarPlanTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 578);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXT_Padecimiento);
            this.Controls.Add(this.LBL_Padecimiento);
            this.Controls.Add(this.TXT_Cedula);
            this.Controls.Add(this.LBL_Cedula);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.LINK_AgregaPlan);
            this.Controls.Add(this.LINK_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConsultarPlanTratamiento";
            this.Text = "ConsultarPlanTratamiento";
            this.Load += new System.EventHandler(this.ConsultarPlanTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LINK_Menu;
        private System.Windows.Forms.LinkLabel LINK_AgregaPlan;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Padecimiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}
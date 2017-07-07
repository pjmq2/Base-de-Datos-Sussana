namespace BD_Grupo3_VS
{
    partial class AgregarAntecedentes
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
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.TXT_NombreAnte = new System.Windows.Forms.TextBox();
            this.LBL_NombreAnte = new System.Windows.Forms.Label();
            this.GB_InfoAntecedente = new System.Windows.Forms.GroupBox();
            this.TXT_TipoAnt = new System.Windows.Forms.TextBox();
            this.LBL_TipoAnt = new System.Windows.Forms.Label();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_InfoAntecedente.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Titulo.Location = new System.Drawing.Point(124, 26);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(192, 33);
            this.LBL_Titulo.TabIndex = 5;
            this.LBL_Titulo.Text = "Antecedentes";
            // 
            // TXT_NombreAnte
            // 
            this.TXT_NombreAnte.Location = new System.Drawing.Point(175, 46);
            this.TXT_NombreAnte.Name = "TXT_NombreAnte";
            this.TXT_NombreAnte.Size = new System.Drawing.Size(154, 20);
            this.TXT_NombreAnte.TabIndex = 8;
            // 
            // LBL_NombreAnte
            // 
            this.LBL_NombreAnte.AutoSize = true;
            this.LBL_NombreAnte.Location = new System.Drawing.Point(28, 46);
            this.LBL_NombreAnte.Name = "LBL_NombreAnte";
            this.LBL_NombreAnte.Size = new System.Drawing.Size(127, 13);
            this.LBL_NombreAnte.TabIndex = 9;
            this.LBL_NombreAnte.Text = "Nombre del antecedente:";
            // 
            // GB_InfoAntecedente
            // 
            this.GB_InfoAntecedente.Controls.Add(this.TXT_TipoAnt);
            this.GB_InfoAntecedente.Controls.Add(this.LBL_TipoAnt);
            this.GB_InfoAntecedente.Controls.Add(this.BTN_Agregar);
            this.GB_InfoAntecedente.Controls.Add(this.TXT_NombreAnte);
            this.GB_InfoAntecedente.Controls.Add(this.LBL_NombreAnte);
            this.GB_InfoAntecedente.Location = new System.Drawing.Point(31, 62);
            this.GB_InfoAntecedente.Name = "GB_InfoAntecedente";
            this.GB_InfoAntecedente.Size = new System.Drawing.Size(371, 245);
            this.GB_InfoAntecedente.TabIndex = 13;
            this.GB_InfoAntecedente.TabStop = false;
            this.GB_InfoAntecedente.Text = "Detellas del antecedente";
            // 
            // TXT_TipoAnt
            // 
            this.TXT_TipoAnt.Location = new System.Drawing.Point(175, 97);
            this.TXT_TipoAnt.Name = "TXT_TipoAnt";
            this.TXT_TipoAnt.Size = new System.Drawing.Size(154, 20);
            this.TXT_TipoAnt.TabIndex = 25;
            // 
            // LBL_TipoAnt
            // 
            this.LBL_TipoAnt.AutoSize = true;
            this.LBL_TipoAnt.Location = new System.Drawing.Point(28, 97);
            this.LBL_TipoAnt.Name = "LBL_TipoAnt";
            this.LBL_TipoAnt.Size = new System.Drawing.Size(110, 13);
            this.LBL_TipoAnt.TabIndex = 24;
            this.LBL_TipoAnt.Text = "Tipo de Antecedente:";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(239, 175);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(90, 35);
            this.BTN_Agregar.TabIndex = 23;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InicioToolStripMenuItem
            // 
            this.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem";
            this.InicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.InicioToolStripMenuItem.Text = "Inicio";
            // 
            // buscarPacienteToolStripMenuItem
            // 
            this.buscarPacienteToolStripMenuItem.Name = "buscarPacienteToolStripMenuItem";
            this.buscarPacienteToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.buscarPacienteToolStripMenuItem.Text = "Buscar Paciente";
            // 
            // crearPacienteToolStripMenuItem
            // 
            this.crearPacienteToolStripMenuItem.Name = "crearPacienteToolStripMenuItem";
            this.crearPacienteToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.crearPacienteToolStripMenuItem.Text = "Crear Paciente";
            // 
            // avanzadoToolStripMenuItem
            // 
            this.avanzadoToolStripMenuItem.Name = "avanzadoToolStripMenuItem";
            this.avanzadoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.avanzadoToolStripMenuItem.Text = "Avanzado";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // AgregarAntecedentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 314);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GB_InfoAntecedente);
            this.Controls.Add(this.LBL_Titulo);
            this.Name = "AgregarAntecedentes";
            this.Text = "AgregarAntecedentes";
            this.GB_InfoAntecedente.ResumeLayout(false);
            this.GB_InfoAntecedente.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.TextBox TXT_NombreAnte;
        private System.Windows.Forms.Label LBL_NombreAnte;
        private System.Windows.Forms.GroupBox GB_InfoAntecedente;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.TextBox TXT_TipoAnt;
        private System.Windows.Forms.Label LBL_TipoAnt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}
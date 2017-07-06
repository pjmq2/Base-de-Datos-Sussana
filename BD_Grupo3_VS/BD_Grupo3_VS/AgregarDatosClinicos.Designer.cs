namespace BD_Grupo3_VS
{
    partial class AgregarDatosClinicos
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
            this.GB_InfoDatosClinicos = new System.Windows.Forms.GroupBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Dato = new System.Windows.Forms.Label();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.TXT_Dato = new System.Windows.Forms.TextBox();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_InfoDatosClinicos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_InfoDatosClinicos
            // 
            this.GB_InfoDatosClinicos.Controls.Add(this.BTN_Agregar);
            this.GB_InfoDatosClinicos.Controls.Add(this.TXT_Cedula);
            this.GB_InfoDatosClinicos.Controls.Add(this.LBL_Dato);
            this.GB_InfoDatosClinicos.Controls.Add(this.LBL_Cedula);
            this.GB_InfoDatosClinicos.Controls.Add(this.TXT_Dato);
            this.GB_InfoDatosClinicos.Location = new System.Drawing.Point(60, 132);
            this.GB_InfoDatosClinicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_InfoDatosClinicos.Name = "GB_InfoDatosClinicos";
            this.GB_InfoDatosClinicos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_InfoDatosClinicos.Size = new System.Drawing.Size(648, 343);
            this.GB_InfoDatosClinicos.TabIndex = 14;
            this.GB_InfoDatosClinicos.TabStop = false;
            this.GB_InfoDatosClinicos.Text = "Detellas de los datos clínicos";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(489, 260);
            this.BTN_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(120, 43);
            this.BTN_Agregar.TabIndex = 23;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(227, 66);
            this.TXT_Cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(204, 22);
            this.TXT_Cedula.TabIndex = 8;
            // 
            // LBL_Dato
            // 
            this.LBL_Dato.AutoSize = true;
            this.LBL_Dato.Location = new System.Drawing.Point(32, 146);
            this.LBL_Dato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Dato.Name = "LBL_Dato";
            this.LBL_Dato.Size = new System.Drawing.Size(87, 17);
            this.LBL_Dato.TabIndex = 9;
            this.LBL_Dato.Text = "Dato Clínico:";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(32, 66);
            this.LBL_Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(56, 17);
            this.LBL_Cedula.TabIndex = 6;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // TXT_Dato
            // 
            this.TXT_Dato.Location = new System.Drawing.Point(227, 143);
            this.TXT_Dato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_Dato.Name = "TXT_Dato";
            this.TXT_Dato.Size = new System.Drawing.Size(204, 22);
            this.TXT_Dato.TabIndex = 10;
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Titulo.Location = new System.Drawing.Point(187, 62);
            this.LBL_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(257, 42);
            this.LBL_Titulo.TabIndex = 15;
            this.LBL_Titulo.Text = "Datos Clínicos";
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
            this.menuStrip1.Size = new System.Drawing.Size(767, 28);
            this.menuStrip1.TabIndex = 40;
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
            // AgregarDatosClinicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 513);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.GB_InfoDatosClinicos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarDatosClinicos";
            this.Text = "AgregarDatosClinicos";
            this.GB_InfoDatosClinicos.ResumeLayout(false);
            this.GB_InfoDatosClinicos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_InfoDatosClinicos;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Dato;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.TextBox TXT_Dato;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}
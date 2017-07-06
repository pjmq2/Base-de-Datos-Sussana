namespace BD_Grupo3_VS
{
    partial class AgregarEjercicio
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
            this.gb_informacionDelMaterial = new System.Windows.Forms.GroupBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_imagen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_LoadAndSave = new System.Windows.Forms.Button();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planDeEjerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_informacionDelMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_informacionDelMaterial
            // 
            this.gb_informacionDelMaterial.Controls.Add(this.btn_Guardar);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_imagen);
            this.gb_informacionDelMaterial.Controls.Add(this.pictureBox1);
            this.gb_informacionDelMaterial.Controls.Add(this.TXT_Descripcion);
            this.gb_informacionDelMaterial.Controls.Add(this.btn_LoadAndSave);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_descripcion);
            this.gb_informacionDelMaterial.Controls.Add(this.lbl_nombre);
            this.gb_informacionDelMaterial.Controls.Add(this.txt_nombre);
            this.gb_informacionDelMaterial.Location = new System.Drawing.Point(48, 93);
            this.gb_informacionDelMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.gb_informacionDelMaterial.Name = "gb_informacionDelMaterial";
            this.gb_informacionDelMaterial.Padding = new System.Windows.Forms.Padding(4);
            this.gb_informacionDelMaterial.Size = new System.Drawing.Size(567, 409);
            this.gb_informacionDelMaterial.TabIndex = 1;
            this.gb_informacionDelMaterial.TabStop = false;
            this.gb_informacionDelMaterial.Text = "Información del Ejercicio";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(417, 296);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(100, 64);
            this.btn_Guardar.TabIndex = 13;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_imagen
            // 
            this.lbl_imagen.AutoSize = true;
            this.lbl_imagen.Location = new System.Drawing.Point(58, 216);
            this.lbl_imagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_imagen.Name = "lbl_imagen";
            this.lbl_imagen.Size = new System.Drawing.Size(58, 17);
            this.lbl_imagen.TabIndex = 12;
            this.lbl_imagen.Text = "Imagen:";
            this.lbl_imagen.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 144);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Location = new System.Drawing.Point(162, 83);
            this.TXT_Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_Descripcion.Multiline = true;
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(355, 116);
            this.TXT_Descripcion.TabIndex = 10;
            // 
            // btn_LoadAndSave
            // 
            this.btn_LoadAndSave.Location = new System.Drawing.Point(162, 367);
            this.btn_LoadAndSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LoadAndSave.Name = "btn_LoadAndSave";
            this.btn_LoadAndSave.Size = new System.Drawing.Size(222, 29);
            this.btn_LoadAndSave.TabIndex = 5;
            this.btn_LoadAndSave.Text = "Buscar y Guardar";
            this.btn_LoadAndSave.UseVisualStyleBackColor = true;
            this.btn_LoadAndSave.Click += new System.EventHandler(this.btn_LoadAndSave_Click);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(58, 88);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(86, 17);
            this.lbl_descripcion.TabIndex = 4;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(58, 35);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(162, 31);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(171, 22);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Titulo.Location = new System.Drawing.Point(254, 47);
            this.LBL_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(178, 42);
            this.LBL_Titulo.TabIndex = 7;
            this.LBL_Titulo.Text = "Ejercicios";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.ejercicioToolStripMenuItem,
            this.citaToolStripMenuItem,
            this.planDeEjerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPacienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.eliminarPacientesToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.clienteToolStripMenuItem.Text = "Paciente";
            // 
            // agregarPacienteToolStripMenuItem
            // 
            this.agregarPacienteToolStripMenuItem.Name = "agregarPacienteToolStripMenuItem";
            this.agregarPacienteToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.agregarPacienteToolStripMenuItem.Text = "Agregar Paciente";
            this.agregarPacienteToolStripMenuItem.Click += new System.EventHandler(this.agregarPacienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.modificarClienteToolStripMenuItem.Text = "Buscar Paciente";
            // 
            // eliminarPacientesToolStripMenuItem
            // 
            this.eliminarPacientesToolStripMenuItem.Name = "eliminarPacientesToolStripMenuItem";
            this.eliminarPacientesToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.eliminarPacientesToolStripMenuItem.Text = "Eliminar Paciente";
            this.eliminarPacientesToolStripMenuItem.Click += new System.EventHandler(this.eliminarPacientesToolStripMenuItem_Click);
            // 
            // ejercicioToolStripMenuItem
            // 
            this.ejercicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEjercicioToolStripMenuItem,
            this.modificarEjercicioToolStripMenuItem,
            this.eliminarEjercicioToolStripMenuItem});
            this.ejercicioToolStripMenuItem.Name = "ejercicioToolStripMenuItem";
            this.ejercicioToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.ejercicioToolStripMenuItem.Text = "Plan de Tratamiento";
            // 
            // crearEjercicioToolStripMenuItem
            // 
            this.crearEjercicioToolStripMenuItem.Name = "crearEjercicioToolStripMenuItem";
            this.crearEjercicioToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.crearEjercicioToolStripMenuItem.Text = "Crear Plan";
            this.crearEjercicioToolStripMenuItem.Click += new System.EventHandler(this.crearEjercicioToolStripMenuItem_Click);
            // 
            // modificarEjercicioToolStripMenuItem
            // 
            this.modificarEjercicioToolStripMenuItem.Name = "modificarEjercicioToolStripMenuItem";
            this.modificarEjercicioToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.modificarEjercicioToolStripMenuItem.Text = "Modificar Plan";
            // 
            // eliminarEjercicioToolStripMenuItem
            // 
            this.eliminarEjercicioToolStripMenuItem.Name = "eliminarEjercicioToolStripMenuItem";
            this.eliminarEjercicioToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.eliminarEjercicioToolStripMenuItem.Text = "Eliminar Plan";
            // 
            // citaToolStripMenuItem
            // 
            this.citaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCitaToolStripMenuItem,
            this.modificarCitaToolStripMenuItem,
            this.eliminarCitaToolStripMenuItem});
            this.citaToolStripMenuItem.Name = "citaToolStripMenuItem";
            this.citaToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.citaToolStripMenuItem.Text = "Cita";
            // 
            // crearCitaToolStripMenuItem
            // 
            this.crearCitaToolStripMenuItem.Name = "crearCitaToolStripMenuItem";
            this.crearCitaToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.crearCitaToolStripMenuItem.Text = "Crear Cita";
            // 
            // modificarCitaToolStripMenuItem
            // 
            this.modificarCitaToolStripMenuItem.Name = "modificarCitaToolStripMenuItem";
            this.modificarCitaToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.modificarCitaToolStripMenuItem.Text = "Modificar Cita";
            // 
            // eliminarCitaToolStripMenuItem
            // 
            this.eliminarCitaToolStripMenuItem.Name = "eliminarCitaToolStripMenuItem";
            this.eliminarCitaToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.eliminarCitaToolStripMenuItem.Text = "Eliminar Cita";
            // 
            // planDeEjerciciosToolStripMenuItem
            // 
            this.planDeEjerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPlanToolStripMenuItem,
            this.modificarPlanToolStripMenuItem,
            this.eliminarPlanToolStripMenuItem});
            this.planDeEjerciciosToolStripMenuItem.Name = "planDeEjerciciosToolStripMenuItem";
            this.planDeEjerciciosToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.planDeEjerciciosToolStripMenuItem.Text = "Plan de Ejercicios";
            // 
            // crearPlanToolStripMenuItem
            // 
            this.crearPlanToolStripMenuItem.Name = "crearPlanToolStripMenuItem";
            this.crearPlanToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.crearPlanToolStripMenuItem.Text = "Crear Plan";
            // 
            // modificarPlanToolStripMenuItem
            // 
            this.modificarPlanToolStripMenuItem.Name = "modificarPlanToolStripMenuItem";
            this.modificarPlanToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.modificarPlanToolStripMenuItem.Text = "Modificar Plan";
            // 
            // eliminarPlanToolStripMenuItem
            // 
            this.eliminarPlanToolStripMenuItem.Name = "eliminarPlanToolStripMenuItem";
            this.eliminarPlanToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.eliminarPlanToolStripMenuItem.Text = "Eliminar Plan";
            // 
            // AgregarEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 502);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.gb_informacionDelMaterial);
            this.Name = "AgregarEjercicio";
            this.Text = "AgregarEjercicio";
            this.gb_informacionDelMaterial.ResumeLayout(false);
            this.gb_informacionDelMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_informacionDelMaterial;
        private System.Windows.Forms.Button btn_LoadAndSave;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label LBL_Titulo;
        private System.Windows.Forms.Label lbl_imagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planDeEjerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPlanToolStripMenuItem;
    }
}
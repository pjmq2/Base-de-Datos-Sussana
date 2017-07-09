namespace BD_Grupo3_VS
{
    partial class BuscarTecnicas
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
            this.LBL_ConsultaDeTecnicas = new System.Windows.Forms.Label();
            this.DGV_Tecnicas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAvanzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTecnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTecnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAntecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAntecedenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_VerModificar = new System.Windows.Forms.Button();
            this.CB_Nombre = new System.Windows.Forms.ComboBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tecnicas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_ConsultaDeTecnicas
            // 
            this.LBL_ConsultaDeTecnicas.AutoSize = true;
            this.LBL_ConsultaDeTecnicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_ConsultaDeTecnicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ConsultaDeTecnicas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_ConsultaDeTecnicas.Location = new System.Drawing.Point(12, 24);
            this.LBL_ConsultaDeTecnicas.Name = "LBL_ConsultaDeTecnicas";
            this.LBL_ConsultaDeTecnicas.Size = new System.Drawing.Size(207, 31);
            this.LBL_ConsultaDeTecnicas.TabIndex = 14;
            this.LBL_ConsultaDeTecnicas.Text = "Buscar técnicas";
            // 
            // DGV_Tecnicas
            // 
            this.DGV_Tecnicas.AllowUserToAddRows = false;
            this.DGV_Tecnicas.AllowUserToDeleteRows = false;
            this.DGV_Tecnicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Tecnicas.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Tecnicas.Location = new System.Drawing.Point(12, 91);
            this.DGV_Tecnicas.MultiSelect = false;
            this.DGV_Tecnicas.Name = "DGV_Tecnicas";
            this.DGV_Tecnicas.ReadOnly = true;
            this.DGV_Tecnicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Tecnicas.Size = new System.Drawing.Size(510, 308);
            this.DGV_Tecnicas.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.menuAvanzadoToolStripMenuItem,
            this.tecnicaToolStripMenuItem,
            this.antecedenteToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.ejercicioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menú principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // menuAvanzadoToolStripMenuItem
            // 
            this.menuAvanzadoToolStripMenuItem.Name = "menuAvanzadoToolStripMenuItem";
            this.menuAvanzadoToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.menuAvanzadoToolStripMenuItem.Text = "Menú avanzado";
            this.menuAvanzadoToolStripMenuItem.Click += new System.EventHandler(this.menuAvanzadoToolStripMenuItem_Click);
            // 
            // tecnicaToolStripMenuItem
            // 
            this.tecnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTecnicaToolStripMenuItem,
            this.buscarTecnicaToolStripMenuItem});
            this.tecnicaToolStripMenuItem.Name = "tecnicaToolStripMenuItem";
            this.tecnicaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tecnicaToolStripMenuItem.Text = "Técnica";
            // 
            // crearTecnicaToolStripMenuItem
            // 
            this.crearTecnicaToolStripMenuItem.Name = "crearTecnicaToolStripMenuItem";
            this.crearTecnicaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.crearTecnicaToolStripMenuItem.Text = "Crear técnica";
            this.crearTecnicaToolStripMenuItem.Click += new System.EventHandler(this.crearTecnicaToolStripMenuItem_Click);
            // 
            // buscarTecnicaToolStripMenuItem
            // 
            this.buscarTecnicaToolStripMenuItem.Name = "buscarTecnicaToolStripMenuItem";
            this.buscarTecnicaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.buscarTecnicaToolStripMenuItem.Text = "Buscar técnica";
            this.buscarTecnicaToolStripMenuItem.Click += new System.EventHandler(this.buscarTecnicaToolStripMenuItem_Click);
            // 
            // antecedenteToolStripMenuItem
            // 
            this.antecedenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAntecedenteToolStripMenuItem,
            this.buscarAntecedenteToolStripMenuItem});
            this.antecedenteToolStripMenuItem.Name = "antecedenteToolStripMenuItem";
            this.antecedenteToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.antecedenteToolStripMenuItem.Text = "Antecedente";
            // 
            // crearAntecedenteToolStripMenuItem
            // 
            this.crearAntecedenteToolStripMenuItem.Name = "crearAntecedenteToolStripMenuItem";
            this.crearAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.crearAntecedenteToolStripMenuItem.Text = "Crear antecedente";
            this.crearAntecedenteToolStripMenuItem.Click += new System.EventHandler(this.crearAntecedenteToolStripMenuItem_Click);
            // 
            // buscarAntecedenteToolStripMenuItem
            // 
            this.buscarAntecedenteToolStripMenuItem.Name = "buscarAntecedenteToolStripMenuItem";
            this.buscarAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.buscarAntecedenteToolStripMenuItem.Text = "Buscar antecedente";
            this.buscarAntecedenteToolStripMenuItem.Click += new System.EventHandler(this.buscarAntecedenteToolStripMenuItem_Click);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearMaterialToolStripMenuItem,
            this.buscarMaterialToolStripMenuItem});
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.materialToolStripMenuItem.Text = "Material";
            // 
            // crearMaterialToolStripMenuItem
            // 
            this.crearMaterialToolStripMenuItem.Name = "crearMaterialToolStripMenuItem";
            this.crearMaterialToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.crearMaterialToolStripMenuItem.Text = "Crear material ";
            this.crearMaterialToolStripMenuItem.Click += new System.EventHandler(this.crearMaterialToolStripMenuItem_Click);
            // 
            // buscarMaterialToolStripMenuItem
            // 
            this.buscarMaterialToolStripMenuItem.Name = "buscarMaterialToolStripMenuItem";
            this.buscarMaterialToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.buscarMaterialToolStripMenuItem.Text = "Buscar material";
            this.buscarMaterialToolStripMenuItem.Click += new System.EventHandler(this.buscarMaterialToolStripMenuItem_Click);
            // 
            // ejercicioToolStripMenuItem
            // 
            this.ejercicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEjercicioToolStripMenuItem,
            this.buscarEjercicioToolStripMenuItem});
            this.ejercicioToolStripMenuItem.Name = "ejercicioToolStripMenuItem";
            this.ejercicioToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ejercicioToolStripMenuItem.Text = "Ejercicio";
            // 
            // crearEjercicioToolStripMenuItem
            // 
            this.crearEjercicioToolStripMenuItem.Name = "crearEjercicioToolStripMenuItem";
            this.crearEjercicioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.crearEjercicioToolStripMenuItem.Text = "Crear ejercicio";
            this.crearEjercicioToolStripMenuItem.Click += new System.EventHandler(this.crearEjercicioToolStripMenuItem_Click);
            // 
            // buscarEjercicioToolStripMenuItem
            // 
            this.buscarEjercicioToolStripMenuItem.Name = "buscarEjercicioToolStripMenuItem";
            this.buscarEjercicioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.buscarEjercicioToolStripMenuItem.Text = "Buscar ejercicio";
            this.buscarEjercicioToolStripMenuItem.Click += new System.EventHandler(this.buscarEjercicioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // BTN_VerModificar
            // 
            this.BTN_VerModificar.Location = new System.Drawing.Point(402, 62);
            this.BTN_VerModificar.Name = "BTN_VerModificar";
            this.BTN_VerModificar.Size = new System.Drawing.Size(120, 23);
            this.BTN_VerModificar.TabIndex = 48;
            this.BTN_VerModificar.Text = "Ver/Modificar";
            this.BTN_VerModificar.UseVisualStyleBackColor = true;
            this.BTN_VerModificar.Click += new System.EventHandler(this.BTN_VerModificar_Click);
            // 
            // CB_Nombre
            // 
            this.CB_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Nombre.FormattingEnabled = true;
            this.CB_Nombre.Location = new System.Drawing.Point(65, 64);
            this.CB_Nombre.Name = "CB_Nombre";
            this.CB_Nombre.Size = new System.Drawing.Size(200, 21);
            this.CB_Nombre.TabIndex = 45;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(271, 62);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(90, 23);
            this.BTN_Buscar.TabIndex = 44;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(12, 67);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(47, 13);
            this.LBL_Nombre.TabIndex = 43;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // BuscarTecnicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.BTN_VerModificar);
            this.Controls.Add(this.CB_Nombre);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.LBL_Nombre);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_ConsultaDeTecnicas);
            this.Controls.Add(this.DGV_Tecnicas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuscarTecnicas";
            this.Text = "Buscar técnicas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscarTecnicas_FormClosed);
            this.Load += new System.EventHandler(this.BuscarTecnicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tecnicas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_ConsultaDeTecnicas;
        private System.Windows.Forms.DataGridView DGV_Tecnicas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAvanzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTecnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTecnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antecedenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAntecedenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAntecedenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button BTN_VerModificar;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.ComboBox CB_Nombre;
    }
}
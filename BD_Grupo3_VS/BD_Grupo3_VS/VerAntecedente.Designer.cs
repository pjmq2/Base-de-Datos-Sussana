namespace BD_Grupo3_VS
{
    partial class VerAntecedente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.LBL_Antecedente = new System.Windows.Forms.Label();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
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
            this.salirtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBL_TiposAnte = new System.Windows.Forms.Label();
            this.DGV_TipoAnte = new System.Windows.Forms.DataGridView();
            this.LBL_TipoClick = new System.Windows.Forms.Label();
            this.LBL_TipoSeleccionado = new System.Windows.Forms.Label();
            this.TXT_TipoSeleccionado = new System.Windows.Forms.TextBox();
            this.LBL_NuevoTipo = new System.Windows.Forms.Label();
            this.TXT_NuevoTipo = new System.Windows.Forms.TextBox();
            this.BTN_AgregarTipo = new System.Windows.Forms.Button();
            this.BTN_EliminarTipo = new System.Windows.Forms.Button();
            this.GB_InfoAnte = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TipoAnte)).BeginInit();
            this.GB_InfoAnte.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(140, 34);
            this.TXT_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(147, 20);
            this.TXT_Nombre.TabIndex = 24;
            this.TXT_Nombre.TextChanged += new System.EventHandler(this.TXT_Nombre_TextChanged);
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(20, 34);
            this.LBL_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(47, 13);
            this.LBL_Nombre.TabIndex = 25;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // LBL_Antecedente
            // 
            this.LBL_Antecedente.AutoSize = true;
            this.LBL_Antecedente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Antecedente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Antecedente.Location = new System.Drawing.Point(206, 37);
            this.LBL_Antecedente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Antecedente.Name = "LBL_Antecedente";
            this.LBL_Antecedente.Size = new System.Drawing.Size(167, 31);
            this.LBL_Antecedente.TabIndex = 26;
            this.LBL_Antecedente.Text = "Antecedente";
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.Location = new System.Drawing.Point(23, 258);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(94, 45);
            this.BTN_Modificar.TabIndex = 29;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.Location = new System.Drawing.Point(194, 258);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(93, 45);
            this.BTN_Eliminar.TabIndex = 30;
            this.BTN_Eliminar.Text = "Eliminar Antecedente";
            this.BTN_Eliminar.UseVisualStyleBackColor = true;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.menuAvanzadoToolStripMenuItem,
            this.tecnicaToolStripMenuItem,
            this.antecedenteToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.ejercicioToolStripMenuItem,
            this.salirtoolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(602, 24);
            this.menuStrip2.TabIndex = 39;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // menuAvanzadoToolStripMenuItem
            // 
            this.menuAvanzadoToolStripMenuItem.Name = "menuAvanzadoToolStripMenuItem";
            this.menuAvanzadoToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.menuAvanzadoToolStripMenuItem.Text = "Menu Avanzado";
            this.menuAvanzadoToolStripMenuItem.Click += new System.EventHandler(this.menuAvanzadoToolStripMenuItem_Click);
            // 
            // tecnicaToolStripMenuItem
            // 
            this.tecnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTecnicaToolStripMenuItem,
            this.buscarTecnicaToolStripMenuItem});
            this.tecnicaToolStripMenuItem.Name = "tecnicaToolStripMenuItem";
            this.tecnicaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tecnicaToolStripMenuItem.Text = "Técnica";
            // 
            // crearTecnicaToolStripMenuItem
            // 
            this.crearTecnicaToolStripMenuItem.Name = "crearTecnicaToolStripMenuItem";
            this.crearTecnicaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.crearTecnicaToolStripMenuItem.Text = "Crear Técnica";
            this.crearTecnicaToolStripMenuItem.Click += new System.EventHandler(this.crearTecnicaToolStripMenuItem_Click);
            // 
            // buscarTecnicaToolStripMenuItem
            // 
            this.buscarTecnicaToolStripMenuItem.Name = "buscarTecnicaToolStripMenuItem";
            this.buscarTecnicaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.buscarTecnicaToolStripMenuItem.Text = "Buscar Técnica";
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
            this.crearAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.crearAntecedenteToolStripMenuItem.Text = "Crear Antecedente";
            this.crearAntecedenteToolStripMenuItem.Click += new System.EventHandler(this.crearAntecedenteToolStripMenuItem_Click);
            // 
            // buscarAntecedenteToolStripMenuItem
            // 
            this.buscarAntecedenteToolStripMenuItem.Name = "buscarAntecedenteToolStripMenuItem";
            this.buscarAntecedenteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.buscarAntecedenteToolStripMenuItem.Text = "Buscar Antecedente";
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
            this.crearMaterialToolStripMenuItem.Text = "Crear Material ";
            this.crearMaterialToolStripMenuItem.Click += new System.EventHandler(this.crearMaterialToolStripMenuItem_Click);
            // 
            // buscarMaterialToolStripMenuItem
            // 
            this.buscarMaterialToolStripMenuItem.Name = "buscarMaterialToolStripMenuItem";
            this.buscarMaterialToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.buscarMaterialToolStripMenuItem.Text = "Buscar Material";
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
            this.crearEjercicioToolStripMenuItem.Text = "Crear Ejercicio";
            this.crearEjercicioToolStripMenuItem.Click += new System.EventHandler(this.crearEjercicioToolStripMenuItem_Click);
            // 
            // buscarEjercicioToolStripMenuItem
            // 
            this.buscarEjercicioToolStripMenuItem.Name = "buscarEjercicioToolStripMenuItem";
            this.buscarEjercicioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.buscarEjercicioToolStripMenuItem.Text = "Buscar Ejercicio";
            this.buscarEjercicioToolStripMenuItem.Click += new System.EventHandler(this.buscarEjercicioToolStripMenuItem_Click);
            // 
            // salirtoolStripMenuItem
            // 
            this.salirtoolStripMenuItem.Name = "salirtoolStripMenuItem";
            this.salirtoolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirtoolStripMenuItem.Text = "Salir";
            this.salirtoolStripMenuItem.Click += new System.EventHandler(this.salirtoolStripMenuItem_Click_1);
            // 
            // LBL_TiposAnte
            // 
            this.LBL_TiposAnte.AutoSize = true;
            this.LBL_TiposAnte.Location = new System.Drawing.Point(20, 68);
            this.LBL_TiposAnte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_TiposAnte.Name = "LBL_TiposAnte";
            this.LBL_TiposAnte.Size = new System.Drawing.Size(116, 13);
            this.LBL_TiposAnte.TabIndex = 40;
            this.LBL_TiposAnte.Text = "Tipos del antecedente:";
            // 
            // DGV_TipoAnte
            // 
            this.DGV_TipoAnte.AllowUserToAddRows = false;
            this.DGV_TipoAnte.AllowUserToDeleteRows = false;
            this.DGV_TipoAnte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.DGV_TipoAnte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGV_TipoAnte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TipoAnte.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TipoAnte.Location = new System.Drawing.Point(141, 68);
            this.DGV_TipoAnte.MultiSelect = false;
            this.DGV_TipoAnte.Name = "DGV_TipoAnte";
            this.DGV_TipoAnte.ReadOnly = true;
            this.DGV_TipoAnte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TipoAnte.Size = new System.Drawing.Size(147, 103);
            this.DGV_TipoAnte.TabIndex = 41;
            this.DGV_TipoAnte.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_TipoAnte_CellContentDoubleClick);
            // 
            // LBL_TipoClick
            // 
            this.LBL_TipoClick.AutoSize = true;
            this.LBL_TipoClick.Location = new System.Drawing.Point(20, 182);
            this.LBL_TipoClick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_TipoClick.Name = "LBL_TipoClick";
            this.LBL_TipoClick.Size = new System.Drawing.Size(304, 13);
            this.LBL_TipoClick.TabIndex = 42;
            this.LBL_TipoClick.Text = "Haga doble click en un tipo de antecedente para seleccionarlo";
            // 
            // LBL_TipoSeleccionado
            // 
            this.LBL_TipoSeleccionado.AutoSize = true;
            this.LBL_TipoSeleccionado.Location = new System.Drawing.Point(20, 217);
            this.LBL_TipoSeleccionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_TipoSeleccionado.Name = "LBL_TipoSeleccionado";
            this.LBL_TipoSeleccionado.Size = new System.Drawing.Size(97, 13);
            this.LBL_TipoSeleccionado.TabIndex = 43;
            this.LBL_TipoSeleccionado.Text = "Tipo seleccionado:";
            // 
            // TXT_TipoSeleccionado
            // 
            this.TXT_TipoSeleccionado.Location = new System.Drawing.Point(141, 214);
            this.TXT_TipoSeleccionado.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_TipoSeleccionado.Name = "TXT_TipoSeleccionado";
            this.TXT_TipoSeleccionado.Size = new System.Drawing.Size(147, 20);
            this.TXT_TipoSeleccionado.TabIndex = 44;
            this.TXT_TipoSeleccionado.TextChanged += new System.EventHandler(this.TXT_TipoSeleccionado_TextChanged);
            // 
            // LBL_NuevoTipo
            // 
            this.LBL_NuevoTipo.AutoSize = true;
            this.LBL_NuevoTipo.Location = new System.Drawing.Point(327, 55);
            this.LBL_NuevoTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_NuevoTipo.Name = "LBL_NuevoTipo";
            this.LBL_NuevoTipo.Size = new System.Drawing.Size(210, 13);
            this.LBL_NuevoTipo.TabIndex = 45;
            this.LBL_NuevoTipo.Text = "Agregar un nuevo tipo a este antecedente:";
            // 
            // TXT_NuevoTipo
            // 
            this.TXT_NuevoTipo.Location = new System.Drawing.Point(402, 81);
            this.TXT_NuevoTipo.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_NuevoTipo.Name = "TXT_NuevoTipo";
            this.TXT_NuevoTipo.Size = new System.Drawing.Size(135, 20);
            this.TXT_NuevoTipo.TabIndex = 46;
            // 
            // BTN_AgregarTipo
            // 
            this.BTN_AgregarTipo.Location = new System.Drawing.Point(444, 115);
            this.BTN_AgregarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_AgregarTipo.Name = "BTN_AgregarTipo";
            this.BTN_AgregarTipo.Size = new System.Drawing.Size(93, 30);
            this.BTN_AgregarTipo.TabIndex = 47;
            this.BTN_AgregarTipo.Text = "Agregar";
            this.BTN_AgregarTipo.UseVisualStyleBackColor = true;
            this.BTN_AgregarTipo.Click += new System.EventHandler(this.BTN_AgregarTipo_Click);
            // 
            // BTN_EliminarTipo
            // 
            this.BTN_EliminarTipo.Location = new System.Drawing.Point(314, 211);
            this.BTN_EliminarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_EliminarTipo.Name = "BTN_EliminarTipo";
            this.BTN_EliminarTipo.Size = new System.Drawing.Size(90, 24);
            this.BTN_EliminarTipo.TabIndex = 48;
            this.BTN_EliminarTipo.Text = "Eliminar Tipo";
            this.BTN_EliminarTipo.UseVisualStyleBackColor = true;
            this.BTN_EliminarTipo.Click += new System.EventHandler(this.BTN_EliminarTipo_Click);
            // 
            // GB_InfoAnte
            // 
            this.GB_InfoAnte.Controls.Add(this.LBL_Nombre);
            this.GB_InfoAnte.Controls.Add(this.DGV_TipoAnte);
            this.GB_InfoAnte.Controls.Add(this.LBL_TipoClick);
            this.GB_InfoAnte.Controls.Add(this.LBL_TipoSeleccionado);
            this.GB_InfoAnte.Controls.Add(this.TXT_TipoSeleccionado);
            this.GB_InfoAnte.Controls.Add(this.BTN_EliminarTipo);
            this.GB_InfoAnte.Controls.Add(this.TXT_Nombre);
            this.GB_InfoAnte.Controls.Add(this.BTN_AgregarTipo);
            this.GB_InfoAnte.Controls.Add(this.BTN_Modificar);
            this.GB_InfoAnte.Controls.Add(this.BTN_Eliminar);
            this.GB_InfoAnte.Controls.Add(this.LBL_TiposAnte);
            this.GB_InfoAnte.Controls.Add(this.TXT_NuevoTipo);
            this.GB_InfoAnte.Controls.Add(this.LBL_NuevoTipo);
            this.GB_InfoAnte.Location = new System.Drawing.Point(26, 71);
            this.GB_InfoAnte.Name = "GB_InfoAnte";
            this.GB_InfoAnte.Size = new System.Drawing.Size(564, 319);
            this.GB_InfoAnte.TabIndex = 49;
            this.GB_InfoAnte.TabStop = false;
            this.GB_InfoAnte.Text = "Información del Antecedente";
            // 
            // VerAntecedente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 402);
            this.Controls.Add(this.GB_InfoAnte);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.LBL_Antecedente);
            this.Name = "VerAntecedente";
            this.Text = "VerAntecedente";
            this.Load += new System.EventHandler(this.VerAntecedente_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TipoAnte)).EndInit();
            this.GB_InfoAnte.ResumeLayout(false);
            this.GB_InfoAnte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.Label LBL_Antecedente;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.MenuStrip menuStrip2;
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
        private System.Windows.Forms.ToolStripMenuItem salirtoolStripMenuItem;
        private System.Windows.Forms.Label LBL_TiposAnte;
        private System.Windows.Forms.DataGridView DGV_TipoAnte;
        private System.Windows.Forms.Label LBL_TipoClick;
        private System.Windows.Forms.Label LBL_TipoSeleccionado;
        private System.Windows.Forms.TextBox TXT_TipoSeleccionado;
        private System.Windows.Forms.Label LBL_NuevoTipo;
        private System.Windows.Forms.TextBox TXT_NuevoTipo;
        private System.Windows.Forms.Button BTN_AgregarTipo;
        private System.Windows.Forms.Button BTN_EliminarTipo;
        private System.Windows.Forms.GroupBox GB_InfoAnte;
    }
}
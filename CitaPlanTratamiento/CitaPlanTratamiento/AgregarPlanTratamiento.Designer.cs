namespace CitaPlanTratamiento
{
    partial class AgregarPlanTratamiento
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GB_PlanTrata = new System.Windows.Forms.GroupBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.TXT_Observaciones = new System.Windows.Forms.TextBox();
            this.LBL_Observaciones = new System.Windows.Forms.Label();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.TXT_Cedula = new System.Windows.Forms.TextBox();
            this.LBL_Cedula = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LINK_Menu = new System.Windows.Forms.LinkLabel();
            this.LINK_ListaTrata = new System.Windows.Forms.LinkLabel();
            this.LBL_Titulo = new System.Windows.Forms.Label();
            this.GB_PlanTrata.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_PlanTrata
            // 
            this.GB_PlanTrata.Controls.Add(this.BTN_Agregar);
            this.GB_PlanTrata.Controls.Add(this.TXT_Observaciones);
            this.GB_PlanTrata.Controls.Add(this.LBL_Observaciones);
            this.GB_PlanTrata.Controls.Add(this.TXT_Padecimiento);
            this.GB_PlanTrata.Controls.Add(this.LBL_Padecimiento);
            this.GB_PlanTrata.Controls.Add(this.TXT_Cedula);
            this.GB_PlanTrata.Controls.Add(this.LBL_Cedula);
            this.GB_PlanTrata.Location = new System.Drawing.Point(47, 89);
            this.GB_PlanTrata.Name = "GB_PlanTrata";
            this.GB_PlanTrata.Size = new System.Drawing.Size(609, 317);
            this.GB_PlanTrata.TabIndex = 0;
            this.GB_PlanTrata.TabStop = false;
            this.GB_PlanTrata.Text = "Agregar Plan de Tratamiento";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(495, 261);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(98, 39);
            this.BTN_Agregar.TabIndex = 6;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // TXT_Observaciones
            // 
            this.TXT_Observaciones.Location = new System.Drawing.Point(109, 213);
            this.TXT_Observaciones.Name = "TXT_Observaciones";
            this.TXT_Observaciones.Size = new System.Drawing.Size(154, 20);
            this.TXT_Observaciones.TabIndex = 5;
            this.ToolTip1.SetToolTip(this.TXT_Observaciones, "Digite las observaciones asociadas con el plan a seguir");
            // 
            // LBL_Observaciones
            // 
            this.LBL_Observaciones.AutoSize = true;
            this.LBL_Observaciones.Location = new System.Drawing.Point(12, 217);
            this.LBL_Observaciones.Name = "LBL_Observaciones";
            this.LBL_Observaciones.Size = new System.Drawing.Size(78, 13);
            this.LBL_Observaciones.TabIndex = 4;
            this.LBL_Observaciones.Text = "Observaciones";
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(109, 142);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(154, 20);
            this.TXT_Padecimiento.TabIndex = 3;
            this.ToolTip1.SetToolTip(this.TXT_Padecimiento, "Digite el padecimiento actual del paciente");
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(12, 145);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(71, 13);
            this.LBL_Padecimiento.TabIndex = 2;
            this.LBL_Padecimiento.Text = "Padecimiento";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(109, 62);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(154, 20);
            this.TXT_Cedula.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.TXT_Cedula, "Digite el número de cédula del paciente");
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(12, 65);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(40, 13);
            this.LBL_Cedula.TabIndex = 0;
            this.LBL_Cedula.Text = "Cédula";
            // 
            // ToolTip1
            // 
            this.ToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.Location = new System.Drawing.Point(614, 15);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(89, 13);
            this.LINK_Menu.TabIndex = 1;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Al Menú Principal";
            // 
            // LINK_ListaTrata
            // 
            this.LINK_ListaTrata.AutoSize = true;
            this.LINK_ListaTrata.Location = new System.Drawing.Point(551, 48);
            this.LINK_ListaTrata.Name = "LINK_ListaTrata";
            this.LINK_ListaTrata.Size = new System.Drawing.Size(153, 13);
            this.LINK_ListaTrata.TabIndex = 2;
            this.LINK_ListaTrata.TabStop = true;
            this.LINK_ListaTrata.Text = "Lista de Planes de Tratamiento";
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Titulo.Location = new System.Drawing.Point(204, 28);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(277, 33);
            this.LBL_Titulo.TabIndex = 3;
            this.LBL_Titulo.Text = "Plan de Tratamiento";
            // 
            // AgregarPlanTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 433);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.LINK_ListaTrata);
            this.Controls.Add(this.LINK_Menu);
            this.Controls.Add(this.GB_PlanTrata);
            this.Name = "AgregarPlanTratamiento";
            this.Text = "AgregarPlanTratamiento";
            this.GB_PlanTrata.ResumeLayout(false);
            this.GB_PlanTrata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_PlanTrata;
        private System.Windows.Forms.TextBox TXT_Cedula;
        private System.Windows.Forms.Label LBL_Cedula;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Label LBL_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Padecimiento;
        private System.Windows.Forms.TextBox TXT_Observaciones;
        private System.Windows.Forms.Label LBL_Observaciones;
        private System.Windows.Forms.LinkLabel LINK_Menu;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.LinkLabel LINK_ListaTrata;
        private System.Windows.Forms.Label LBL_Titulo;
    }
}


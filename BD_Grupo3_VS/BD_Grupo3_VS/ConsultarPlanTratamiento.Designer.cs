namespace CitaPlanTratamiento
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
            this.LBL_Padecimiento = new System.Windows.Forms.Label();
            this.TXT_Padecimiento = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LINK_Menu
            // 
            this.LINK_Menu.AutoSize = true;
            this.LINK_Menu.Location = new System.Drawing.Point(639, 28);
            this.LINK_Menu.Name = "LINK_Menu";
            this.LINK_Menu.Size = new System.Drawing.Size(89, 13);
            this.LINK_Menu.TabIndex = 0;
            this.LINK_Menu.TabStop = true;
            this.LINK_Menu.Text = "Al Menú Principal";
            // 
            // LINK_AgregaPlan
            // 
            this.LINK_AgregaPlan.AutoSize = true;
            this.LINK_AgregaPlan.Location = new System.Drawing.Point(597, 63);
            this.LINK_AgregaPlan.Name = "LINK_AgregaPlan";
            this.LINK_AgregaPlan.Size = new System.Drawing.Size(142, 13);
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
            this.LBL_Titulo.Location = new System.Drawing.Point(109, 28);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(471, 33);
            this.LBL_Titulo.TabIndex = 2;
            this.LBL_Titulo.Text = "Consulta de Planes de Tratamiento";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(25, 123);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 3;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_Cedula.Location = new System.Drawing.Point(94, 120);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(146, 20);
            this.TXT_Cedula.TabIndex = 4;
            this.toolTip1.SetToolTip(this.TXT_Cedula, "Digite el número de cédula a consultar");
            // 
            // LBL_Padecimiento
            // 
            this.LBL_Padecimiento.AutoSize = true;
            this.LBL_Padecimiento.Location = new System.Drawing.Point(301, 123);
            this.LBL_Padecimiento.Name = "LBL_Padecimiento";
            this.LBL_Padecimiento.Size = new System.Drawing.Size(74, 13);
            this.LBL_Padecimiento.TabIndex = 5;
            this.LBL_Padecimiento.Text = "Padecimiento:";
            // 
            // TXT_Padecimiento
            // 
            this.TXT_Padecimiento.Location = new System.Drawing.Point(399, 120);
            this.TXT_Padecimiento.Name = "TXT_Padecimiento";
            this.TXT_Padecimiento.Size = new System.Drawing.Size(146, 20);
            this.TXT_Padecimiento.TabIndex = 6;
            this.toolTip1.SetToolTip(this.TXT_Padecimiento, "Digite el padecimiento a consultar");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 280);
            this.dataGridView1.TabIndex = 7;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.Location = new System.Drawing.Point(605, 114);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(106, 31);
            this.BTN_Buscar.TabIndex = 8;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // ConsultarPlanTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 470);
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
            this.Name = "ConsultarPlanTratamiento";
            this.Text = "ConsultarPlanTratamiento";
            this.Load += new System.EventHandler(this.ConsultarPlanTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}
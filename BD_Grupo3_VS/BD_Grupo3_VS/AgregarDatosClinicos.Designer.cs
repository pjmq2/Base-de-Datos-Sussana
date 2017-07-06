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
            this.GB_InfoDatosClinicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_InfoDatosClinicos
            // 
            this.GB_InfoDatosClinicos.Controls.Add(this.BTN_Agregar);
            this.GB_InfoDatosClinicos.Controls.Add(this.TXT_Cedula);
            this.GB_InfoDatosClinicos.Controls.Add(this.LBL_Dato);
            this.GB_InfoDatosClinicos.Controls.Add(this.LBL_Cedula);
            this.GB_InfoDatosClinicos.Controls.Add(this.TXT_Dato);
            this.GB_InfoDatosClinicos.Location = new System.Drawing.Point(45, 107);
            this.GB_InfoDatosClinicos.Name = "GB_InfoDatosClinicos";
            this.GB_InfoDatosClinicos.Size = new System.Drawing.Size(486, 279);
            this.GB_InfoDatosClinicos.TabIndex = 14;
            this.GB_InfoDatosClinicos.TabStop = false;
            this.GB_InfoDatosClinicos.Text = "Detellas de los datos clínicos";
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(367, 211);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(90, 35);
            this.BTN_Agregar.TabIndex = 23;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            // 
            // TXT_Cedula
            // 
            this.TXT_Cedula.Location = new System.Drawing.Point(170, 54);
            this.TXT_Cedula.Name = "TXT_Cedula";
            this.TXT_Cedula.Size = new System.Drawing.Size(154, 20);
            this.TXT_Cedula.TabIndex = 8;
            // 
            // LBL_Dato
            // 
            this.LBL_Dato.AutoSize = true;
            this.LBL_Dato.Location = new System.Drawing.Point(24, 119);
            this.LBL_Dato.Name = "LBL_Dato";
            this.LBL_Dato.Size = new System.Drawing.Size(69, 13);
            this.LBL_Dato.TabIndex = 9;
            this.LBL_Dato.Text = "Dato Clínico:";
            // 
            // LBL_Cedula
            // 
            this.LBL_Cedula.AutoSize = true;
            this.LBL_Cedula.Location = new System.Drawing.Point(24, 54);
            this.LBL_Cedula.Name = "LBL_Cedula";
            this.LBL_Cedula.Size = new System.Drawing.Size(43, 13);
            this.LBL_Cedula.TabIndex = 6;
            this.LBL_Cedula.Text = "Cédula:";
            // 
            // TXT_Dato
            // 
            this.TXT_Dato.Location = new System.Drawing.Point(170, 116);
            this.TXT_Dato.Name = "TXT_Dato";
            this.TXT_Dato.Size = new System.Drawing.Size(154, 20);
            this.TXT_Dato.TabIndex = 10;
            // 
            // LBL_Titulo
            // 
            this.LBL_Titulo.AutoSize = true;
            this.LBL_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_Titulo.Location = new System.Drawing.Point(140, 50);
            this.LBL_Titulo.Name = "LBL_Titulo";
            this.LBL_Titulo.Size = new System.Drawing.Size(203, 33);
            this.LBL_Titulo.TabIndex = 15;
            this.LBL_Titulo.Text = "Datos Clínicos";
            // 
            // AgregarDatosClinicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 417);
            this.Controls.Add(this.LBL_Titulo);
            this.Controls.Add(this.GB_InfoDatosClinicos);
            this.Name = "AgregarDatosClinicos";
            this.Text = "AgregarDatosClinicos";
            this.GB_InfoDatosClinicos.ResumeLayout(false);
            this.GB_InfoDatosClinicos.PerformLayout();
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
    }
}
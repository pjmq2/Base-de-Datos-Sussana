﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class ConsultarPlanTratamiento : Form

    {

        PlanTratamiento planT;
        public ConsultarPlanTratamiento()
        {
            InitializeComponent();
            planT = new PlanTratamiento();
        }

        private void ConsultarPlanTratamiento_Load(object sender, EventArgs e)
        {

        }

        private void llenaTabla(DataGridView dgv, string porCedula, string porPadecimiento)
        {
            DataTable tabla = planT.consultarPlanTratamiento(porCedula, porPadecimiento);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = tabla;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgv.DataSource = bSource;

            for(int i = 0; i<dataGridView1.ColumnCount; i++)
            {
                dgv.Columns[i].Width = 110;
            }
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if(TXT_Cedula.Text != "" && TXT_Padecimiento.Text == "")
            {
                llenaTabla(dataGridView1, TXT_Cedula.Text, null);
            }
            else if (TXT_Cedula.Text == "" && TXT_Padecimiento.Text != "")
            {
                llenaTabla(dataGridView1, null, TXT_Padecimiento.Text);
            }
            else if (TXT_Cedula.Text == "" && TXT_Padecimiento.Text == "")
            {
                llenaTabla(dataGridView1, null, null);
            }
            else if (TXT_Cedula.Text != "" && TXT_Padecimiento.Text != "")
            {
                llenaTabla(dataGridView1, TXT_Cedula.Text, TXT_Padecimiento.Text);
            }
        }

        private void LINK_AgregaPlan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarPlanTratamiento agrega = new AgregarPlanTratamiento();
            agrega.Show();
            this.Hide();
        }

        /*             A partir de aqui empiezan los metodos para la cinta del menu  */
        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPaciente paciente = new ConsultarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void crearPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPaciente paciente = new AgregarPaciente();
            paciente.Show();
            this.Hide();
        }

        private void avanzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfig menu = new MenuConfig();
            menu.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show("Seguro que desea Salir ?", "Cerrar la aplicacion", botones);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                //Aun no cierra todo el programa
            }
        }

        /*             Hasta aqui las instrucciones de la cinta del menu  */
    }
}

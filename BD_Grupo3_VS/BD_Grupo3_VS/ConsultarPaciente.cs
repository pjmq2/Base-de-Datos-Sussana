﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Grupo3_VS
{
    public partial class ConsultarPaciente : Form
    {
        Paciente paciente;
        public ConsultarPaciente()
        {
            InitializeComponent();
            paciente = new Paciente();
        }

        private void llenarTabla(DataGridView dataGridView, string filtroNombre, string filtroGeneral)
        {

            DataTable tabla = paciente.obtenerPacientes(filtroNombre, filtroGeneral);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < DGV_Pacientes.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            if (TXT_FiltroNombre.Text == "" && TXT_FiltroGeneral.Text == "")
            {
                llenarTabla(DGV_Pacientes, null, null);
            }
            else if (TXT_FiltroNombre.Text != "" && TXT_FiltroGeneral.Text == "")
            {
                llenarTabla(DGV_Pacientes, TXT_FiltroNombre.Text, null);
            }
            else if (TXT_FiltroNombre.Text == "" && TXT_FiltroGeneral.Text != "")
            {
                llenarTabla(DGV_Pacientes, null, TXT_FiltroGeneral.Text);
            }
            else if (TXT_FiltroNombre.Text != "" && TXT_FiltroGeneral.Text != "")
            {
                llenarTabla(DGV_Pacientes, TXT_FiltroNombre.Text, TXT_FiltroGeneral.Text);
            }
        }

        private void ConsultarPaciente_Load(object sender, EventArgs e)
        {
            llenarTabla(DGV_Pacientes, null, null);
            llenarCombobox(CB_Nombre);
        }

        private void LINK_AgregarPaciente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgregarPaciente agregarP = new AgregarPaciente();
            agregarP.Show();
            this.Hide();

        }

        private void llenarCombobox(ComboBox combobox)
        {
            SqlDataReader datos = paciente.obtenerListaNombresPacientes();
            if (datos != null)
            {
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                combobox.Items.Clear();
            }
            combobox.SelectedItem = 0;
        }

        private void CB_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTabla(DGV_Pacientes,CB_Nombre.Text,null);
        }

        private void DGV_Pacientes_CurrentCellChanged_1(object sender, EventArgs e)
        {
            string nombre = "";
            if (DGV_Pacientes.SelectedRows.Count != 0)
            {
                //int numero = DGV_Pacientes.CurrentCellAddress.Y;
                //nombre = DGV_Pacientes[1,2].Value.ToString();
                DataGridViewRow row = DGV_Pacientes.CurrentRow;
                nombre = row.Cells[0].Value.ToString();
                TXT_FiltroNombre.Text = nombre;
                MessageBox.Show(nombre,null);
            }
            
        }
    }
}

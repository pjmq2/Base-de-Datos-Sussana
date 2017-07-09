using System;
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
    public partial class MenuConfig : Form
    {
        public MenuConfig()
        {
            InitializeComponent();
        }

        private void BTN_CrearEjercicio_Click(object sender, EventArgs e)
        {
            AgregarEjercicio ejercicio = new AgregarEjercicio();
            ejercicio.Show();
            this.Hide();
        }

        private void BTN_BuscarEjercicio_Click(object sender, EventArgs e)
        {
            BuscarEjercicios ejercicio = new BuscarEjercicios();
            ejercicio.Show();
            this.Hide();
        }

        private void BTN_BuscarMaterial_Click(object sender, EventArgs e)
        {
            BuscarMateriales material = new BuscarMateriales();
            material.Show();
            this.Hide();
        }

        private void BTN_CrearTecnica_Click(object sender, EventArgs e)
        {
            AgregarTecnica tecnica = new AgregarTecnica();
            tecnica.Show();
            this.Hide();
        }

        private void BTN_BuscarTecnica_Click(object sender, EventArgs e)
        {
            BuscarTecnicas tecnica = new BuscarTecnicas();
            tecnica.Show();
            this.Hide();
        }

        private void BTN_CrearMaterial_Click(object sender, EventArgs e)
        {
            AgregarMaterial material = new AgregarMaterial();
            material.Show();
            this.Hide();
        }

        private void BTN_CrearAntecediente_Click(object sender, EventArgs e)
        {
            AgregarAntecedentes antecedente = new AgregarAntecedentes();
            antecedente.Show();
            this.Hide();
        }

        private void BTN_BuscarAntecediente_Click(object sender, EventArgs e)
        {
            BuscarAntecedentes antecedente = new BuscarAntecedentes();
            antecedente.Show();
            this.Hide();
        }

        private void MenuConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

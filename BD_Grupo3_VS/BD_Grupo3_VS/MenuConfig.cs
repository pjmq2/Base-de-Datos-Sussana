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
            ConsultarEjercicios ejercicio = new ConsultarEjercicios();
            ejercicio.Show();
            this.Hide();
        }

        private void BTN_BuscarMaterial_Click(object sender, EventArgs e)
        {
            VerMaterial material = new VerMaterial("hola");
            material.Show();
            this.Hide();
        }
    }
}

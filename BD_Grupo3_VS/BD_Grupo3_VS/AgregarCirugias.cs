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
    public partial class AgregarCirugias : Form
    {
        Paciente paciente;
        public AgregarCirugias()
        {
            InitializeComponent();
            paciente = new Paciente();

        }

        private void BTN_AgregarCirugia_Click(object sender, EventArgs e)
        {
            int resultado = paciente.agregarCirugia(TXT_Cedula.Text, TXT_Cirugia.Text);

            //resultado es 0 cuando se pudo agregar un antecedente al paciente con éxito
            if (resultado == 0)
            {
                MessageBox.Show("¡La cirugía ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                if (resultado == 2627)
                {
                    MessageBox.Show("Ya existe este tipo de antecedente asociado al nombre del antecedente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resultado + ": Algo ha fallado.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

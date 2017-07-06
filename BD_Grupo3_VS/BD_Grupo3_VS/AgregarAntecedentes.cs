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
    public partial class AgregarAntecedentes : Form
    {
        Paciente paciente;
        public AgregarAntecedentes()
        {
            InitializeComponent();
            paciente = new Paciente();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            int resultado = paciente.agregarAntecedente(TXT_Cedula.Text, TXT_NombreAnte.Text, TXT_Descripcion.Text);

            //resultado es 0 cuando se pudo agregar un antecedente al paciente con éxito
            if (resultado == 0)
            {
                MessageBox.Show("¡El antecedente ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);

                //insertamos el tipo de antecedente
                int resultado2 = paciente.agregarTipoAntecedente(TXT_NombreAnte.Text, TXT_TipoAnt.Text);
                //resultado es 0 cuando se pudo agregar un antecedente al paciente con éxito
                if (resultado2 == 0)
                {
                    MessageBox.Show("¡El tipo de antecedente ha sido agregado exitosamente!", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.None);
                    TXT_Cedula.Clear();
                    TXT_NombreAnte.Clear();
                    TXT_Descripcion.Clear();
                    TXT_TipoAnt.Clear();
                }
                else
                {
                    if (resultado2 == 2627)
                    {
                        MessageBox.Show("Ya existe este tipo de antecedente asociado al nombre del antecedente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(resultado2 + ": Algo ha fallado.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (resultado == 2627)
                {
                    MessageBox.Show("Ya existe este antecedente asociada a ese paciente", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(" Ha ocurrido un error al intentar agregar el antecendente. \n -Recuerde que los campos de Cédula, Nombre y Tipo " +
                        "no pueden estar vacíos.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}


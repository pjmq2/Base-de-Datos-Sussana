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
    public partial class VerPlanEjercicios : Form
    {
        PlanDeEjercicios planEjercicios;
        public VerPlanEjercicios(string cedula, string padecimiento, string nivel)
        {
            InitializeComponent();
            planEjercicios = new PlanDeEjercicios();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4EyberNavia
{
    public partial class MenúEscenarios : Form
    {
        public MenúEscenarios()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas Salir del programa (a)", "consulta",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Escenario1 fomr = new Escenario1();
            fomr.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Escenario2 fomr = new Escenario2();
            fomr.Show();

            this.Close();
        }
    }
}

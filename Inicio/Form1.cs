using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class frmInicio : Form
    {
        int Contador = 5;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tiInicio_Tick(object sender, EventArgs e)
        {
            if (Contador == 1)
            {
                tiInicio.Stop();
                MessageBox.Show("ejecutando programas");
                Application.Exit();
            }
            else
            {
                Contador = Contador - 1;
                lblContador.Text = Contador.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tiInicio.Stop();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ofdRutas.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lstProgramas.Items.RemoveAt(lstProgramas.SelectedIndex);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void cdmReanudar_Click(object sender, EventArgs e)
        {
            tiInicio.Start();
        }
    }
}

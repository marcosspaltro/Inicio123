using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Inicio
{
    public partial class frmInicio : Form
    {

        int Contador = 5;
        public frmInicio()
        {
            InitializeComponent();

            TextReader lector = new StreamReader("Memoria.txt");
            string[] leer = File.ReadAllLines("Memoria.txt");
            foreach (string item in leer) 
            {
                lstProgramas.Items.Add(item);
            }
                lector.Close();

            var dir = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + Path.DirectorySeparatorChar + Application.ProductName + ".lnk";
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
                StreamReader lector = new StreamReader("Memoria.txt");
                foreach (object lista in lstProgramas.Items)
                System.Diagnostics.Process.Start(lista.ToString());
                lector.Close();
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
            tiInicio.Stop();
            ofdRutas.ShowDialog();
            nvalista();
        }
        private void nvalista()
        {
            TextWriter nvoarchivo = new StreamWriter("Memoria.txt");
            foreach (object lista in lstProgramas.Items)
            nvoarchivo.WriteLine(lista);
            tiInicio.Start();
            nvoarchivo.Close();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstProgramas.SelectedIndex != -1)
            lstProgramas.Items.RemoveAt(lstProgramas.SelectedIndex);
            nvalista();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            lstProgramas.Items.Add(ofdRutas.FileName);
        }

        private void cdmReanudar_Click(object sender, EventArgs e)
        {
            tiInicio.Start();
        }

        private void lstProgramas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

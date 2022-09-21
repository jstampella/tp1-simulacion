using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1_simulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int cant = Convert.ToInt32((numYisla.Value / 50) * (numXisla.Value / 50));
            lbCasilleros.Text = "Casilleros:" + cant;
            //numRatones.Maximum = cant;
            //numQuesos.Minimum = Convert.ToInt32(numRatones.Value / 2);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int nX = Convert.ToInt32(numXisla.Value);
            int nY = Convert.ToInt32(numYisla.Value);
            int ratones = Convert.ToInt32(numRatones.Value);
            int quesos = Convert.ToInt32(numQuesos.Value);
            bool hembra = cbHembra.Checked;
            int gatos = Convert.ToInt32(numGatos.Value);
            Simulacion sm = new Simulacion(nX,nY, quesos,ratones, hembra,gatos);
            this.Hide();
            sm.ShowDialog();
            this.Show();
        }

        private void numRatones_ValueChanged(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32((numYisla.Value / 50) * (numXisla.Value / 50));
            if(numRatones.Value > cant)
            {
                MessageBox.Show("Maximo "+cant+" Sobrepoblacion","Ratones",MessageBoxButtons.OK);
                ((NumericUpDown)sender).Value = cant;
            }
            numQuesos.Value = Convert.ToInt32(numRatones.Value / 2);
            //numQuesos.Maximum = numRatones.Value;
        }

        private void numXisla_KeyPress(object sender, KeyPressEventArgs e)
        {
            changeIsla();
        }

        private void changeIsla()
        {
            int cant = Convert.ToInt32((numYisla.Value / 50) * (numXisla.Value / 50));
            lbCasilleros.Text = "Casilleros:" + cant;
        }

        private void numQuesos_ValueChanged(object sender, EventArgs e)
        {
            if (numQuesos.Value > Convert.ToInt32(numRatones.Value / 2))
            {
                MessageBox.Show("Maximo la mitad de los Ratones", "Queso", MessageBoxButtons.OK);
                ((NumericUpDown)sender).Value = Convert.ToInt32(numRatones.Value / 2);
            }
            else if (numQuesos.Value < Convert.ToInt32(numRatones.Value / 4))
            {
                MessageBox.Show("minimo 25% de los ratones", "Queso", MessageBoxButtons.OK);
                ((NumericUpDown)sender).Value = Convert.ToInt32(numRatones.Value / 4);
            }
        }

        private void numQuesos_KeyPress(object sender, KeyPressEventArgs e)
        {
            int valor = Convert.ToInt32(((NumericUpDown)sender).Value);
            if (valor < Convert.ToInt32(numRatones.Value / 2))
            {
                MessageBox.Show("Minimo la mitad de los Ratones", "Queso", MessageBoxButtons.OK);
                e.Handled = true;
            }
            else if (valor > Convert.ToInt32(numRatones.Value))
            {
                MessageBox.Show("Maximo la cant Ratones", "Queso", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void numXisla_Validating(object sender, CancelEventArgs e)
        {
            if (((NumericUpDown)sender).Value < 100)
            {
                MessageBox.Show("Minimo 100", "Isla", MessageBoxButtons.OK);
                ((NumericUpDown)sender).Value = 100;
            }
            changeIsla();
        }

        private void numXisla_ValueChanged(object sender, EventArgs e)
        {
            changeIsla();
        }
    }
}

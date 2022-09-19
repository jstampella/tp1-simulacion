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
    public partial class HistorialAll : Form
    {
        Isla isll;
        public HistorialAll(ref Isla islaSimul)
        {
            InitializeComponent();
            isll = islaSimul;
        }

        private void dgHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string arg = dgHistorial.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if(arg == "VER")
            {
                FormHistorial fm = new FormHistorial();
                Animal nn = null;
                int nro = Convert.ToInt32(dgHistorial.Rows[e.RowIndex].Cells[0].Value);
                if(isll is IslaPredador islP)
                {
                    if(lblTitulo.Text == "RATONES")
                    {
                        nn = islP.VerRoedoresNro(nro);
                    }
                    else
                    {
                        nn = islP.VerPredadorNro(nro);
                    }  
                }
                else
                {
                    if (lblTitulo.Text == "RATONES")
                    {
                        nn = isll.VerRoedoresNro(nro);
                    }
                }

                fm.lbNro.Text = "Nro:"+nn.Nro.ToString();
                fm.lbVida.Text = nn.DiasDeVida.ToString();
                fm.lbEstado.Text = nn.Estado.ToString();
                fm.lblTipo.Text = nn.Soy().ToString();
                fm.dgHistorial.Rows.Clear();
                Historial[] hist = nn.GetHistorial();

                foreach (Historial item in hist)
                {
                    string[] rw = { item.Posicion.ToString(), item.DiasSinComer.ToString(), item.Avance.ToString(), item.Dia.ToString(), item.Paso.ToString() };
                    fm.dgHistorial.Rows.Add(rw);
                }
                fm.ShowDialog();
            }
        }
    }
}

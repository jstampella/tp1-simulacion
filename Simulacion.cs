using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1_simulacion
{
    public partial class Simulacion : Form
    {
        private Point islaDimension;
        private Isla islaSimul;
        private int tamanioRaton = 50;
        private int ratonInitial;
        private int quesosInitial;
        Thread t;
        private HistorialAll hisAll;
        public Simulacion(int medWidth,int medHeight,int queso, int raton,bool hembra=false,int gatos=0)
        {
            t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(200);
            this.Hide();
            InitializeComponent();
            //establece valores para optimizar el parpadeo de los controles
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
            //calcular columnas y filas
            this.islaDimension.X = medWidth / tamanioRaton;
            this.islaDimension.Y = medHeight / tamanioRaton;

            //asignar tamanio al mapa
            mapa.Width = medWidth;
            mapa.Height = medHeight;

            //Restablecemos los valores estaticos para controlar los objectos creados
            Animal.NroStatic = 0;
            Alimento.NroStatic = 0;


            this.ratonInitial = raton;
            this.quesosInitial = queso;

            if (gatos > 0)
            {
                islaSimul = new IslaPredador(islaDimension, raton, queso, hembra, gatos);
            }
            else
            {
                islaSimul = new Isla(islaDimension, raton, queso, hembra);
                pictureBox1.Visible = false;
                lblGatos.Visible = false;
                gMuertos.Visible = false;
            }

            //damos forma al mapa para centrarlo al agua
            ResizeMapa();
        }

        public void StartForm()
        {
            Application.Run(new Loading());
        }

        //funcion para renderizar mapa
        #region resizeMapa
        private void ResizeMapa()
        {
            int X = mapa.Location.X;
            int Y = mapa.Location.Y;
            if (panelContenedor.Width > mapa.Width) { X = panelContenedor.Width / 2 - (mapa.Width / 2 - 20); }
            if (panelContenedor.Height > mapa.Height) { Y = panelContenedor.Height / 2 - (mapa.Height / 2 - 20); }
            mapa.Location = new Point(X,Y);
        }
        #endregion

        #region Evita el parpadeo de los graficos
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        #endregion
        
        private void Simulacion_Shown(object sender, EventArgs e)
        {
            t.Abort();
            this.Show();
        }


        #region funcion para cambiar los tamanios de los iconos
        private void ModificarTamanio()
        {
            Point cuadrado = new Point(mapa.Size.Width / islaDimension.X, mapa.Size.Height / islaDimension.Y);
            int index = 0;
            for (int i = 0; i < mapa.Controls.Count-1; i++)
            {
                if(mapa.Controls[i] is PictureBox panel)
                {
                    int index2 = 0;
                    for (int j = i;j < mapa.Controls.Count; j++)
                    {
                        if (mapa.Controls[j] is PictureBox panel2)
                        {
                            if (panel != panel2 && panel.Left == panel2.Left && panel.Top == panel2.Top)
                            {
                                panel.Size = new Size(cuadrado.X - 10, cuadrado.Y - 10);
                                index2++;
                                mapa.Controls.SetChildIndex(panel, index + 1);
                                mapa.Controls.SetChildIndex(panel2, index2 + 2);
                                panel2.Left += 10;
                                panel2.Top += 10;
                                panel2.Size = new Size(cuadrado.X - (15 * index2), cuadrado.Y - (15 * index2));
                            }
                        }
                    }
                }
                index++;
            }
        }
        #endregion

        #region Agregar Predador
        private void AgregarPredador()
        {
            if (islaSimul is IslaPredador uspr)
            {
                for (int i = 0; i < uspr.CantPredador; i++)
                {
                    Animal nn = (Animal)uspr.VerPredador(i);
                    string name_control = "predador-" + nn.Nro;
                    NavigationControl Npanel;
                    Control[] findControls = mapa.Controls.Find(name_control, false);
                    if (findControls.Length > 0)
                    {
                        Npanel = (NavigationControl)findControls[0];
                    }
                    else
                    {
                        Npanel = new NavigationControl();
                        Npanel.BackColor = Color.Transparent;
                        Npanel.Name = "predador-" + nn.Nro;
                        Npanel.Image = Properties.Resources.cat;
                        Npanel.SizeMode = PictureBoxSizeMode.StretchImage;
                        Npanel.Click += new System.EventHandler(this.panel_Click);
                        Npanel.Cursor = Cursors.Hand;
                        mapa.Controls.Add(Npanel);
                    }
                    if (nn.Estado == EEstadoVida.Vivo)
                    {
                        MoverElemento(nn.Posicion.X, nn.Posicion.Y, Npanel);
                    }
                    else
                    {
                        mapa.Controls.Remove(Npanel);
                    }
                }
            }
        }
        #endregion

        #region Agregar Ratones
        private void AgregarAnimales()
        {
            for (int i = 0; i < islaSimul.CantRoedores; i++)
            {
                Animal nn = (Animal)islaSimul.VerRoedores(i);
                string name_control = "raton-" + nn.Nro;
                NavigationControl Npanel;
                Control[] findControls = mapa.Controls.Find(name_control, false);
                if (findControls.Length > 0)
                {
                    Npanel = (NavigationControl)findControls[0];
                }
                else
                {
                    Npanel = new NavigationControl();
                    Npanel.BackColor = Color.Transparent;
                    Npanel.Name = "raton-" + nn.Nro;
                    Npanel.SizeMode = PictureBoxSizeMode.StretchImage;
                    Npanel.Click += new System.EventHandler(this.panel_Click);
                    Npanel.Cursor = Cursors.Hand;
                    if (nn is Hembra)
                        Npanel.Image = Properties.Resources.ratonHembra;
                    else
                        Npanel.Image = Properties.Resources.raton;
                    mapa.Controls.Add(Npanel);
                }
                if (nn.Estado == EEstadoVida.Vivo)
                {
                    if(nn is Hembra nnH)
                    {
                        if (nnH.DiasGestacion>1)
                        {
                            //listBox3.Items.Add("Animal: " + nn.Soy() + " nro:" + nn.Nro);
                            //listBox3.Items.Add("DiaDeGestacion: "+nnH.DiasGestacion);
                            //listBox3.Items.Add("Cantidad de bebes:" + nnH.CantBebes);
                            //listBox3.Items.Add("--------------------");
                        }
                    }
                }

                if (nn.Estado == EEstadoVida.Vivo)
                {
                    MoverElemento(nn.Posicion.X, nn.Posicion.Y, Npanel);
                }
                else { mapa.Controls.Remove(Npanel); }
            }
        }
        #endregion

        #region Agregar Queso
        private void AgregarQueso()
        {
            for (int i = 0; i < islaSimul.CantAlimentos; i++)
            {
                Alimento nn = (Alimento)islaSimul.VerAlimento(i);
                if (!nn.Vacio())
                {
                    string name_control = "queso-" + nn.Nro;
                    NavigationControl Npanel;
                    Control[] findControls = mapa.Controls.Find(name_control, false);
                    if (findControls.Length > 0)
                    {
                        Npanel = (NavigationControl)findControls[0];
                    }
                    else
                    {
                        Npanel = new NavigationControl();
                        Npanel.BackColor = Color.Transparent;
                        Npanel.Name = "queso-" + nn.Nro;
                        Npanel.SizeMode = PictureBoxSizeMode.StretchImage;
                        Npanel.Image = Properties.Resources.queso;
                        Npanel.Click += new System.EventHandler(this.panel_Click);
                        Npanel.Cursor = Cursors.Hand;
                        mapa.Controls.Add(Npanel);
                    }
                    if (nn.Porcion < 2)
                        Npanel.Image = Properties.Resources.quesoMedio;
                    else Npanel.Image = Properties.Resources.queso;
                    MoverElemento(nn.Posicion.X, nn.Posicion.Y, Npanel);
                }
                else
                {
                    string name_control = "queso-" + nn.Nro;
                    NavigationControl Npanel;
                    Control[] findControls = mapa.Controls.Find(name_control, false);
                    if (findControls.Length > 0)
                    {
                        Npanel = (NavigationControl)findControls[0];
                        mapa.Controls.Remove(Npanel);
                    }
                }
            }
        }
        #endregion

        #region Mover Elemento en el mapa
        private void MoverElemento(int posX, int posY, PictureBox pl)
        {
            Point cuadrado = new Point(mapa.Size.Width / islaDimension.X, mapa.Size.Height / islaDimension.Y);
            if (pl != null)
            {
                pl.Size = new Size(cuadrado.X - 10, cuadrado.Y - 10);
                //mapa.Controls.Add(pl);
                pl.Left = (cuadrado.X * posX) + 5;
                pl.Top = (cuadrado.Y * posY) + 5;
            }
        }
        #endregion

        #region Boton btnAvanzar Click
        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool estado = islaSimul.AvanzarPaso();
            lblRatones.Text = (islaSimul.CantRoedores - islaSimul.CantRoedoresMuertos()).ToString();
            lblBebes.Text = "+" + (islaSimul.CantRoedores - ratonInitial).ToString();
            lblAlimentos.Text = (islaSimul.CantAlimentos - islaSimul.CantAlimentosNoDisponible()).ToString();
            lbqMas.Text = "+"+(islaSimul.CantAlimentos - quesosInitial).ToString();
            rMuertos.Text = islaSimul.CantRoedoresMuertos().ToString();
            qMuerto.Text = islaSimul.CantAlimentosNoDisponible().ToString();
            if (islaSimul is IslaPredador isl)
            {
                gMuertos.Text = isl.CantPredadorMuertos().ToString();
                lblGatos.Text = (isl.CantPredador- isl.CantPredadorMuertos()).ToString();
            }
            int diasp = islaSimul.Pasos/10;
            int pasosp = islaSimul.Pasos%10;
            lblPasos.Text = "Pasos:" + pasosp+" Dias:"+diasp;
            if (cbGraficar.Checked)
            {
                AgregarAnimales();
                AgregarPredador();
                AgregarQueso();
                ModificarTamanio();
            }
            if (!estado)
            {
                string mess = "Se termino el juego (" + islaSimul.Estado + ")";
                if ((islaSimul.CantRoedores - islaSimul.CantRoedoresMuertos()) > 600)
                    mess = "Se termino el juego (" + islaSimul.Estado + ") - Imposible renderizar!!!!";
                else
                {
                    AgregarAnimales();
                    AgregarPredador();
                    AgregarQueso();
                    ModificarTamanio();
                }
                btnAvanzar.Enabled = false;
                btnAvanzartimer.Enabled = false;
                avanzarTimer.Stop();
                MessageBox.Show(mess,"FINALIZO SIMULACION",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (avanzarTimer.Enabled)
            {
                int cantidad = islaSimul.CantAlimentos + islaSimul.CantRoedores;
                if (cbGraficar.Checked && cantidad <200)
                {
                    avanzarTimer.Interval = 500;
                }
                else
                {
                    avanzarTimer.Interval = 50;
                }
            }
            this.Cursor = Cursors.Default;
        }
        #endregion

        private void panelContenedor_Resize(object sender, EventArgs e)
        {
            ResizeMapa();
        }

        private void avanzarTimer_Tick(object sender, EventArgs e)
        {
            btnAvanzar.PerformClick();
        }


        #region Boton AvanzarTimer click
        private void btnAvanzartimer_Click(object sender, EventArgs e)
        {
            if (avanzarTimer.Enabled)
            {
                avanzarTimer.Stop();
                btnAvanzartimer.Text = "Simular";
            }
            else
            {
                if(cbGraficar.Checked)
                {
                    avanzarTimer.Interval = 500;
                }
                else {
                    avanzarTimer.Interval = 50;
                }
                avanzarTimer.Start();
                btnAvanzartimer.Text = "Parar";
            }
                
        }
        #endregion

        private void Simulacion_Load(object sender, EventArgs e)
        {
            lblAlimentos.Text = islaSimul.CantAlimentos.ToString();
            lblRatones.Text = islaSimul.CantRoedores.ToString();
            lblDimension.Text = "Col:" + islaDimension.X + " Row:" + islaDimension.Y + " Cas:" + (islaDimension.X * islaDimension.Y);
            if (islaSimul is IslaPredador isp)
                lblGatos.Text = isp.CantPredador.ToString();
            AgregarAnimales();
            AgregarPredador();
            AgregarQueso();
            ModificarTamanio();
        }

        #region Click en los iconos del mapa
        private void panel_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string nombre = pb.Name;
            Animal nn=null;
            Alimento al =null;
            FormHistorial fm = new FormHistorial();
            string[] palabras = nombre.Split('-');
            switch (palabras[0])
            {
                case "queso":
                    al = islaSimul.VerAlimentoNro(Convert.ToInt32(palabras[1]));
                    break;

                case "raton":
                    nn = islaSimul.VerRoedoresNro(Convert.ToInt32(palabras[1]));  
                    break;
                case "predador":
                    nn = ((IslaPredador)islaSimul).VerPredadorNro(Convert.ToInt32(palabras[1]));
                    break;
            }
            if (nn !=null)
            {
                fm.lbNro.Text = "ID:" + nn.Nro.ToString();
                fm.lbVida.Text = nn.DiasDeVida.ToString();
                fm.lbEstado.Text = nn.Estado.ToString();
                fm.lblTipo.Text = nn.Soy().ToString();
                fm.dgHistorial.Rows.Clear();
                Historial[] hist = nn.GetHistorial();

                foreach (Historial item in hist)
                {
                    string[] rw = { item.Posicion.ToString(),item.DiasSinComer.ToString(),item.Avance.ToString(),item.Dia.ToString(), item.Paso.ToString() };
                    fm.dgHistorial.Rows.Add(rw);
                }
                fm.ShowDialog();
              
            }
            if (al != null)
            {
                MessageBox.Show("Posicion:" + al.Posicion +" Porcion:" + al.Porcion,"QUESO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Click imagen Gato
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(islaSimul is IslaPredador islP)
            {
                hisAll = new HistorialAll(ref islaSimul);
                hisAll.Text = "Listado de Gatos";
                hisAll.dgHistorial.Rows.Clear();
                hisAll.dgHistorial.Columns.Clear();
                hisAll.dgHistorial.Columns.Add("id", "ID");
                hisAll.dgHistorial.Columns.Add("nro", "Nro");
                hisAll.dgHistorial.Columns[1].Visible = false;
                hisAll.dgHistorial.Columns.Add("posicion", "Posicion");
                hisAll.dgHistorial.Columns.Add("diasVida", "Dias s/Vida");
                hisAll.dgHistorial.Columns.Add("diasComer", "Dias s/Comer");
                hisAll.dgHistorial.Columns.Add("sexo", "Sexo");
                hisAll.dgHistorial.Columns.Add("muertes", "C. Muertes");
                hisAll.dgHistorial.Columns.Add("estado", "Estado");
                hisAll.dgHistorial.Columns.Add("historial", "Historial");
                hisAll.lblCant.Text = "Total:"+islP.CantPredador.ToString();
                hisAll.lblTitulo.Text = "GATOS";
                hisAll.lbMacho.Text = "M:"+islP.CantPredador.ToString();
                hisAll.lbHembra.Visible = false;
                for (int i = 0; i < islP.CantPredador; i++)
                {
                    Gato item = (Gato)islP.VerPredador(i);
                    string[] rw = { i.ToString(),item.Nro.ToString(), item.Posicion.ToString(),item.DiasDeVida.ToString(),item.DiasSinComer.ToString(), item.Sexo().ToString(),item.Muertes.ToString(), item.Estado.ToString(),"VER" };
                    hisAll.dgHistorial.Rows.Add(rw);
                }
                hisAll.ShowDialog();
            }
        }
        #endregion

        #region Click imagen Queso
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            hisAll = new HistorialAll(ref islaSimul);
            hisAll.Text = "Listado de Queso";
            hisAll.dgHistorial.Rows.Clear();
            hisAll.dgHistorial.Columns.Clear();
            hisAll.dgHistorial.Columns.Add("nro", "Nro");
            hisAll.dgHistorial.Columns.Add("id", "ID");
            hisAll.dgHistorial.Columns[1].Visible = false;
            hisAll.dgHistorial.Columns.Add("posicion", "Posicion");
            hisAll.dgHistorial.Columns.Add("porcion", "Porcion");
            hisAll.dgHistorial.Columns.Add("estado", "Estado");
            hisAll.lblCant.Text = islaSimul.CantAlimentos.ToString();
            hisAll.lbHembra.Visible = false;
            hisAll.lbMacho.Visible = false;
            hisAll.lblTitulo.Text = "QUESOS";
            for (int i = 0; i < islaSimul.CantAlimentos; i++)
            {
                Alimento item = islaSimul.VerAlimento(i);
                string[] rw = { i.ToString(), item.Nro.ToString(), item.Posicion.ToString(), item.Porcion.ToString(), item.Vacio() ?"Inactivo":"Activo" };
                hisAll.dgHistorial.Rows.Add(rw);
            }
            hisAll.ShowDialog();
        }
        #endregion

        #region Click imagen Raton
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            hisAll = new HistorialAll(ref islaSimul);
            hisAll.Text = "Listado de Ratones";
            hisAll.dgHistorial.Columns[1].Visible = false;
            hisAll.dgHistorial.Rows.Clear();
            hisAll.lblCant.Text = "Total:"+islaSimul.CantRoedores.ToString();
            hisAll.lblTitulo.Text = "RATONES";
            int cantMac = 0;
            int cantHem = 0;
            for (int i = 0; i < islaSimul.CantRoedores; i++)
            {
                Animal item = islaSimul.VerRoedores(i);
                if (item.Sexo() == ESexo.Macho)
                    cantMac++;
                else cantHem++;
                string[] rw = {i.ToString(),item.Nro.ToString(), item.Posicion.ToString(), item.DiasDeVida.ToString(), item.DiasSinComer.ToString(),item.Sexo().ToString(), item.Estado.ToString(), "VER" };
                hisAll.dgHistorial.Rows.Add(rw);
            }
            hisAll.lbMacho.Text = "M:"+cantMac.ToString();
            hisAll.lbHembra.Text = "H:"+cantHem.ToString();
            hisAll.ShowDialog();
        }
        #endregion

    }

    #region PicturBox Transparente
    public class NavigationControl : PictureBox
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            for (int index = this.Parent.Controls.Count - 1; index > this.Parent.Controls.GetChildIndex(this); --index)
            {
                var ctl = this.Parent.Controls[index] as PictureBox;
                if (ctl == null) continue;
                var clip = ctl.RectangleToClient(this.RectangleToScreen(this.DisplayRectangle));
                clip.Intersect(ctl.DisplayRectangle);
                if (clip.Width == 0 || clip.Height == 0) continue;
                var save = e.Graphics.Save();
                e.Graphics.TranslateTransform(ctl.Left - this.Left, ctl.Top - this.Top);
                using (var rgn = new Region(clip))
                {
                    e.Graphics.Clip = rgn;
                    InvokePaintBackground(ctl, e);
                    InvokePaint(ctl, e);
                }
                e.Graphics.Restore(save);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TRANSPARENT = 0x20;
                var cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                return cp;
            }
        }
    }
    #endregion
}

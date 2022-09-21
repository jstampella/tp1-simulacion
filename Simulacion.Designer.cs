namespace tp1_simulacion
{
    partial class Simulacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.lblRatones = new System.Windows.Forms.Label();
            this.lblAlimentos = new System.Windows.Forms.Label();
            this.lblGatos = new System.Windows.Forms.Label();
            this.lblBebes = new System.Windows.Forms.Label();
            this.lbqMas = new System.Windows.Forms.Label();
            this.lblDimension = new System.Windows.Forms.Label();
            this.btnAvanzartimer = new System.Windows.Forms.Button();
            this.lblPasos = new System.Windows.Forms.Label();
            this.avanzarTimer = new System.Windows.Forms.Timer(this.components);
            this.gMuertos = new System.Windows.Forms.Label();
            this.qMuerto = new System.Windows.Forms.Label();
            this.rMuertos = new System.Windows.Forms.Label();
            this.cbGraficar = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.mapa = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(14, 12);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(122, 32);
            this.btnAvanzar.TabIndex = 2;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // lblRatones
            // 
            this.lblRatones.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRatones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatones.Location = new System.Drawing.Point(0, 0);
            this.lblRatones.Name = "lblRatones";
            this.lblRatones.Size = new System.Drawing.Size(91, 25);
            this.lblRatones.TabIndex = 3;
            this.lblRatones.Text = "0";
            this.lblRatones.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAlimentos
            // 
            this.lblAlimentos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentos.Location = new System.Drawing.Point(0, 0);
            this.lblAlimentos.Name = "lblAlimentos";
            this.lblAlimentos.Size = new System.Drawing.Size(93, 25);
            this.lblAlimentos.TabIndex = 4;
            this.lblAlimentos.Text = "0";
            this.lblAlimentos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblGatos
            // 
            this.lblGatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGatos.Location = new System.Drawing.Point(0, 0);
            this.lblGatos.Name = "lblGatos";
            this.lblGatos.Size = new System.Drawing.Size(92, 25);
            this.lblGatos.TabIndex = 5;
            this.lblGatos.Text = "0";
            this.lblGatos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBebes
            // 
            this.lblBebes.AutoSize = true;
            this.lblBebes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBebes.Location = new System.Drawing.Point(65, 28);
            this.lblBebes.Name = "lblBebes";
            this.lblBebes.Size = new System.Drawing.Size(15, 16);
            this.lblBebes.TabIndex = 4;
            this.lblBebes.Text = "0";
            // 
            // lbqMas
            // 
            this.lbqMas.AutoSize = true;
            this.lbqMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbqMas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbqMas.Location = new System.Drawing.Point(68, 28);
            this.lbqMas.Name = "lbqMas";
            this.lbqMas.Size = new System.Drawing.Size(15, 16);
            this.lbqMas.TabIndex = 5;
            this.lbqMas.Text = "0";
            // 
            // lblDimension
            // 
            this.lblDimension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDimension.Location = new System.Drawing.Point(240, 44);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(181, 25);
            this.lblDimension.TabIndex = 10;
            this.lblDimension.Text = "colXrow";
            this.lblDimension.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAvanzartimer
            // 
            this.btnAvanzartimer.Location = new System.Drawing.Point(14, 79);
            this.btnAvanzartimer.Name = "btnAvanzartimer";
            this.btnAvanzartimer.Size = new System.Drawing.Size(122, 34);
            this.btnAvanzartimer.TabIndex = 11;
            this.btnAvanzartimer.Text = "Simular";
            this.btnAvanzartimer.UseVisualStyleBackColor = true;
            this.btnAvanzartimer.Click += new System.EventHandler(this.btnAvanzartimer_Click);
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasos.Location = new System.Drawing.Point(235, 15);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(186, 29);
            this.lblPasos.TabIndex = 13;
            this.lblPasos.Text = "Pasos:0 Dias:0";
            // 
            // avanzarTimer
            // 
            this.avanzarTimer.Interval = 500;
            this.avanzarTimer.Tick += new System.EventHandler(this.avanzarTimer_Tick);
            // 
            // gMuertos
            // 
            this.gMuertos.AutoSize = true;
            this.gMuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gMuertos.ForeColor = System.Drawing.Color.Red;
            this.gMuertos.Location = new System.Drawing.Point(60, 52);
            this.gMuertos.Name = "gMuertos";
            this.gMuertos.Size = new System.Drawing.Size(29, 20);
            this.gMuertos.TabIndex = 14;
            this.gMuertos.Text = "00";
            // 
            // qMuerto
            // 
            this.qMuerto.AutoSize = true;
            this.qMuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qMuerto.ForeColor = System.Drawing.Color.Red;
            this.qMuerto.Location = new System.Drawing.Point(61, 52);
            this.qMuerto.Name = "qMuerto";
            this.qMuerto.Size = new System.Drawing.Size(29, 20);
            this.qMuerto.TabIndex = 15;
            this.qMuerto.Text = "00";
            // 
            // rMuertos
            // 
            this.rMuertos.AutoSize = true;
            this.rMuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMuertos.ForeColor = System.Drawing.Color.Red;
            this.rMuertos.Location = new System.Drawing.Point(59, 53);
            this.rMuertos.Name = "rMuertos";
            this.rMuertos.Size = new System.Drawing.Size(29, 20);
            this.rMuertos.TabIndex = 16;
            this.rMuertos.Text = "00";
            // 
            // cbGraficar
            // 
            this.cbGraficar.AutoSize = true;
            this.cbGraficar.Location = new System.Drawing.Point(43, 53);
            this.cbGraficar.Name = "cbGraficar";
            this.cbGraficar.Size = new System.Drawing.Size(76, 20);
            this.cbGraficar.TabIndex = 19;
            this.cbGraficar.Text = "Graficar";
            this.cbGraficar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(511, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 85);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblGatos);
            this.panel1.Controls.Add(this.gMuertos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 79);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::tp1_simulacion.Properties.Resources.cat;
            this.pictureBox1.Location = new System.Drawing.Point(5, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.lblAlimentos);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbqMas);
            this.panel2.Controls.Add(this.qMuerto);
            this.panel2.Location = new System.Drawing.Point(101, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 79);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::tp1_simulacion.Properties.Resources.queso;
            this.pictureBox2.Location = new System.Drawing.Point(5, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.lblRatones);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblBebes);
            this.panel3.Controls.Add(this.rMuertos);
            this.panel3.Location = new System.Drawing.Point(200, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 79);
            this.panel3.TabIndex = 24;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::tp1_simulacion.Properties.Resources.raton;
            this.pictureBox3.Location = new System.Drawing.Point(3, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.BackgroundImage = global::tp1_simulacion.Properties.Resources.sea_water;
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenedor.Controls.Add(this.mapa);
            this.panelContenedor.Location = new System.Drawing.Point(12, 123);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(797, 362);
            this.panelContenedor.TabIndex = 12;
            this.panelContenedor.Resize += new System.EventHandler(this.panelContenedor_Resize);
            // 
            // mapa
            // 
            this.mapa.BackColor = System.Drawing.Color.LimeGreen;
            this.mapa.BackgroundImage = global::tp1_simulacion.Properties.Resources.background;
            this.mapa.Location = new System.Drawing.Point(30, 61);
            this.mapa.Name = "mapa";
            this.mapa.Size = new System.Drawing.Size(733, 249);
            this.mapa.TabIndex = 0;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 497);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbGraficar);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnAvanzartimer);
            this.Controls.Add(this.lblDimension);
            this.Controls.Add(this.btnAvanzar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Simulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Simulacion_Load);
            this.Shown += new System.EventHandler(this.Simulacion_Shown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Label lblRatones;
        private System.Windows.Forms.Label lblAlimentos;
        private System.Windows.Forms.Panel mapa;
        private System.Windows.Forms.Label lblGatos;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Button btnAvanzartimer;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Timer avanzarTimer;
        private System.Windows.Forms.Label gMuertos;
        private System.Windows.Forms.Label rMuertos;
        private System.Windows.Forms.Label qMuerto;
        private System.Windows.Forms.Label lblBebes;
        private System.Windows.Forms.Label lbqMas;
        private System.Windows.Forms.CheckBox cbGraficar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
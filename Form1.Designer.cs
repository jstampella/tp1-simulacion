namespace tp1_simulacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numYisla = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCasilleros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numXisla = new System.Windows.Forms.NumericUpDown();
            this.numRatones = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbHembra = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numQuesos = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numGatos = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numYisla)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXisla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuesos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGatos)).BeginInit();
            this.SuspendLayout();
            // 
            // numYisla
            // 
            this.numYisla.Location = new System.Drawing.Point(79, 56);
            this.numYisla.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numYisla.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYisla.Name = "numYisla";
            this.numYisla.Size = new System.Drawing.Size(69, 22);
            this.numYisla.TabIndex = 1;
            this.numYisla.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numYisla.ValueChanged += new System.EventHandler(this.numXisla_ValueChanged);
            this.numYisla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numXisla_KeyPress);
            this.numYisla.Validating += new System.ComponentModel.CancelEventHandler(this.numXisla_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCasilleros);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numXisla);
            this.groupBox1.Controls.Add(this.numYisla);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ISLA";
            // 
            // lbCasilleros
            // 
            this.lbCasilleros.Location = new System.Drawing.Point(9, 88);
            this.lbCasilleros.Name = "lbCasilleros";
            this.lbCasilleros.Size = new System.Drawing.Size(139, 23);
            this.lbCasilleros.TabIndex = 4;
            this.lbCasilleros.Text = "casilleros: 0";
            this.lbCasilleros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ancho mts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Largo mts.";
            // 
            // numXisla
            // 
            this.numXisla.Location = new System.Drawing.Point(80, 22);
            this.numXisla.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numXisla.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numXisla.Name = "numXisla";
            this.numXisla.Size = new System.Drawing.Size(69, 22);
            this.numXisla.TabIndex = 0;
            this.numXisla.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numXisla.ValueChanged += new System.EventHandler(this.numXisla_ValueChanged);
            this.numXisla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numXisla_KeyPress);
            this.numXisla.Validating += new System.ComponentModel.CancelEventHandler(this.numXisla_Validating);
            // 
            // numRatones
            // 
            this.numRatones.Location = new System.Drawing.Point(76, 31);
            this.numRatones.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numRatones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatones.Name = "numRatones";
            this.numRatones.Size = new System.Drawing.Size(69, 22);
            this.numRatones.TabIndex = 3;
            this.numRatones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRatones.ValueChanged += new System.EventHandler(this.numRatones_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHembra);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numRatones);
            this.groupBox2.Location = new System.Drawing.Point(10, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ratones";
            // 
            // cbHembra
            // 
            this.cbHembra.AutoSize = true;
            this.cbHembra.Location = new System.Drawing.Point(36, 59);
            this.cbHembra.Name = "cbHembra";
            this.cbHembra.Size = new System.Drawing.Size(85, 20);
            this.cbHembra.TabIndex = 4;
            this.cbHembra.Text = "Hembras";
            this.cbHembra.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numQuesos);
            this.groupBox3.Location = new System.Drawing.Point(174, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 67);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quesos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad:";
            // 
            // numQuesos
            // 
            this.numQuesos.Location = new System.Drawing.Point(76, 31);
            this.numQuesos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuesos.Name = "numQuesos";
            this.numQuesos.Size = new System.Drawing.Size(69, 22);
            this.numQuesos.TabIndex = 5;
            this.numQuesos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuesos.ValueChanged += new System.EventHandler(this.numQuesos_ValueChanged);
            this.numQuesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numQuesos_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.numGatos);
            this.groupBox4.Location = new System.Drawing.Point(174, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 67);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gatos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // numGatos
            // 
            this.numGatos.Location = new System.Drawing.Point(76, 31);
            this.numGatos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numGatos.Name = "numGatos";
            this.numGatos.Size = new System.Drawing.Size(69, 22);
            this.numGatos.TabIndex = 6;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.LightCoral;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCrear.Location = new System.Drawing.Point(174, 159);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(158, 62);
            this.btnCrear.TabIndex = 7;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 231);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Isla - Simulacion";
            ((System.ComponentModel.ISupportInitialize)(this.numYisla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXisla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRatones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuesos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrear;
        protected System.Windows.Forms.NumericUpDown numYisla;
        protected System.Windows.Forms.NumericUpDown numXisla;
        protected System.Windows.Forms.NumericUpDown numRatones;
        protected System.Windows.Forms.CheckBox cbHembra;
        protected System.Windows.Forms.NumericUpDown numQuesos;
        protected System.Windows.Forms.NumericUpDown numGatos;
        private System.Windows.Forms.Label lbCasilleros;
    }
}


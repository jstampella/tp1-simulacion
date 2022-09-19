namespace tp1_simulacion
{
    partial class FormHistorial
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
            this.dgHistorial = new System.Windows.Forms.DataGridView();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasSinComer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNro = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbVida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHistorial
            // 
            this.dgHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.diasSinComer,
            this.Avance,
            this.Dia});
            this.dgHistorial.Location = new System.Drawing.Point(12, 113);
            this.dgHistorial.Name = "dgHistorial";
            this.dgHistorial.RowHeadersWidth = 51;
            this.dgHistorial.RowTemplate.Height = 24;
            this.dgHistorial.Size = new System.Drawing.Size(666, 325);
            this.dgHistorial.TabIndex = 0;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.MinimumWidth = 6;
            this.Posicion.Name = "Posicion";
            // 
            // diasSinComer
            // 
            this.diasSinComer.HeaderText = "Dias sin Comer";
            this.diasSinComer.MinimumWidth = 6;
            this.diasSinComer.Name = "diasSinComer";
            // 
            // Avance
            // 
            this.Avance.HeaderText = "Avance";
            this.Avance.MinimumWidth = 6;
            this.Avance.Name = "Avance";
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dias de vida:";
            // 
            // lbNro
            // 
            this.lbNro.AutoSize = true;
            this.lbNro.Location = new System.Drawing.Point(50, 80);
            this.lbNro.Name = "lbNro";
            this.lbNro.Size = new System.Drawing.Size(14, 16);
            this.lbNro.TabIndex = 4;
            this.lbNro.Text = "0";
            this.lbNro.UseMnemonic = false;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(378, 80);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(32, 16);
            this.lbEstado.TabIndex = 5;
            this.lbEstado.Text = "vivo";
            // 
            // lbVida
            // 
            this.lbVida.AutoSize = true;
            this.lbVida.Location = new System.Drawing.Point(620, 80);
            this.lbVida.Name = "lbVida";
            this.lbVida.Size = new System.Drawing.Size(14, 16);
            this.lbVida.TabIndex = 6;
            this.lbVida.Text = "0";
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.lbVida);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbNro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgHistorial);
            this.Name = "FormHistorial";
            this.Text = "FormHistorial";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasSinComer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        public System.Windows.Forms.DataGridView dgHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbNro;
        public System.Windows.Forms.Label lbEstado;
        public System.Windows.Forms.Label lbVida;
    }
}
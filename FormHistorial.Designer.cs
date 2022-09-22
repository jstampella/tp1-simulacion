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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNro = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbVida = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasSinComer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Dia,
            this.Paso,
            this.estado});
            this.dgHistorial.Location = new System.Drawing.Point(12, 113);
            this.dgHistorial.Name = "dgHistorial";
            this.dgHistorial.ReadOnly = true;
            this.dgHistorial.RowHeadersVisible = false;
            this.dgHistorial.RowHeadersWidth = 51;
            this.dgHistorial.RowTemplate.Height = 24;
            this.dgHistorial.Size = new System.Drawing.Size(666, 325);
            this.dgHistorial.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(500, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dias de vida:";
            // 
            // lbNro
            // 
            this.lbNro.AutoSize = true;
            this.lbNro.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNro.Location = new System.Drawing.Point(397, 13);
            this.lbNro.Name = "lbNro";
            this.lbNro.Size = new System.Drawing.Size(26, 27);
            this.lbNro.TabIndex = 4;
            this.lbNro.Text = "0";
            this.lbNro.UseMnemonic = false;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(75, 80);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(42, 20);
            this.lbEstado.TabIndex = 5;
            this.lbEstado.Text = "vivo";
            // 
            // lbVida
            // 
            this.lbVida.AutoSize = true;
            this.lbVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVida.Location = new System.Drawing.Point(628, 78);
            this.lbVida.Name = "lbVida";
            this.lbVida.Size = new System.Drawing.Size(19, 20);
            this.lbVida.TabIndex = 6;
            this.lbVida.Text = "0";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(238, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(117, 34);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "label4";
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.MinimumWidth = 6;
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            // 
            // diasSinComer
            // 
            this.diasSinComer.HeaderText = "Dias sin Comer";
            this.diasSinComer.MinimumWidth = 6;
            this.diasSinComer.Name = "diasSinComer";
            this.diasSinComer.ReadOnly = true;
            // 
            // Avance
            // 
            this.Avance.HeaderText = "Avance";
            this.Avance.MinimumWidth = 6;
            this.Avance.Name = "Avance";
            this.Avance.ReadOnly = true;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // Paso
            // 
            this.Paso.HeaderText = "Paso";
            this.Paso.MinimumWidth = 6;
            this.Paso.Name = "Paso";
            this.Paso.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lbVida);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbNro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgHistorial);
            this.Name = "FormHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgHistorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbNro;
        public System.Windows.Forms.Label lbEstado;
        public System.Windows.Forms.Label lbVida;
        public System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasSinComer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paso;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}
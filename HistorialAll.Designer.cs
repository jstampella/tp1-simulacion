namespace tp1_simulacion
{
    partial class HistorialAll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgHistorial = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasDeVida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasSinComer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historial = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Nro,
            this.Posicion,
            this.DiasDeVida,
            this.DiasSinComer,
            this.Estado,
            this.historial});
            this.dgHistorial.Location = new System.Drawing.Point(12, 66);
            this.dgHistorial.Name = "dgHistorial";
            this.dgHistorial.ReadOnly = true;
            this.dgHistorial.RowHeadersWidth = 51;
            this.dgHistorial.RowTemplate.Height = 24;
            this.dgHistorial.Size = new System.Drawing.Size(776, 372);
            this.dgHistorial.TabIndex = 1;
            this.dgHistorial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistorial_CellDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(134, 34);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Ratones";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCant.Location = new System.Drawing.Point(686, 13);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(32, 34);
            this.lblCant.TabIndex = 3;
            this.lblCant.Text = "0";
            // 
            // Nro
            // 
            this.Nro.FillWeight = 50F;
            this.Nro.HeaderText = "Nro";
            this.Nro.MinimumWidth = 6;
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.MinimumWidth = 6;
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            // 
            // DiasDeVida
            // 
            this.DiasDeVida.HeaderText = "Dia d/Vida";
            this.DiasDeVida.MinimumWidth = 6;
            this.DiasDeVida.Name = "DiasDeVida";
            this.DiasDeVida.ReadOnly = true;
            // 
            // DiasSinComer
            // 
            this.DiasSinComer.HeaderText = "Dias S/comer";
            this.DiasSinComer.MinimumWidth = 6;
            this.DiasSinComer.Name = "DiasSinComer";
            this.DiasSinComer.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // historial
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.historial.DefaultCellStyle = dataGridViewCellStyle1;
            this.historial.HeaderText = "Historial";
            this.historial.MinimumWidth = 6;
            this.historial.Name = "historial";
            this.historial.ReadOnly = true;
            this.historial.ToolTipText = "ver historial de movimientos";
            // 
            // HistorialAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgHistorial);
            this.Name = "HistorialAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HistorialAll";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgHistorial;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasDeVida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasSinComer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn historial;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgHistorial = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lbHembra = new System.Windows.Forms.Label();
            this.lbMacho = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasDeVida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasSinComer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgHistorial
            // 
            this.dgHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro,
            this.id,
            this.Posicion,
            this.DiasDeVida,
            this.DiasSinComer,
            this.Sexo,
            this.Estado,
            this.historial});
            this.dgHistorial.Location = new System.Drawing.Point(12, 66);
            this.dgHistorial.Name = "dgHistorial";
            this.dgHistorial.ReadOnly = true;
            this.dgHistorial.RowHeadersVisible = false;
            this.dgHistorial.RowHeadersWidth = 51;
            this.dgHistorial.RowTemplate.Height = 24;
            this.dgHistorial.Size = new System.Drawing.Size(776, 372);
            this.dgHistorial.TabIndex = 1;
            this.dgHistorial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistorial_CellDoubleClick);
            this.dgHistorial.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgHistorial_SortCompare);
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
            this.lblCant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCant.Font = new System.Drawing.Font("Monospac821 BT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCant.Location = new System.Drawing.Point(354, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(38, 41);
            this.lblCant.TabIndex = 3;
            this.lblCant.Text = "0";
            this.lblCant.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbHembra
            // 
            this.lbHembra.AutoSize = true;
            this.lbHembra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHembra.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHembra.ForeColor = System.Drawing.Color.DeepPink;
            this.lbHembra.Location = new System.Drawing.Point(278, 0);
            this.lbHembra.Name = "lbHembra";
            this.lbHembra.Size = new System.Drawing.Size(32, 41);
            this.lbHembra.TabIndex = 4;
            this.lbHembra.Text = "0";
            this.lbHembra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMacho
            // 
            this.lbMacho.AutoSize = true;
            this.lbMacho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMacho.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMacho.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbMacho.Location = new System.Drawing.Point(316, 0);
            this.lbMacho.Name = "lbMacho";
            this.lbMacho.Size = new System.Drawing.Size(32, 41);
            this.lbMacho.TabIndex = 5;
            this.lbMacho.Text = "0";
            this.lbMacho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblCant);
            this.flowLayoutPanel1.Controls.Add(this.lbMacho);
            this.flowLayoutPanel1.Controls.Add(this.lbHembra);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(393, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(395, 43);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // nro
            // 
            this.nro.FillWeight = 50F;
            this.nro.HeaderText = "nro";
            this.nro.MinimumWidth = 6;
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            // 
            // id
            // 
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.historial.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgHistorial);
            this.Name = "HistorialAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HistorialAll";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorial)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgHistorial;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblCant;
        public System.Windows.Forms.Label lbHembra;
        public System.Windows.Forms.Label lbMacho;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasDeVida;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasSinComer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn historial;
    }
}
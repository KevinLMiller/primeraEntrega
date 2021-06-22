namespace primeraEntrega
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
            this.cboTipoEntrada = new System.Windows.Forms.ComboBox();
            this.cboTipoVisita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbSinGuia = new System.Windows.Forms.RadioButton();
            this.rdbConGuia = new System.Windows.Forms.RadioButton();
            this.dgvTarifa = new System.Windows.Forms.DataGridView();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadEntradas = new System.Windows.Forms.TextBox();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DetalleCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoEntrada
            // 
            this.cboTipoEntrada.FormattingEnabled = true;
            this.cboTipoEntrada.Location = new System.Drawing.Point(119, 31);
            this.cboTipoEntrada.Name = "cboTipoEntrada";
            this.cboTipoEntrada.Size = new System.Drawing.Size(121, 21);
            this.cboTipoEntrada.TabIndex = 0;
            // 
            // cboTipoVisita
            // 
            this.cboTipoVisita.FormattingEnabled = true;
            this.cboTipoVisita.Location = new System.Drawing.Point(119, 68);
            this.cboTipoVisita.Name = "cboTipoVisita";
            this.cboTipoVisita.Size = new System.Drawing.Size(121, 21);
            this.cboTipoVisita.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Visita";
            // 
            // rdbSinGuia
            // 
            this.rdbSinGuia.AutoSize = true;
            this.rdbSinGuia.Location = new System.Drawing.Point(18, 106);
            this.rdbSinGuia.Name = "rdbSinGuia";
            this.rdbSinGuia.Size = new System.Drawing.Size(65, 17);
            this.rdbSinGuia.TabIndex = 4;
            this.rdbSinGuia.TabStop = true;
            this.rdbSinGuia.Text = "Sin Guia";
            this.rdbSinGuia.UseVisualStyleBackColor = true;
            // 
            // rdbConGuia
            // 
            this.rdbConGuia.AutoSize = true;
            this.rdbConGuia.Location = new System.Drawing.Point(89, 106);
            this.rdbConGuia.Name = "rdbConGuia";
            this.rdbConGuia.Size = new System.Drawing.Size(69, 17);
            this.rdbConGuia.TabIndex = 5;
            this.rdbConGuia.TabStop = true;
            this.rdbConGuia.Text = "Con Guia";
            this.rdbConGuia.UseVisualStyleBackColor = true;
            // 
            // dgvTarifa
            // 
            this.dgvTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoEntrada,
            this.TipoVisita,
            this.Guia,
            this.Monto});
            this.dgvTarifa.Location = new System.Drawing.Point(63, 182);
            this.dgvTarifa.Name = "dgvTarifa";
            this.dgvTarifa.Size = new System.Drawing.Size(458, 71);
            this.dgvTarifa.TabIndex = 6;
            this.dgvTarifa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifa_CellContentClick);
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.HeaderText = "Tipo Entrada";
            this.TipoEntrada.Name = "TipoEntrada";
            // 
            // TipoVisita
            // 
            this.TipoVisita.HeaderText = "Tipo Visita";
            this.TipoVisita.Name = "TipoVisita";
            // 
            // Guia
            // 
            this.Guia.HeaderText = "Guia S/N";
            this.Guia.Name = "Guia";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTipoEntrada);
            this.groupBox1.Controls.Add(this.rdbConGuia);
            this.groupBox1.Controls.Add(this.cboTipoVisita);
            this.groupBox1.Controls.Add(this.rdbSinGuia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(63, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad de Entradas";
            // 
            // txtCantidadEntradas
            // 
            this.txtCantidadEntradas.Location = new System.Drawing.Point(191, 281);
            this.txtCantidadEntradas.Name = "txtCantidadEntradas";
            this.txtCantidadEntradas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadEntradas.TabIndex = 9;
            // 
            // btnCantidad
            // 
            this.btnCantidad.Location = new System.Drawing.Point(335, 279);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(105, 23);
            this.btnCantidad.TabIndex = 10;
            this.btnCantidad.Text = "Confirmar Cantidad";
            this.btnCantidad.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleCantidad,
            this.MontoEntrada,
            this.MontoTotal});
            this.dataGridView1.Location = new System.Drawing.Point(63, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 70);
            this.dataGridView1.TabIndex = 11;
            // 
            // DetalleCantidad
            // 
            this.DetalleCantidad.HeaderText = "Cantidad";
            this.DetalleCantidad.Name = "DetalleCantidad";
            // 
            // MontoEntrada
            // 
            this.MontoEntrada.HeaderText = "Monto por Entrada";
            this.MontoEntrada.Name = "MontoEntrada";
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total ";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Location = new System.Drawing.Point(81, 431);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(140, 23);
            this.btnConfirmarVenta.TabIndex = 12;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCantidad);
            this.Controls.Add(this.txtCantidadEntradas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTarifa);
            this.Name = "Form1";
            this.Text = "Registrar Venta Entradas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoEntrada;
        private System.Windows.Forms.ComboBox cboTipoVisita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbSinGuia;
        private System.Windows.Forms.RadioButton rdbConGuia;
        private System.Windows.Forms.DataGridView dgvTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadEntradas;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.Button btnConfirmarVenta;
    }
}


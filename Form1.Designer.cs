namespace CAFETERIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbProducto = new ComboBox();
            dgvPedidos = new DataGridView();
            txtPrecio = new TextBox();
            chkParaLlevar = new CheckBox();
            nudCantidad = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnVaciar = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(133, 31);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(173, 28);
            cmbProducto.TabIndex = 0;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(327, 48);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(520, 168);
            dgvPedidos.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(133, 75);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(173, 27);
            txtPrecio.TabIndex = 2;
            // 
            // chkParaLlevar
            // 
            chkParaLlevar.AutoSize = true;
            chkParaLlevar.Location = new Point(12, 178);
            chkParaLlevar.Name = "chkParaLlevar";
            chkParaLlevar.Size = new Size(222, 24);
            chkParaLlevar.TabIndex = 3;
            chkParaLlevar.Text = "Para llevar (+ $5 por pedido)";
            chkParaLlevar.UseVisualStyleBackColor = true;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(133, 123);
            nudCantidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(173, 27);
            nudCantidad.TabIndex = 4;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "Producto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 6;
            label2.Text = "Precio Unitario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(327, 25);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 8;
            label4.Text = "Pedidos Registrados";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 222);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(123, 222);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(232, 222);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(94, 29);
            btnVaciar.TabIndex = 11;
            btnVaciar.Text = "Vaciar";
            btnVaciar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(693, 226);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 314);
            Controls.Add(lblTotal);
            Controls.Add(btnVaciar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudCantidad);
            Controls.Add(chkParaLlevar);
            Controls.Add(txtPrecio);
            Controls.Add(dgvPedidos);
            Controls.Add(cmbProducto);
            Name = "Form1";
            Text = "Pedidos Cafeteria";
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProducto;
        private DataGridView dgvPedidos;
        private TextBox txtPrecio;
        private CheckBox chkParaLlevar;
        private NumericUpDown nudCantidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnVaciar;
        private Label lblTotal;
    }
}

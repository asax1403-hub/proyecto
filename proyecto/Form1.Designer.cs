namespace proyecto
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
            lblTitulo = new Label();
            lblMesa = new Label();
            cmbMesa = new ComboBox();
            lblProducto = new Label();
            txtProducto = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            dgvPedidos = new DataGridView();
            colMesa = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnCobrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(260, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(188, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Restaurante";
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Location = new Point(52, 92);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(101, 15);
            lblMesa.TabIndex = 1;
            lblMesa.Text = "Número de mesa:";
            // 
            // cmbMesa
            // 
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(191, 92);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(127, 23);
            cmbMesa.TabIndex = 2;
            cmbMesa.SelectedIndexChanged += cmbMesa_SelectedIndexChanged;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(72, 145);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(191, 137);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(127, 23);
            txtProducto.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(72, 191);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(191, 188);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(127, 23);
            txtPrecio.TabIndex = 6;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { colMesa, colProducto, colPrecio });
            dgvPedidos.Location = new Point(52, 234);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(459, 150);
            dgvPedidos.TabIndex = 7;
            // 
            // colMesa
            // 
            colMesa.HeaderText = "Mesa";
            colMesa.Name = "colMesa";
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(72, 407);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total: $0.00";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(357, 187);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(191, 407);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar pedido";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(349, 407);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(117, 23);
            btnCobrar.TabIndex = 11;
            btnCobrar.Text = "Cobrar y liberar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCobrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTotal);
            Controls.Add(dgvPedidos);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Controls.Add(cmbMesa);
            Controls.Add(lblMesa);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblMesa;
        private ComboBox cmbMesa;
        private Label lblProducto;
        private TextBox txtProducto;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private DataGridView dgvPedidos;
        private Label lblTotal;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnCobrar;
        private DataGridViewTextBoxColumn colMesa;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colPrecio;
    }
}

namespace View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTitulo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCategoria = new TextBox();
            txtAutor = new TextBox();
            txtPrecio = new TextBox();
            txtEditorial = new TextBox();
            txtCantidad = new TextBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            panel3 = new Panel();
            dgvLibros = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            dgvLibros.CellClick += dgvLibros_CellClick;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(251, 251, 251);
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Librería el Saber";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 100);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.80029F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.5499268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.53835F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7206955F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.8538351F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1157742F));
            tableLayoutPanel1.Controls.Add(txtTitulo, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 1);
            tableLayoutPanel1.Controls.Add(label6, 4, 0);
            tableLayoutPanel1.Controls.Add(label7, 4, 1);
            tableLayoutPanel1.Controls.Add(txtCategoria, 1, 1);
            tableLayoutPanel1.Controls.Add(txtAutor, 3, 0);
            tableLayoutPanel1.Controls.Add(txtPrecio, 3, 1);
            tableLayoutPanel1.Controls.Add(txtEditorial, 5, 0);
            tableLayoutPanel1.Controls.Add(txtCantidad, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(723, 163);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.Menu;
            txtTitulo.Location = new Point(130, 32);
            txtTitulo.Margin = new Padding(3, 32, 3, 3);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(141, 23);
            txtTitulo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 35);
            label2.Margin = new Padding(50, 35, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 0;
            label2.Text = "Título:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 116);
            label3.Margin = new Padding(50, 35, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 0;
            label3.Text = "Categoría:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(279, 35);
            label4.Margin = new Padding(5, 35, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 0;
            label4.Text = "Autor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(279, 116);
            label5.Margin = new Padding(5, 35, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 0;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(503, 35);
            label6.Margin = new Padding(5, 35, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 17);
            label6.TabIndex = 0;
            label6.Text = "Editorial:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(503, 116);
            label7.Margin = new Padding(5, 35, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 0;
            label7.Text = "Cantidad:";
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = SystemColors.Menu;
            txtCategoria.Location = new Point(130, 113);
            txtCategoria.Margin = new Padding(3, 32, 3, 3);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(141, 23);
            txtCategoria.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.BackColor = SystemColors.Menu;
            txtAutor.Location = new Point(338, 32);
            txtAutor.Margin = new Padding(3, 32, 3, 3);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(141, 23);
            txtAutor.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Menu;
            txtPrecio.Location = new Point(338, 113);
            txtPrecio.Margin = new Padding(3, 32, 3, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(141, 23);
            txtPrecio.TabIndex = 0;
            // 
            // txtEditorial
            // 
            txtEditorial.BackColor = SystemColors.Menu;
            txtEditorial.Location = new Point(579, 32);
            txtEditorial.Margin = new Padding(3, 32, 3, 3);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(141, 23);
            txtEditorial.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.Menu;
            txtCantidad.Location = new Point(579, 113);
            txtCantidad.Margin = new Padding(3, 32, 3, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(141, 23);
            txtCantidad.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(723, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 163);
            panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(9, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(180, 132);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnEliminar, 1, 1);
            tableLayoutPanel2.Controls.Add(btnBuscar, 0, 1);
            tableLayoutPanel2.Controls.Add(btnActualizar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(174, 110);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(251, 251, 251);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.TopCenter;
            btnEliminar.Location = new Point(90, 58);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(0, 3, 0, 0);
            btnEliminar.Size = new Size(81, 49);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SteelBlue;
            btnBuscar.Dock = DockStyle.Fill;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(251, 251, 251);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.TopCenter;
            btnBuscar.Location = new Point(3, 58);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Padding = new Padding(0, 3, 0, 0);
            btnBuscar.Size = new Size(81, 49);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.SteelBlue;
            btnActualizar.Dock = DockStyle.Fill;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.FromArgb(251, 251, 251);
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.TopCenter;
            btnActualizar.Location = new Point(90, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Padding = new Padding(0, 3, 0, 0);
            btnActualizar.Size = new Size(81, 49);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.BottomCenter;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(251, 251, 251);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(3, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 3, 0, 0);
            btnGuardar.Size = new Size(81, 49);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvLibros);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 263);
            panel3.Name = "panel3";
            panel3.Size = new Size(923, 225);
            panel3.TabIndex = 4;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Dock = DockStyle.Fill;
            dgvLibros.Location = new Point(0, 0);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(923, 225);
            dgvLibros.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(923, 488);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTitulo;
        private TextBox txtCategoria;
        private TextBox txtAutor;
        private TextBox txtPrecio;
        private TextBox txtEditorial;
        private TextBox txtCantidad;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnActualizar;
        private DataGridView dgvLibros;
    }
}

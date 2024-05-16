namespace FranMotors
{
    partial class ProductosView
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            tbPrecio = new TextBox();
            label4 = new Label();
            tbStock = new TextBox();
            label3 = new Label();
            tbNombreProducto = new TextBox();
            label2 = new Label();
            btnLimpiar = new Button();
            IdProducto = new Label();
            panel1 = new Panel();
            dgProductos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(588, 3);
            label1.Name = "label1";
            label1.Size = new Size(265, 59);
            label1.TabIndex = 2;
            label1.Text = "Productos";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GrayText;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(26, 32, 40);
            btnEliminar.Location = new Point(816, 306);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 39);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.GrayText;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.FromArgb(26, 32, 40);
            btnActualizar.Location = new Point(657, 306);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(116, 39);
            btnActualizar.TabIndex = 27;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.GrayText;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.FromArgb(26, 32, 40);
            btnRegistrar.Location = new Point(497, 306);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 39);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbPrecio
            // 
            tbPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPrecio.Location = new Point(1028, 196);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(226, 32);
            tbPrecio.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1028, 158);
            label4.Name = "label4";
            label4.Size = new Size(154, 23);
            label4.TabIndex = 20;
            label4.Text = "Precio/Unidad:";
            // 
            // tbStock
            // 
            tbStock.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbStock.Location = new Point(588, 196);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(417, 32);
            tbStock.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(588, 158);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 18;
            label3.Text = "Stock:";
            // 
            // tbNombreProducto
            // 
            tbNombreProducto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombreProducto.Location = new Point(147, 196);
            tbNombreProducto.Name = "tbNombreProducto";
            tbNombreProducto.Size = new Size(417, 32);
            tbNombreProducto.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(147, 158);
            label2.Name = "label2";
            label2.Size = new Size(224, 23);
            label2.TabIndex = 16;
            label2.Text = "Nombre de Producto:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.GrayText;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 32, 40);
            btnLimpiar.Location = new Point(1174, 23);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 39);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // IdProducto
            // 
            IdProducto.AutoSize = true;
            IdProducto.Location = new Point(116, 42);
            IdProducto.Name = "IdProducto";
            IdProducto.Size = new Size(82, 20);
            IdProducto.TabIndex = 29;
            IdProducto.Text = "IdProducto";
            IdProducto.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgProductos);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 457);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 505);
            panel1.TabIndex = 31;
            // 
            // dgProductos
            // 
            dgProductos.BackgroundColor = Color.FromArgb(45, 65, 91);
            dgProductos.BorderStyle = BorderStyle.None;
            dgProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgProductos.ColumnHeadersHeight = 30;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgProductos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgProductos.EnableHeadersVisualStyles = false;
            dgProductos.GridColor = Color.SteelBlue;
            dgProductos.Location = new Point(49, 3);
            dgProductos.Name = "dgProductos";
            dgProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgProductos.RowHeadersVisible = false;
            dgProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgProductos.RowTemplate.Height = 29;
            dgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProductos.Size = new Size(1343, 477);
            dgProductos.TabIndex = 0;
            dgProductos.MouseDoubleClick += dgProductos_MouseDoubleClick;
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar);
            Controls.Add(IdProducto);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(tbPrecio);
            Controls.Add(label4);
            Controls.Add(tbStock);
            Controls.Add(label3);
            Controls.Add(tbNombreProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductosView";
            Size = new Size(1440, 962);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private TextBox tbPrecio;
        private Label label4;
        private TextBox tbStock;
        private Label label3;
        private TextBox tbNombreProducto;
        private Label label2;
        private Button btnLimpiar;
        private Label IdProducto;
        private Panel panel1;
        private DataGridView dgProductos;
    }
}

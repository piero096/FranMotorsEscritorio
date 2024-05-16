namespace FranMotors
{
    partial class MantenimientosView
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            dgProductos = new DataGridView();
            lbPrecioTotal = new Label();
            tbManoObra = new TextBox();
            label3 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label5 = new Label();
            panel2 = new Panel();
            dgDetalleMantenimiento = new DataGridView();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDetalleMantenimiento).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(450, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 47);
            label1.TabIndex = 2;
            label1.Text = "Mantenimientos";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgProductos);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(872, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 722);
            panel1.TabIndex = 3;
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
            dgProductos.Location = new Point(0, 38);
            dgProductos.Margin = new Padding(3, 2, 3, 2);
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
            dgProductos.Size = new Size(388, 682);
            dgProductos.TabIndex = 1;
            dgProductos.CellDoubleClick += dgProductos_CellDoubleClick;
            // 
            // lbPrecioTotal
            // 
            lbPrecioTotal.AutoEllipsis = true;
            lbPrecioTotal.AutoSize = true;
            lbPrecioTotal.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrecioTotal.ForeColor = SystemColors.ButtonHighlight;
            lbPrecioTotal.Location = new Point(192, 226);
            lbPrecioTotal.Name = "lbPrecioTotal";
            lbPrecioTotal.Size = new Size(78, 33);
            lbPrecioTotal.TabIndex = 12;
            lbPrecioTotal.Text = "Total";
            // 
            // tbManoObra
            // 
            tbManoObra.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbManoObra.Location = new Point(450, 232);
            tbManoObra.Margin = new Padding(3, 2, 3, 2);
            tbManoObra.Name = "tbManoObra";
            tbManoObra.Size = new Size(401, 27);
            tbManoObra.TabIndex = 11;
            tbManoObra.TextChanged += tbManoObra_TextChanged;
            tbManoObra.KeyPress += tbManoObra_KeyPress;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(450, 204);
            label3.Name = "label3";
            label3.Size = new Size(181, 21);
            label3.TabIndex = 10;
            label3.Text = "Precio Mano de Obra:";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 8;
            label2.Text = "Motivo de Ingreso:";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(25, 92);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(401, 91);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(450, 92);
            richTextBox2.Margin = new Padding(3, 2, 3, 2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(401, 91);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "";
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(450, 64);
            label5.Name = "label5";
            label5.Size = new Size(190, 21);
            label5.TabIndex = 16;
            label5.Text = "Detalle de Reparación:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgDetalleMantenimiento);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 336);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(872, 386);
            panel2.TabIndex = 17;
            // 
            // dgDetalleMantenimiento
            // 
            dgDetalleMantenimiento.AllowUserToAddRows = false;
            dgDetalleMantenimiento.BackgroundColor = Color.FromArgb(45, 65, 91);
            dgDetalleMantenimiento.BorderStyle = BorderStyle.None;
            dgDetalleMantenimiento.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgDetalleMantenimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgDetalleMantenimiento.ColumnHeadersHeight = 30;
            dgDetalleMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgDetalleMantenimiento.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgDetalleMantenimiento.EnableHeadersVisualStyles = false;
            dgDetalleMantenimiento.GridColor = Color.SteelBlue;
            dgDetalleMantenimiento.Location = new Point(3, 2);
            dgDetalleMantenimiento.Margin = new Padding(3, 2, 3, 2);
            dgDetalleMantenimiento.Name = "dgDetalleMantenimiento";
            dgDetalleMantenimiento.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgDetalleMantenimiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgDetalleMantenimiento.RowHeadersVisible = false;
            dgDetalleMantenimiento.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgDetalleMantenimiento.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgDetalleMantenimiento.RowTemplate.Height = 29;
            dgDetalleMantenimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDetalleMantenimiento.Size = new Size(867, 381);
            dgDetalleMantenimiento.TabIndex = 2;
            dgDetalleMantenimiento.CellContentClick += dgDetalleMantenimiento_CellContentClick;
            dgDetalleMantenimiento.CellDoubleClick += dgDetalleMantenimiento_CellDoubleClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GrayText;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(26, 32, 40);
            btnEliminar.Location = new Point(547, 280);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 29);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.GrayText;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.FromArgb(26, 32, 40);
            btnActualizar.Location = new Point(408, 280);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(102, 29);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.GrayText;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.FromArgb(26, 32, 40);
            btnRegistrar.Location = new Point(268, 280);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(102, 29);
            btnRegistrar.TabIndex = 18;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // MantenimientosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(lbPrecioTotal);
            Controls.Add(tbManoObra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MantenimientosView";
            Size = new Size(1260, 722);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDetalleMantenimiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dgProductos;
        private Label lbPrecioTotal;
        private TextBox tbManoObra;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label5;
        private Panel panel2;
        private DataGridView dgDetalleMantenimiento;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
    }
}

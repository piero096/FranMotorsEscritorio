namespace FranMotors
{
    partial class ClientesView
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
            label2 = new Label();
            tbNombre = new TextBox();
            tbApellidos = new TextBox();
            label3 = new Label();
            tbDocumento = new TextBox();
            label4 = new Label();
            tbCorreo = new TextBox();
            label5 = new Label();
            tbTelefono = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            dgClientes = new DataGridView();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            idCliente = new Label();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(611, 6);
            label1.Name = "label1";
            label1.Size = new Size(219, 59);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(170, 105);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombres: ";
            // 
            // tbNombre
            // 
            tbNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombre.Location = new Point(170, 143);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(417, 32);
            tbNombre.TabIndex = 3;
            // 
            // tbApellidos
            // 
            tbApellidos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbApellidos.Location = new Point(611, 143);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(417, 32);
            tbApellidos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(611, 105);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 4;
            label3.Text = "Apellidos: ";
            // 
            // tbDocumento
            // 
            tbDocumento.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDocumento.Location = new Point(1051, 143);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(226, 32);
            tbDocumento.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1051, 105);
            label4.Name = "label4";
            label4.Size = new Size(211, 23);
            label4.TabIndex = 6;
            label4.Text = "Nro de Documento: ";
            // 
            // tbCorreo
            // 
            tbCorreo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbCorreo.Location = new Point(379, 274);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(417, 32);
            tbCorreo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(379, 236);
            label5.Name = "label5";
            label5.Size = new Size(203, 23);
            label5.TabIndex = 8;
            label5.Text = "Correo Electrónico: ";
            // 
            // tbTelefono
            // 
            tbTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefono.Location = new Point(812, 274);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(238, 32);
            tbTelefono.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(812, 236);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 10;
            label6.Text = "Teléfono:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgClientes);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 457);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 505);
            panel1.TabIndex = 12;
            // 
            // dgClientes
            // 
            dgClientes.BackgroundColor = Color.FromArgb(45, 65, 91);
            dgClientes.BorderStyle = BorderStyle.None;
            dgClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgClientes.ColumnHeadersHeight = 30;
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgClientes.EnableHeadersVisualStyles = false;
            dgClientes.GridColor = Color.SteelBlue;
            dgClientes.Location = new Point(49, 3);
            dgClientes.Name = "dgClientes";
            dgClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgClientes.RowHeadersVisible = false;
            dgClientes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgClientes.RowTemplate.Height = 29;
            dgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgClientes.Size = new Size(1343, 477);
            dgClientes.TabIndex = 0;
            dgClientes.MouseDoubleClick += dgClientes_MouseDoubleClick;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.GrayText;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.FromArgb(26, 32, 40);
            btnRegistrar.Location = new Point(520, 372);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 39);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.GrayText;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.FromArgb(26, 32, 40);
            btnActualizar.Location = new Point(680, 372);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(116, 39);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GrayText;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(26, 32, 40);
            btnEliminar.Location = new Point(839, 372);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 39);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // idCliente
            // 
            idCliente.AutoSize = true;
            idCliente.Location = new Point(103, 39);
            idCliente.Name = "idCliente";
            idCliente.Size = new Size(68, 20);
            idCliente.TabIndex = 16;
            idCliente.Text = "IdCliente";
            idCliente.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.GrayText;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 32, 40);
            btnLimpiar.Location = new Point(1161, 20);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 39);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(btnLimpiar);
            Controls.Add(idCliente);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(panel1);
            Controls.Add(tbTelefono);
            Controls.Add(label6);
            Controls.Add(tbCorreo);
            Controls.Add(label5);
            Controls.Add(tbDocumento);
            Controls.Add(label4);
            Controls.Add(tbApellidos);
            Controls.Add(label3);
            Controls.Add(tbNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientesView";
            Size = new Size(1440, 962);
            Load += ClientesView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNombre;
        private TextBox tbApellidos;
        private Label label3;
        private TextBox tbDocumento;
        private Label label4;
        private TextBox tbCorreo;
        private Label label5;
        private TextBox tbTelefono;
        private Label label6;
        private Panel panel1;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgClientes;
        private Label idCliente;
        private Button btnLimpiar;
    }
}

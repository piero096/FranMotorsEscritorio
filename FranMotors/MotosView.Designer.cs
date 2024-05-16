namespace FranMotors
{
    partial class MotosView
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
            tbTarjetaPropiedad = new TextBox();
            label6 = new Label();
            tbPlaca = new TextBox();
            label5 = new Label();
            tbMotor = new TextBox();
            label4 = new Label();
            tbModelo = new TextBox();
            label3 = new Label();
            tbMarca = new TextBox();
            label2 = new Label();
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            lbNombreCliente = new Label();
            panel1 = new Panel();
            dgMotos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Id_Cliente = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Motor = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            TarjetaPropiedad = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            IdCliente = new Label();
            IdMoto = new Label();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMotos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(635, 7);
            label1.Name = "label1";
            label1.Size = new Size(171, 59);
            label1.TabIndex = 2;
            label1.Text = "Motos";
            label1.Click += label1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GrayText;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(26, 32, 40);
            btnEliminar.Location = new Point(818, 442);
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
            btnActualizar.Location = new Point(659, 442);
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
            btnRegistrar.Location = new Point(499, 442);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 39);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbTarjetaPropiedad
            // 
            tbTarjetaPropiedad.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbTarjetaPropiedad.Location = new Point(737, 344);
            tbTarjetaPropiedad.Name = "tbTarjetaPropiedad";
            tbTarjetaPropiedad.Size = new Size(270, 32);
            tbTarjetaPropiedad.TabIndex = 25;
            tbTarjetaPropiedad.TextChanged += tbTarjetaPropiedad_TextChanged;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(737, 306);
            label6.Name = "label6";
            label6.Size = new Size(189, 23);
            label6.TabIndex = 24;
            label6.Text = "Tarjeta Propiedad:";
            // 
            // tbPlaca
            // 
            tbPlaca.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPlaca.Location = new Point(440, 344);
            tbPlaca.Name = "tbPlaca";
            tbPlaca.Size = new Size(270, 32);
            tbPlaca.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(440, 306);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 22;
            label5.Text = "Placa:";
            // 
            // tbMotor
            // 
            tbMotor.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMotor.Location = new Point(1030, 213);
            tbMotor.Name = "tbMotor";
            tbMotor.Size = new Size(226, 32);
            tbMotor.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1030, 175);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 20;
            label4.Text = "Motor:";
            // 
            // tbModelo
            // 
            tbModelo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbModelo.Location = new Point(590, 213);
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(417, 32);
            tbModelo.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(590, 175);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 18;
            label3.Text = "Modelo:";
            // 
            // tbMarca
            // 
            tbMarca.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMarca.Location = new Point(149, 213);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(417, 32);
            tbMarca.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(149, 175);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 16;
            label2.Text = "Marca:";
            // 
            // tbBuscar
            // 
            tbBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBuscar.Location = new Point(853, 71);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(417, 32);
            tbBuscar.TabIndex = 29;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.GrayText;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.FromArgb(26, 32, 40);
            btnBuscar.Location = new Point(1294, 66);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 39);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lbNombreCliente
            // 
            lbNombreCliente.AutoSize = true;
            lbNombreCliente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombreCliente.ForeColor = SystemColors.ButtonHighlight;
            lbNombreCliente.Location = new Point(54, 74);
            lbNombreCliente.Name = "lbNombreCliente";
            lbNombreCliente.Size = new Size(206, 23);
            lbNombreCliente.TabIndex = 31;
            lbNombreCliente.Text = "NOMBRE DE CLIENTE";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgMotos);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 503);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 459);
            panel1.TabIndex = 32;
            // 
            // dgMotos
            // 
            dgMotos.AllowUserToAddRows = false;
            dgMotos.AllowUserToResizeColumns = false;
            dgMotos.AllowUserToResizeRows = false;
            dgMotos.BackgroundColor = Color.FromArgb(45, 65, 91);
            dgMotos.BorderStyle = BorderStyle.None;
            dgMotos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgMotos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgMotos.ColumnHeadersHeight = 30;
            dgMotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgMotos.Columns.AddRange(new DataGridViewColumn[] { Id, Id_Cliente, Marca, Modelo, Motor, Placa, TarjetaPropiedad, Cliente });
            dgMotos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgMotos.EnableHeadersVisualStyles = false;
            dgMotos.GridColor = Color.SteelBlue;
            dgMotos.Location = new Point(49, 3);
            dgMotos.Name = "dgMotos";
            dgMotos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgMotos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgMotos.RowHeadersVisible = false;
            dgMotos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgMotos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgMotos.RowTemplate.Height = 29;
            dgMotos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMotos.Size = new Size(1343, 477);
            dgMotos.TabIndex = 0;
            dgMotos.DoubleClick += dgMotos_DoubleClick;
            dgMotos.MouseDoubleClick += dgMotos_MouseDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Id_Cliente
            // 
            Id_Cliente.HeaderText = "Id_Cliente";
            Id_Cliente.MinimumWidth = 6;
            Id_Cliente.Name = "Id_Cliente";
            Id_Cliente.Width = 125;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.Width = 125;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.MinimumWidth = 6;
            Modelo.Name = "Modelo";
            Modelo.Width = 125;
            // 
            // Motor
            // 
            Motor.HeaderText = "Motor";
            Motor.MinimumWidth = 6;
            Motor.Name = "Motor";
            Motor.Width = 125;
            // 
            // Placa
            // 
            Placa.HeaderText = "Placa";
            Placa.MinimumWidth = 6;
            Placa.Name = "Placa";
            Placa.Width = 125;
            // 
            // TarjetaPropiedad
            // 
            TarjetaPropiedad.HeaderText = "Tarjeta Propiedad";
            TarjetaPropiedad.MinimumWidth = 6;
            TarjetaPropiedad.Name = "TarjetaPropiedad";
            TarjetaPropiedad.Width = 125;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // IdCliente
            // 
            IdCliente.AutoSize = true;
            IdCliente.Location = new Point(54, 24);
            IdCliente.Name = "IdCliente";
            IdCliente.Size = new Size(68, 20);
            IdCliente.TabIndex = 33;
            IdCliente.Text = "IdCliente";
            // 
            // IdMoto
            // 
            IdMoto.AutoSize = true;
            IdMoto.Location = new Point(149, 137);
            IdMoto.Name = "IdMoto";
            IdMoto.Size = new Size(58, 20);
            IdMoto.TabIndex = 34;
            IdMoto.Text = "IdMoto";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.GrayText;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 32, 40);
            btnLimpiar.Location = new Point(1294, 206);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 39);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // MotosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(btnLimpiar);
            Controls.Add(IdMoto);
            Controls.Add(IdCliente);
            Controls.Add(panel1);
            Controls.Add(lbNombreCliente);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(tbTarjetaPropiedad);
            Controls.Add(label6);
            Controls.Add(tbPlaca);
            Controls.Add(label5);
            Controls.Add(tbMotor);
            Controls.Add(label4);
            Controls.Add(tbModelo);
            Controls.Add(label3);
            Controls.Add(tbMarca);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MotosView";
            Size = new Size(1440, 962);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgMotos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private TextBox tbTarjetaPropiedad;
        private Label label6;
        private TextBox tbPlaca;
        private Label label5;
        private TextBox tbMotor;
        private Label label4;
        private TextBox tbModelo;
        private Label label3;
        private TextBox tbMarca;
        private Label label2;
        private TextBox tbBuscar;
        private Button btnBuscar;
        private Label lbNombreCliente;
        private Panel panel1;
        private DataGridView dgMotos;
        private Label IdCliente;
        private Label IdMoto;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Id_Cliente;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Motor;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn TarjetaPropiedad;
        private DataGridViewTextBoxColumn Cliente;
        private Button btnLimpiar;
    }
}

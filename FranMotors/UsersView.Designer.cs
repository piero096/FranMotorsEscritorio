namespace FranMotors
{
    partial class UsersView
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
            tbCorreo = new TextBox();
            label5 = new Label();
            tbApellidos = new TextBox();
            label4 = new Label();
            tbContrasena = new TextBox();
            label3 = new Label();
            tbNombreUsuario = new TextBox();
            label2 = new Label();
            tbNombres = new TextBox();
            label7 = new Label();
            cbPuesto = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            cbEstado = new ComboBox();
            panel1 = new Panel();
            dgUsuarios = new DataGridView();
            idUsuario = new Label();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(608, 2);
            label1.Name = "label1";
            label1.Size = new Size(224, 59);
            label1.TabIndex = 2;
            label1.Text = "Usuarios";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.GrayText;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.FromArgb(26, 32, 40);
            btnEliminar.Location = new Point(835, 377);
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
            btnActualizar.Location = new Point(676, 377);
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
            btnRegistrar.Location = new Point(516, 377);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 39);
            btnRegistrar.TabIndex = 26;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbCorreo
            // 
            tbCorreo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbCorreo.Location = new Point(216, 288);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(417, 32);
            tbCorreo.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(216, 250);
            label5.Name = "label5";
            label5.Size = new Size(203, 23);
            label5.TabIndex = 22;
            label5.Text = "Correo Electrónico: ";
            // 
            // tbApellidos
            // 
            tbApellidos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbApellidos.Location = new Point(1017, 171);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(365, 32);
            tbApellidos.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1017, 133);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 20;
            label4.Text = "Apellidos:";
            // 
            // tbContrasena
            // 
            tbContrasena.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbContrasena.Location = new Point(338, 171);
            tbContrasena.Name = "tbContrasena";
            tbContrasena.Size = new Size(255, 32);
            tbContrasena.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(338, 133);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 18;
            label3.Text = "Contraseña: ";
            // 
            // tbNombreUsuario
            // 
            tbNombreUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombreUsuario.Location = new Point(54, 171);
            tbNombreUsuario.Name = "tbNombreUsuario";
            tbNombreUsuario.Size = new Size(255, 32);
            tbNombreUsuario.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(54, 133);
            label2.Name = "label2";
            label2.Size = new Size(209, 23);
            label2.TabIndex = 16;
            label2.Text = "Nombre de Usuario: ";
            // 
            // tbNombres
            // 
            tbNombres.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombres.Location = new Point(623, 171);
            tbNombres.Name = "tbNombres";
            tbNombres.Size = new Size(365, 32);
            tbNombres.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoEllipsis = true;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(623, 133);
            label7.Name = "label7";
            label7.Size = new Size(109, 23);
            label7.TabIndex = 29;
            label7.Text = "Nombres: ";
            // 
            // cbPuesto
            // 
            cbPuesto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPuesto.FormattingEnabled = true;
            cbPuesto.Items.AddRange(new object[] { "Seleccionar", "Administrador", "Mecánico" });
            cbPuesto.Location = new Point(666, 288);
            cbPuesto.Name = "cbPuesto";
            cbPuesto.Size = new Size(255, 31);
            cbPuesto.TabIndex = 31;
            cbPuesto.Tag = "";
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(666, 250);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 32;
            label8.Text = "Puesto:";
            // 
            // label9
            // 
            label9.AutoEllipsis = true;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(954, 250);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 34;
            label9.Text = "Estado:";
            // 
            // cbEstado
            // 
            cbEstado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Seleccionar", "Activo", "Inactivo" });
            cbEstado.Location = new Point(954, 288);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(255, 31);
            cbEstado.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgUsuarios);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 457);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 505);
            panel1.TabIndex = 35;
            // 
            // dgUsuarios
            // 
            dgUsuarios.BackgroundColor = Color.FromArgb(45, 65, 91);
            dgUsuarios.BorderStyle = BorderStyle.None;
            dgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgUsuarios.ColumnHeadersHeight = 30;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgUsuarios.EnableHeadersVisualStyles = false;
            dgUsuarios.GridColor = Color.SteelBlue;
            dgUsuarios.Location = new Point(49, 3);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgUsuarios.RowHeadersVisible = false;
            dgUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgUsuarios.RowTemplate.Height = 29;
            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.Size = new Size(1343, 477);
            dgUsuarios.TabIndex = 0;
            dgUsuarios.MouseDoubleClick += dgUsuarios_MouseDoubleClick;
            // 
            // idUsuario
            // 
            idUsuario.AutoSize = true;
            idUsuario.Location = new Point(54, 35);
            idUsuario.Name = "idUsuario";
            idUsuario.Size = new Size(72, 20);
            idUsuario.TabIndex = 17;
            idUsuario.Text = "IdUsuario";
            idUsuario.Visible = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.GrayText;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Red;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.FromArgb(26, 32, 40);
            btnLimpiar.Location = new Point(1266, 16);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 39);
            btnLimpiar.TabIndex = 36;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // UsersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(btnLimpiar);
            Controls.Add(idUsuario);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(cbEstado);
            Controls.Add(label8);
            Controls.Add(cbPuesto);
            Controls.Add(tbNombres);
            Controls.Add(label7);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(tbCorreo);
            Controls.Add(label5);
            Controls.Add(tbApellidos);
            Controls.Add(label4);
            Controls.Add(tbContrasena);
            Controls.Add(label3);
            Controls.Add(tbNombreUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsersView";
            Size = new Size(1440, 962);
            Load += UsersView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrar;
        private TextBox tbCorreo;
        private Label label5;
        private TextBox tbApellidos;
        private Label label4;
        private TextBox tbContrasena;
        private Label label3;
        private TextBox tbNombreUsuario;
        private Label label2;
        private TextBox tbNombres;
        private Label label7;
        private ComboBox cbPuesto;
        private Label label8;
        private Label label9;
        private ComboBox cbEstado;
        private Panel panel1;
        private DataGridView dgUsuarios;
        private Label idUsuario;
        private Button btnLimpiar;
    }
}

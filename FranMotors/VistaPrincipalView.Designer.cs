namespace GUI_MODERNISTA
{
    partial class VistaPrincipalView
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPrincipalView));
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            MenuVertical = new Panel();
            btnProductos = new Button();
            SubmenuReportes = new Panel();
            panel9 = new Panel();
            btnUsuarios = new Button();
            btnsalir = new PictureBox();
            panel7 = new Panel();
            btnConfiguración = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            btnMantenimiento = new Button();
            panel3 = new Panel();
            btnClientes = new Button();
            btnMotos = new Button();
            panel1 = new Panel();
            btninicio = new PictureBox();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            MenuVertical.SuspendLayout();
            SubmenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnsalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btninicio).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(26, 32, 40);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Margin = new Padding(4, 5, 4, 5);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1733, 38);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1668, 7);
            btnRestaurar.Margin = new Padding(4, 5, 4, 5);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 3;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1631, 7);
            btnMinimizar.Margin = new Padding(4, 5, 4, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 2;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1668, 7);
            btnMaximizar.Margin = new Padding(4, 5, 4, 5);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1701, 6);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(btnProductos);
            MenuVertical.Controls.Add(SubmenuReportes);
            MenuVertical.Controls.Add(btnsalir);
            MenuVertical.Controls.Add(panel7);
            MenuVertical.Controls.Add(btnConfiguración);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(btnMantenimiento);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnClientes);
            MenuVertical.Controls.Add(btnMotos);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btninicio);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 38);
            MenuVertical.Margin = new Padding(4, 5, 4, 5);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(293, 962);
            MenuVertical.TabIndex = 1;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(26, 32, 40);
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.Red;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(10, 418);
            btnProductos.Margin = new Padding(4, 5, 4, 5);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(283, 62);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnproductos_Click;
            // 
            // SubmenuReportes
            // 
            SubmenuReportes.Controls.Add(panel9);
            SubmenuReportes.Controls.Add(btnUsuarios);
            SubmenuReportes.Location = new Point(55, 702);
            SubmenuReportes.Margin = new Padding(4, 5, 4, 5);
            SubmenuReportes.Name = "SubmenuReportes";
            SubmenuReportes.Size = new Size(239, 133);
            SubmenuReportes.TabIndex = 15;
            SubmenuReportes.Visible = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Red;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(7, 43);
            panel9.TabIndex = 17;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(26, 32, 40);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.Red;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(4, 0);
            btnUsuarios.Margin = new Padding(4, 5, 4, 5);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(235, 43);
            btnUsuarios.TabIndex = 16;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnrptventa_Click;
            // 
            // btnsalir
            // 
            btnsalir.Cursor = Cursors.Hand;
            btnsalir.Image = (Image)resources.GetObject("btnsalir.Image");
            btnsalir.Location = new Point(4, 845);
            btnsalir.Margin = new Padding(4, 5, 4, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(73, 92);
            btnsalir.SizeMode = PictureBoxSizeMode.Zoom;
            btnsalir.TabIndex = 16;
            btnsalir.TabStop = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Red;
            panel7.Location = new Point(0, 631);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(7, 62);
            panel7.TabIndex = 14;
            // 
            // btnConfiguración
            // 
            btnConfiguración.BackColor = Color.FromArgb(26, 32, 40);
            btnConfiguración.FlatAppearance.BorderSize = 0;
            btnConfiguración.FlatAppearance.MouseOverBackColor = Color.Red;
            btnConfiguración.FlatStyle = FlatStyle.Flat;
            btnConfiguración.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguración.ForeColor = Color.White;
            btnConfiguración.Image = (Image)resources.GetObject("btnConfiguración.Image");
            btnConfiguración.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguración.Location = new Point(4, 631);
            btnConfiguración.Margin = new Padding(4, 5, 4, 5);
            btnConfiguración.Name = "btnConfiguración";
            btnConfiguración.Size = new Size(289, 62);
            btnConfiguración.TabIndex = 13;
            btnConfiguración.Text = "Configuración";
            btnConfiguración.UseVisualStyleBackColor = false;
            btnConfiguración.Click += btnReportes_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Red;
            panel5.Location = new Point(0, 418);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(7, 62);
            panel5.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Location = new Point(0, 348);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(7, 62);
            panel4.TabIndex = 8;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.BackColor = Color.FromArgb(26, 32, 40);
            btnMantenimiento.FlatAppearance.BorderSize = 0;
            btnMantenimiento.FlatAppearance.MouseOverBackColor = Color.Red;
            btnMantenimiento.FlatStyle = FlatStyle.Flat;
            btnMantenimiento.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMantenimiento.ForeColor = Color.White;
            btnMantenimiento.Image = (Image)resources.GetObject("btnMantenimiento.Image");
            btnMantenimiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnMantenimiento.Location = new Point(5, 348);
            btnMantenimiento.Margin = new Padding(4, 5, 4, 5);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(288, 62);
            btnMantenimiento.TabIndex = 7;
            btnMantenimiento.Text = "Mantenimiento";
            btnMantenimiento.UseVisualStyleBackColor = false;
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(0, 277);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(7, 62);
            panel3.TabIndex = 6;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(26, 32, 40);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(9, 206);
            btnClientes.Margin = new Padding(4, 5, 4, 5);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(284, 62);
            btnClientes.TabIndex = 5;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            btnClientes.MouseLeave += btnClientes_MouseLeave;
            // 
            // btnMotos
            // 
            btnMotos.BackColor = Color.FromArgb(26, 32, 40);
            btnMotos.FlatAppearance.BorderSize = 0;
            btnMotos.FlatAppearance.MouseOverBackColor = Color.Red;
            btnMotos.FlatStyle = FlatStyle.Flat;
            btnMotos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMotos.ForeColor = Color.White;
            btnMotos.Image = (Image)resources.GetObject("btnMotos.Image");
            btnMotos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMotos.Location = new Point(4, 277);
            btnMotos.Margin = new Padding(4, 5, 4, 5);
            btnMotos.Name = "btnMotos";
            btnMotos.Size = new Size(289, 62);
            btnMotos.TabIndex = 3;
            btnMotos.Text = "Motos";
            btnMotos.UseVisualStyleBackColor = false;
            btnMotos.Click += btnMotos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(0, 206);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 62);
            panel1.TabIndex = 2;
            // 
            // btninicio
            // 
            btninicio.Cursor = Cursors.Hand;
            btninicio.Image = (Image)resources.GetObject("btninicio.Image");
            btninicio.Location = new Point(15, 12);
            btninicio.Margin = new Padding(4, 5, 4, 5);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(261, 157);
            btninicio.SizeMode = PictureBoxSizeMode.Zoom;
            btninicio.TabIndex = 0;
            btninicio.TabStop = false;
            btninicio.Click += btninicio_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(293, 38);
            panelContenedor.Margin = new Padding(4, 5, 4, 5);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1440, 962);
            panelContenedor.TabIndex = 2;
            // 
            // VistaPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1733, 1000);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "VistaPrincipalView";
            Text = "Form1";
            Load += Form1_Load;
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            MenuVertical.ResumeLayout(false);
            SubmenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnsalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btninicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox btninicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnConfiguración;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMotos;
        private System.Windows.Forms.Panel SubmenuReportes;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.PictureBox btnsalir;
    }
}


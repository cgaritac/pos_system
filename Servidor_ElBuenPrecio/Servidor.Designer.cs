namespace Servidor_ElBuenPrecio
{
    partial class frmServidor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.lstBContadorClientes = new System.Windows.Forms.ListBox();
            this.txtCajaAsignada = new System.Windows.Forms.TextBox();
            this.btnActivar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCajeros = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.itmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.itmVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.itmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxActProd = new System.Windows.Forms.ComboBox();
            this.rdbActualizar = new System.Windows.Forms.RadioButton();
            this.rdbRegistrar = new System.Windows.Forms.RadioButton();
            this.btnRegistrarProd = new System.Windows.Forms.Button();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxCategoriaProd = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoCat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcionCat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxCajPendientes = new System.Windows.Forms.ComboBox();
            this.btnRegistrarCat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetener = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBitacora
            // 
            this.txtBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitacora.Location = new System.Drawing.Point(35, 70);
            this.txtBitacora.Margin = new System.Windows.Forms.Padding(2);
            this.txtBitacora.Multiline = true;
            this.txtBitacora.Name = "txtBitacora";
            this.txtBitacora.ReadOnly = true;
            this.txtBitacora.Size = new System.Drawing.Size(444, 882);
            this.txtBitacora.TabIndex = 1;
            // 
            // lstBContadorClientes
            // 
            this.lstBContadorClientes.Font = new System.Drawing.Font("Tahoma", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBContadorClientes.FormattingEnabled = true;
            this.lstBContadorClientes.ItemHeight = 33;
            this.lstBContadorClientes.Location = new System.Drawing.Point(29, 70);
            this.lstBContadorClientes.Margin = new System.Windows.Forms.Padding(8);
            this.lstBContadorClientes.Name = "lstBContadorClientes";
            this.lstBContadorClientes.Size = new System.Drawing.Size(491, 895);
            this.lstBContadorClientes.TabIndex = 9;
            // 
            // txtCajaAsignada
            // 
            this.txtCajaAsignada.Enabled = false;
            this.txtCajaAsignada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajaAsignada.Location = new System.Drawing.Point(1115, 220);
            this.txtCajaAsignada.Margin = new System.Windows.Forms.Padding(2);
            this.txtCajaAsignada.Name = "txtCajaAsignada";
            this.txtCajaAsignada.Size = new System.Drawing.Size(192, 38);
            this.txtCajaAsignada.TabIndex = 41;
            this.txtCajaAsignada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCajaAsignada_KeyPress);
            // 
            // btnActivar
            // 
            this.btnActivar.Enabled = false;
            this.btnActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Location = new System.Drawing.Point(1132, 65);
            this.btnActivar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(172, 60);
            this.btnActivar.TabIndex = 33;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Usuario:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Enabled = false;
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(850, 222);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(236, 38);
            this.txtApellido2.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1110, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "Caja Asignada:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(70, 222);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(236, 38);
            this.txtID.TabIndex = 37;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Enabled = false;
            this.txtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(592, 222);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(236, 38);
            this.txtApellido1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 32);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(845, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Segundo apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(330, 222);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 38);
            this.txtNombre.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(585, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 32);
            this.label9.TabIndex = 30;
            this.label9.Text = "Primer apellido:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.itmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2580, 60);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCajeros,
            this.itmCategorias,
            this.itmProductos,
            this.itmVentas});
            this.consultarToolStripMenuItem.Enabled = false;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(156, 56);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // itmCajeros
            // 
            this.itmCajeros.Name = "itmCajeros";
            this.itmCajeros.Size = new System.Drawing.Size(273, 46);
            this.itmCajeros.Text = "Cajeros";
            this.itmCajeros.Click += new System.EventHandler(this.cajerosToolStripMenuItem_Click);
            // 
            // itmCategorias
            // 
            this.itmCategorias.Name = "itmCategorias";
            this.itmCategorias.Size = new System.Drawing.Size(273, 46);
            this.itmCategorias.Text = "Categorías";
            this.itmCategorias.Click += new System.EventHandler(this.categoríasToolStripMenuItem_Click);
            // 
            // itmProductos
            // 
            this.itmProductos.Name = "itmProductos";
            this.itmProductos.Size = new System.Drawing.Size(273, 46);
            this.itmProductos.Text = "Productos";
            this.itmProductos.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // itmVentas
            // 
            this.itmVentas.Name = "itmVentas";
            this.itmVentas.Size = new System.Drawing.Size(273, 46);
            this.itmVentas.Text = "Ventas";
            this.itmVentas.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // itmSalir
            // 
            this.itmSalir.Name = "itmSalir";
            this.itmSalir.Size = new System.Drawing.Size(85, 56);
            this.itmSalir.Text = "Salir";
            this.itmSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.cbxActProd);
            this.groupBox1.Controls.Add(this.rdbActualizar);
            this.groupBox1.Controls.Add(this.rdbRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(22, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(928, 205);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(478, 22);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(443, 32);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Seleccione el código de producto:";
            // 
            // cbxActProd
            // 
            this.cbxActProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActProd.Enabled = false;
            this.cbxActProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActProd.FormattingEnabled = true;
            this.cbxActProd.Location = new System.Drawing.Point(482, 70);
            this.cbxActProd.Margin = new System.Windows.Forms.Padding(2);
            this.cbxActProd.Name = "cbxActProd";
            this.cbxActProd.Size = new System.Drawing.Size(334, 39);
            this.cbxActProd.TabIndex = 12;
            this.cbxActProd.DropDown += new System.EventHandler(this.cbxActProd_DropDown);
            this.cbxActProd.SelectionChangeCommitted += new System.EventHandler(this.cbxActProd_SelectionChangeCommitted);
            this.cbxActProd.DropDownClosed += new System.EventHandler(this.cbxActProd_DropDownClosed);
            this.cbxActProd.SelectedValueChanged += new System.EventHandler(this.cbxActProd_SelectedValueChanged);
            this.cbxActProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxActProd_MouseClick);
            // 
            // rdbActualizar
            // 
            this.rdbActualizar.AutoSize = true;
            this.rdbActualizar.Enabled = false;
            this.rdbActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActualizar.Location = new System.Drawing.Point(28, 65);
            this.rdbActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActualizar.Name = "rdbActualizar";
            this.rdbActualizar.Size = new System.Drawing.Size(418, 36);
            this.rdbActualizar.TabIndex = 1;
            this.rdbActualizar.TabStop = true;
            this.rdbActualizar.Text = "Actualizar producto existente";
            this.rdbActualizar.UseVisualStyleBackColor = true;
            this.rdbActualizar.CheckedChanged += new System.EventHandler(this.rdbActualizar_CheckedChanged);
            // 
            // rdbRegistrar
            // 
            this.rdbRegistrar.AutoSize = true;
            this.rdbRegistrar.Enabled = false;
            this.rdbRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRegistrar.Location = new System.Drawing.Point(28, 135);
            this.rdbRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRegistrar.Name = "rdbRegistrar";
            this.rdbRegistrar.Size = new System.Drawing.Size(370, 36);
            this.rdbRegistrar.TabIndex = 0;
            this.rdbRegistrar.TabStop = true;
            this.rdbRegistrar.Text = "Registrar producto nuevo";
            this.rdbRegistrar.UseVisualStyleBackColor = true;
            this.rdbRegistrar.CheckedChanged += new System.EventHandler(this.rdbRegistrar_CheckedChanged);
            // 
            // btnRegistrarProd
            // 
            this.btnRegistrarProd.Enabled = false;
            this.btnRegistrarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProd.Location = new System.Drawing.Point(965, 170);
            this.btnRegistrarProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarProd.Name = "btnRegistrarProd";
            this.btnRegistrarProd.Size = new System.Drawing.Size(345, 60);
            this.btnRegistrarProd.TabIndex = 19;
            this.btnRegistrarProd.Text = "Actualizar / Registrar";
            this.btnRegistrarProd.UseVisualStyleBackColor = true;
            this.btnRegistrarProd.Click += new System.EventHandler(this.btnRegistrarProd_Click);
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Enabled = false;
            this.txtDescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProd.Location = new System.Drawing.Point(815, 415);
            this.txtDescripcionProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionProd.Multiline = true;
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(494, 182);
            this.txtDescripcionProd.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(810, 365);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 32);
            this.label18.TabIndex = 17;
            this.label18.Text = "Descripción:";
            // 
            // cbxCategoriaProd
            // 
            this.cbxCategoriaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoriaProd.Enabled = false;
            this.cbxCategoriaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoriaProd.FormattingEnabled = true;
            this.cbxCategoriaProd.Location = new System.Drawing.Point(22, 545);
            this.cbxCategoriaProd.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategoriaProd.Name = "cbxCategoriaProd";
            this.cbxCategoriaProd.Size = new System.Drawing.Size(394, 39);
            this.cbxCategoriaProd.TabIndex = 16;
            this.cbxCategoriaProd.DropDown += new System.EventHandler(this.cbxCategoriaProd_DropDown_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 488);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 32);
            this.label17.TabIndex = 15;
            this.label17.Text = "Categoría:";
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Enabled = false;
            this.txtCantidadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProd.Location = new System.Drawing.Point(545, 415);
            this.txtCantidadProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(236, 38);
            this.txtCantidadProd.TabIndex = 14;
            this.txtCantidadProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadProd_KeyPress_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(540, 365);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(260, 32);
            this.label16.TabIndex = 13;
            this.label16.Text = "Cantidad existente:";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Enabled = false;
            this.txtPrecioProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProd.Location = new System.Drawing.Point(285, 415);
            this.txtPrecioProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(236, 38);
            this.txtPrecioProd.TabIndex = 12;
            this.txtPrecioProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProd_KeyPress_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(280, 365);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 32);
            this.label15.TabIndex = 11;
            this.label15.Text = "Precio:";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Enabled = false;
            this.txtCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProd.Location = new System.Drawing.Point(22, 415);
            this.txtCodigoProd.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(236, 38);
            this.txtCodigoProd.TabIndex = 6;
            this.txtCodigoProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProd_KeyPress_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 365);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 32);
            this.label13.TabIndex = 5;
            this.label13.Text = "Código:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(252, 200);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(172, 60);
            this.btnIniciar.TabIndex = 34;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 32);
            this.label10.TabIndex = 5;
            this.label10.Text = "Código:";
            // 
            // txtCodigoCat
            // 
            this.txtCodigoCat.Enabled = false;
            this.txtCodigoCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCat.Location = new System.Drawing.Point(70, 150);
            this.txtCodigoCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCat.Name = "txtCodigoCat";
            this.txtCodigoCat.Size = new System.Drawing.Size(214, 38);
            this.txtCodigoCat.TabIndex = 6;
            this.txtCodigoCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCat_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(425, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 32);
            this.label11.TabIndex = 7;
            this.label11.Text = "Descripción:";
            // 
            // txtDescripcionCat
            // 
            this.txtDescripcionCat.Enabled = false;
            this.txtDescripcionCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionCat.Location = new System.Drawing.Point(430, 150);
            this.txtDescripcionCat.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionCat.Multiline = true;
            this.txtDescripcionCat.Name = "txtDescripcionCat";
            this.txtDescripcionCat.Size = new System.Drawing.Size(476, 69);
            this.txtDescripcionCat.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 32);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cajeros pendientes:";
            // 
            // cbxCajPendientes
            // 
            this.cbxCajPendientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCajPendientes.Enabled = false;
            this.cbxCajPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCajPendientes.FormattingEnabled = true;
            this.cbxCajPendientes.Location = new System.Drawing.Point(325, 82);
            this.cbxCajPendientes.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCajPendientes.Name = "cbxCajPendientes";
            this.cbxCajPendientes.Size = new System.Drawing.Size(336, 39);
            this.cbxCajPendientes.TabIndex = 40;
            this.cbxCajPendientes.DropDown += new System.EventHandler(this.cbxCajPendientes_DropDown);
            this.cbxCajPendientes.SelectedValueChanged += new System.EventHandler(this.cbxCajPendientes_SelectedValueChanged);
            // 
            // btnRegistrarCat
            // 
            this.btnRegistrarCat.Enabled = false;
            this.btnRegistrarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCat.Location = new System.Drawing.Point(1142, 82);
            this.btnRegistrarCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarCat.Name = "btnRegistrarCat";
            this.btnRegistrarCat.Size = new System.Drawing.Size(168, 60);
            this.btnRegistrarCat.TabIndex = 10;
            this.btnRegistrarCat.Text = "Registrar";
            this.btnRegistrarCat.UseVisualStyleBackColor = true;
            this.btnRegistrarCat.Click += new System.EventHandler(this.btnRegistrarCat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblFecha);
            this.groupBox2.Controls.Add(this.lblEstado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDetener);
            this.groupBox2.Controls.Add(this.btnIniciar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1402, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1088, 298);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del servidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fecha: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(761, 48);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 32);
            this.lblFecha.TabIndex = 44;
            this.lblFecha.Text = "      ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(310, 110);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 32);
            this.lblEstado.TabIndex = 37;
            this.lblEstado.Text = "      ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Estado:";
            // 
            // btnDetener
            // 
            this.btnDetener.Enabled = false;
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(615, 200);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(172, 60);
            this.btnDetener.TabIndex = 35;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCajaAsignada);
            this.groupBox3.Controls.Add(this.btnActivar);
            this.groupBox3.Controls.Add(this.cbxCajPendientes);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtApellido2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtApellido1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 98);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(1335, 298);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activación de cajeros:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstBContadorClientes);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1402, 418);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(546, 982);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clientes conectados:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRegistrarCat);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtDescripcionCat);
            this.groupBox5.Controls.Add(this.txtCodigoCat);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(35, 418);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(1335, 260);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Registro de categorías:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBitacora);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1970, 418);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(520, 982);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bitácora:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbxCategoriaProd);
            this.groupBox7.Controls.Add(this.txtDescripcionProd);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.btnRegistrarProd);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.txtCodigoProd);
            this.groupBox7.Controls.Add(this.txtCantidadProd);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.txtPrecioProd);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(35, 720);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(1335, 680);
            this.groupBox7.TabIndex = 42;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Manejo de productos";
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2580, 1512);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmServidor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor El Buen Precio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Servidor_FormClosing);
            this.Load += new System.EventHandler(this.Servidor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.ListBox lstBContadorClientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itmProductos;
        private System.Windows.Forms.ToolStripMenuItem itmCategorias;
        private System.Windows.Forms.ToolStripMenuItem itmVentas;
        private System.Windows.Forms.ToolStripMenuItem itmCajeros;
        private System.Windows.Forms.ToolStripMenuItem itmSalir;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistrarProd;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxCategoriaProd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxActProd;
        private System.Windows.Forms.RadioButton rdbActualizar;
        private System.Windows.Forms.RadioButton rdbRegistrar;
        private System.Windows.Forms.TextBox txtCajaAsignada;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoCat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescripcionCat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxCajPendientes;
        private System.Windows.Forms.Button btnRegistrarCat;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
    }
}


namespace Cliente
{
    partial class frmCliente
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLogin = new System.Windows.Forms.RadioButton();
            this.rdbRegistrar = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.txtCodigoCajero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCodigoVenta = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnComprobarProd = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.cbxListaProductos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidadVendida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalirLog = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEstadoCodVenta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(41, 241);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(257, 55);
            this.btnConectar.TabIndex = 12;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(343, 241);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(257, 55);
            this.btnDesconectar.TabIndex = 13;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // txtCaja
            // 
            this.txtCaja.Enabled = false;
            this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(1251, 155);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(252, 38);
            this.txtCaja.TabIndex = 25;
            this.txtCaja.TextChanged += new System.EventHandler(this.txtCaja_TextChanged);
            // 
            // txtApellido2
            // 
            this.txtApellido2.Enabled = false;
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(979, 155);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(252, 38);
            this.txtApellido2.TabIndex = 23;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress_1);
            // 
            // txtApellido1
            // 
            this.txtApellido1.Enabled = false;
            this.txtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(704, 154);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(252, 38);
            this.txtApellido1.TabIndex = 22;
            this.txtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(426, 154);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 38);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(117, 241);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(183, 57);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Continuar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1245, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Caja Asignada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(973, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Segundo apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(698, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Primer apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(650, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbLogin);
            this.groupBox1.Controls.Add(this.rdbRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(40, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 141);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // rdbLogin
            // 
            this.rdbLogin.AutoSize = true;
            this.rdbLogin.Enabled = false;
            this.rdbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLogin.Location = new System.Drawing.Point(29, 86);
            this.rdbLogin.Name = "rdbLogin";
            this.rdbLogin.Size = new System.Drawing.Size(247, 36);
            this.rdbLogin.TabIndex = 1;
            this.rdbLogin.TabStop = true;
            this.rdbLogin.Text = "Login de cajero";
            this.rdbLogin.UseVisualStyleBackColor = true;
            this.rdbLogin.CheckedChanged += new System.EventHandler(this.rdbLogin_CheckedChanged);
            // 
            // rdbRegistrar
            // 
            this.rdbRegistrar.AutoSize = true;
            this.rdbRegistrar.Enabled = false;
            this.rdbRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRegistrar.Location = new System.Drawing.Point(29, 33);
            this.rdbRegistrar.Name = "rdbRegistrar";
            this.rdbRegistrar.Size = new System.Drawing.Size(282, 36);
            this.rdbRegistrar.TabIndex = 0;
            this.rdbRegistrar.TabStop = true;
            this.rdbRegistrar.Text = "Registro de cajero";
            this.rdbRegistrar.UseVisualStyleBackColor = true;
            this.rdbRegistrar.CheckedChanged += new System.EventHandler(this.rdbRegistrar_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(656, 289);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(252, 38);
            this.txtID.TabIndex = 28;
            // 
            // txtActivo
            // 
            this.txtActivo.Enabled = false;
            this.txtActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivo.Location = new System.Drawing.Point(979, 286);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(252, 38);
            this.txtActivo.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(973, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Activo:";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(27, 283);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowTemplate.Height = 40;
            this.dgvVentas.Size = new System.Drawing.Size(2222, 492);
            this.dgvVentas.TabIndex = 27;
            // 
            // txtCodigoCajero
            // 
            this.txtCodigoCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCajero.Location = new System.Drawing.Point(311, 843);
            this.txtCodigoCajero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCodigoCajero.Name = "txtCodigoCajero";
            this.txtCodigoCajero.ReadOnly = true;
            this.txtCodigoCajero.Size = new System.Drawing.Size(229, 38);
            this.txtCodigoCajero.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 846);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(251, 32);
            this.label16.TabIndex = 40;
            this.label16.Text = "Código del Cajero:";
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVenta.Location = new System.Drawing.Point(311, 785);
            this.txtCodigoVenta.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.ReadOnly = true;
            this.txtCodigoVenta.Size = new System.Drawing.Size(229, 38);
            this.txtCodigoVenta.TabIndex = 39;
            this.txtCodigoVenta.TextChanged += new System.EventHandler(this.txtCodigoVenta_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(35, 788);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(265, 32);
            this.label15.TabIndex = 38;
            this.label15.Text = "Código de la Venta:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1833, 49);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 32);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "      ";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Enabled = false;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(27, 101);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(295, 68);
            this.btnNuevoCliente.TabIndex = 37;
            this.btnNuevoCliente.Text = "Nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1587, 823);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(303, 52);
            this.label14.TabIndex = 32;
            this.label14.Text = "Total Vendido:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(1927, 818);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(300, 57);
            this.txtTotalPagar.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1705, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 32);
            this.label13.TabIndex = 30;
            this.label13.Text = "Fecha: ";
            // 
            // btnVender
            // 
            this.btnVender.Enabled = false;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(1046, 805);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(241, 90);
            this.btnVender.TabIndex = 35;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnComprobarProd
            // 
            this.btnComprobarProd.Enabled = false;
            this.btnComprobarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobarProd.Location = new System.Drawing.Point(1088, 163);
            this.btnComprobarProd.Name = "btnComprobarProd";
            this.btnComprobarProd.Size = new System.Drawing.Size(183, 57);
            this.btnComprobarProd.TabIndex = 34;
            this.btnComprobarProd.Text = "Comprobar";
            this.btnComprobarProd.UseVisualStyleBackColor = true;
            this.btnComprobarProd.Click += new System.EventHandler(this.btnComprobarProd_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Enabled = false;
            this.btnAgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVenta.Location = new System.Drawing.Point(1819, 166);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(183, 57);
            this.btnAgregarVenta.TabIndex = 33;
            this.btnAgregarVenta.Text = "Agregar";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // cbxListaProductos
            // 
            this.cbxListaProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListaProductos.Enabled = false;
            this.cbxListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxListaProductos.FormattingEnabled = true;
            this.cbxListaProductos.Location = new System.Drawing.Point(660, 173);
            this.cbxListaProductos.Name = "cbxListaProductos";
            this.cbxListaProductos.Size = new System.Drawing.Size(400, 39);
            this.cbxListaProductos.TabIndex = 32;
            this.cbxListaProductos.DropDown += new System.EventHandler(this.cbxListaProductos_DropDown);
            this.cbxListaProductos.SelectedValueChanged += new System.EventHandler(this.cbxListaProductos_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1321, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 32);
            this.label12.TabIndex = 31;
            this.label12.Text = "Indique vendida:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtCantidadVendida
            // 
            this.txtCantidadVendida.Enabled = false;
            this.txtCantidadVendida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadVendida.Location = new System.Drawing.Point(1557, 176);
            this.txtCantidadVendida.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCantidadVendida.Name = "txtCantidadVendida";
            this.txtCantidadVendida.Size = new System.Drawing.Size(229, 38);
            this.txtCantidadVendida.TabIndex = 30;
            this.txtCantidadVendida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadVendida_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(342, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(312, 32);
            this.label11.TabIndex = 29;
            this.label11.Text = "Seleccione el producto:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 32);
            this.label17.TabIndex = 30;
            this.label17.Text = "Identificador:";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificador.Location = new System.Drawing.Point(248, 148);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(252, 38);
            this.txtIdentificador.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(48, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 32);
            this.label18.TabIndex = 32;
            this.label18.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(242, 93);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 32);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "     ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblEstado);
            this.groupBox2.Controls.Add(this.btnDesconectar);
            this.groupBox2.Controls.Add(this.btnConectar);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtIdentificador);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(52, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 355);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conexión servidor:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSalirLog);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.txtApellido1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtActivo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnRegistrar);
            this.groupBox3.Controls.Add(this.txtApellido2);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCaja);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(744, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1579, 355);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro / Login de cajero:";
            // 
            // btnSalirLog
            // 
            this.btnSalirLog.Enabled = false;
            this.btnSalirLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirLog.Location = new System.Drawing.Point(1347, 239);
            this.btnSalirLog.Name = "btnSalirLog";
            this.btnSalirLog.Size = new System.Drawing.Size(183, 57);
            this.btnSalirLog.TabIndex = 32;
            this.btnSalirLog.Text = "Salir-Login";
            this.btnSalirLog.UseVisualStyleBackColor = true;
            this.btnSalirLog.Click += new System.EventHandler(this.btnSalirLog_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.lblEstadoCodVenta);
            this.groupBox4.Controls.Add(this.btnNuevoCliente);
            this.groupBox4.Controls.Add(this.btnAgregarVenta);
            this.groupBox4.Controls.Add(this.btnComprobarProd);
            this.groupBox4.Controls.Add(this.txtCodigoCajero);
            this.groupBox4.Controls.Add(this.cbxListaProductos);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btnVender);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtCodigoVenta);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtCantidadVendida);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtTotalPagar);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblFecha);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dgvVentas);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(52, 431);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(2271, 928);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Venta de productos:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(2047, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 57);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEstadoCodVenta
            // 
            this.lblEstadoCodVenta.AutoSize = true;
            this.lblEstadoCodVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCodVenta.Location = new System.Drawing.Point(561, 791);
            this.lblEstadoCodVenta.Name = "lblEstadoCodVenta";
            this.lblEstadoCodVenta.Size = new System.Drawing.Size(85, 32);
            this.lblEstadoCodVenta.TabIndex = 42;
            this.lblEstadoCodVenta.Text = "          ";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2370, 1399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas El Buen Precio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cliente_FormClosing);
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.ComboBox cbxListaProductos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidadVendida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnComprobarProd;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.TextBox txtCodigoCajero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCodigoVenta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLogin;
        private System.Windows.Forms.RadioButton rdbRegistrar;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblEstadoCodVenta;
        private System.Windows.Forms.Button btnSalirLog;
        private System.Windows.Forms.Button btnEliminar;
    }
}


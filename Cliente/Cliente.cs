using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Data.SqlClient;
using Entidades;
using Newtonsoft.Json;


namespace Cliente
{
    public partial class frmCliente : Form
    {       
        bool clienteConectado = false;

        private static string codProd = "";
        private static double precioProd = 0;
        private static int cantProd = 0;
        private List<Ventas> listaVentas = new List<Ventas>();
        private List<RegistroVentas> listaRegistroVentas = new List<RegistroVentas>();
        private DateTime fecha = DateTime.Today;

        public frmCliente()
        {
            InitializeComponent();

            this.txtActivo.Enabled = false;
            this.txtApellido1.Enabled = false;
            this.txtApellido2.Enabled = false;
            this.txtCaja.Enabled = false;
            this.txtID.Enabled = false;
            this.txtNombre.Enabled = false;
            this.btnRegistrar.Enabled = false;
            this.btnNuevoCliente.Enabled = false;
            this.txtCodigoVenta.Text = "";
            this.lblEstado.Text = "Sin conexión";
            this.lblEstado.ForeColor = Color.Red;

            this.lblFecha.Text = fecha.ToString("d");

            this.txtCodigoCajero.Text = "0";
        }

        //Maneja la funcionalidad de conectar con el servidor
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!(txtIdentificador.Text.Equals(string.Empty)))
            {
                if (ClienteTCP.Conectar(txtIdentificador.Text))
                {
                    this.lblEstado.Text = "Conectado al servidor... en (127.0.0.1, 16380)";
                    this.lblEstado.ForeColor = Color.Green;
                    this.clienteConectado = true;
                    this.btnConectar.Enabled = false;
                    this.btnDesconectar.Enabled = true;
                    this.txtIdentificador.ReadOnly = true;
                    this.rdbLogin.Enabled = true;
                    this.rdbRegistrar.Enabled = true;

                    this.txtActivo.Text = "No";
                    this.txtCaja.Text = "0";
                    this.btnRegistrar.Enabled = true;
                    this.btnConectar.Enabled = false;

                    if (this.rdbLogin.Checked == true)
                    {
                        this.txtID.Enabled = true;
                    }

                    if (this.rdbRegistrar.Checked == true)
                    {
                        this.txtID.Enabled = true;
                        this.txtNombre.Enabled = true;
                        this.txtApellido1.Enabled = true;
                        this.txtApellido2.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Verifique que el servidor esté escuchando clientes...", "No es posible conectarse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el identificador del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Maneja la funcionalidad de desconectarse del servidor
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            ClienteTCP.Desconectar(txtIdentificador.Text);

            this.lblEstado.Text = "Desconectado";
            this.lblEstado.ForeColor = Color.Red;
            this.btnConectar.Enabled = true;
            this.btnDesconectar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnAgregarVenta.Enabled = false;
            this.clienteConectado = false;
            this.txtIdentificador.ReadOnly = false;
            this.rdbLogin.Enabled = false;
            this.rdbRegistrar.Enabled = false;
            this.btnRegistrar.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtNombre.Text = "";
            this.txtApellido1.Enabled = false;
            this.txtApellido1.Text = "";
            this.txtApellido2.Enabled = false;
            this.txtApellido2.Text = "";
            this.txtID.Enabled = false;
            this.txtID.Text = "";
            this.btnSalirLog.Enabled = false;
            this.btnNuevoCliente.Enabled = false;
            this.cbxListaProductos.Enabled = false;
            this.cbxListaProductos.Text = "";
            this.btnComprobarProd.Enabled = false;
            this.txtCantidadVendida.Enabled = false;
            this.txtCantidadVendida.Text = "";
            this.btnVender.Enabled = false;
            this.txtActivo.Text = "No";
            this.txtCaja.Text = "0";
            this.txtTotalPagar.Text = "";
            this.txtCodigoVenta.Text = "";
            this.dgvVentas.DataSource = null;
            this.listaVentas.Clear();
            this.listaRegistroVentas.Clear();
        }

        //Maneja la funcionalidad de registrar o hacer login de un cajero
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (rdbLogin.Checked == false && rdbRegistrar.Checked == false)
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("Es necesario que seleccione la opción que desea realizar antes de continuar (registrar o login)", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdbRegistrar.Checked)
                {
                    //Condicional para controlar el ingreso de información por el usuario y mostrar mensaje en caso que hayan campos de ingreso de datos vacíos
                    if (this.txtID.Text.Equals("") || this.txtNombre.Text.Equals("") || this.txtApellido1.Text.Equals("") || this.txtApellido2.Text.Equals(""))
                    {
                        //Muestra mensaje en pantalla
                        MessageBox.Show("Es necesario que ingrese la información en todos los campos solicitados antes de proceder a registrar la información del cajero", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            Cajero datos = new Cajero(); //Crea el objeto "datos" de la clase "Cajero" para tener acceso a los métodos de la clase

                            //Asignación del valor ingresado por el usuario al objeto "datos"
                            datos.Usuario = this.txtID.Text;
                            datos.Nombre = this.txtNombre.Text;
                            datos.Primer_Apellido = this.txtApellido1.Text;
                            datos.Segundo_Apellido = this.txtApellido2.Text;
                            datos.Caja = Int32.Parse(this.txtCaja.Text);
                            datos.Activo = false;

                            if (ClienteTCP.RegistrarCajero(datos))
                            {
                                this.txtNombre.Text = "";
                                this.txtApellido1.Text = "";
                                this.txtApellido2.Text = "";
                                this.txtID.Text = "";

                                MessageBox.Show("Datos enviados para registro, se le comunicará en cuanto se tenga registro activado", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);                            }
                            else
                            {
                                MessageBox.Show("EL usuario ingresado ya se encuentra registrado, proceda a hacer login", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            MessageBox.Show("Servidor no Disponible");
                        }
                    }
                }

                if (rdbLogin.Checked)
                {
                    //Condicional para controlar el ingreso de información por el usuario y mostrar mensaje en caso que hayan campos de ingreso de datos vacíos
                    if (this.txtID.Text.Equals(""))
                    {
                        //Muestra mensaje en pantalla
                        MessageBox.Show("Es necesario que ingrese la información del usuario el campo solicitado antes de proceder a registrar la información del cajero", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            Cajero datos = new Cajero(); //Crea el objeto "datos" de la clase "Cajero" para tener acceso a los métodos de la clase

                            //Asignación del valor ingresado por el usuario al objeto "datos"
                            datos.Usuario = this.txtID.Text;

                            if (ClienteTCP.LoginCajero(datos).Caja != 0)
                            {
                                this.txtNombre.Text = ClienteTCP.LoginCajero(datos).Nombre.ToString();
                                this.txtApellido1.Text = ClienteTCP.LoginCajero(datos).Primer_Apellido.ToString();
                                this.txtApellido2.Text = ClienteTCP.LoginCajero(datos).Segundo_Apellido.ToString();
                                this.txtActivo.Text = "Si";
                                this.txtCaja.Text = ClienteTCP.LoginCajero(datos).Caja.ToString();

                                this.btnNuevoCliente.Enabled = true;
                                this.cbxListaProductos.Enabled = true;
                                this.txtCantidadVendida.Enabled = true;
                                this.btnVender.Enabled = true;
                                this.btnComprobarProd.Enabled = true;
                                this.btnAgregarVenta.Enabled = true;
                                this.btnEliminar.Enabled = true;
                                this.txtCodigoVenta.Text = "0";
                                this.btnRegistrar.Enabled = false;
                                this.btnSalirLog.Enabled = true;

                                MessageBox.Show("Login exitoso, puede proceder a registrar las ventas de productos", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                                MessageBox.Show("El Usuario no se encuentra registrado o activación áún no ha sido realizada en el servidor", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Servidor no Disponible" + ex.ToString());
                        }
                    }
                }
            }
        }

        //Maneja la funcionalidad de finalizar el login de un cajero
        private void btnSalirLog_Click(object sender, EventArgs e)
        {
            this.txtActivo.Text = "No";
            this.txtCaja.Text = "0";
            this.btnRegistrar.Enabled = false;
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.txtID.Text = "";
            this.btnNuevoCliente.Enabled = false;
            this.cbxListaProductos.Text = "";
            this.cbxListaProductos.Enabled = false;
            this.txtCantidadVendida.Text = "";
            this.txtCantidadVendida.Enabled = false;
            this.btnAgregarVenta.Enabled = false;
            this.btnVender.Enabled = false;
            this.btnSalirLog.Enabled = false;
            this.btnComprobarProd.Enabled = false;
            this.btnRegistrar.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.txtTotalPagar.Text = "";
            this.txtCodigoVenta.Text = "";
            this.dgvVentas.DataSource = null;
            this.listaVentas.Clear();
            this.listaRegistroVentas.Clear();
        }

        //Maneja el evento de desplegar el listado de productos del combobox respectivo
        private void cbxListaProductos_DropDown(object sender, EventArgs e)
        {
            try
            {
                List<String> listaProductos = new List<String>();
                listaProductos = ClienteTCP.ObtenerProductos();// Se obtienen mediante la conexión tcp

                cbxListaProductos.DataSource = listaProductos;
                cbxListaProductos.DisplayMember = " ----- ";  
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, revise el estado del servidor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Maneja el evento de seleccionar un valor del listado de productos del combobox respectivo
        private void cbxListaProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            codProd = "";
            string aux; //Declaración de variable  

            aux = this.cbxListaProductos.Text; //Asigna valor seleccionado por el usuario a la variable

            //Ciclo para extraer el código del producto seleccionado por el usuario
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux.Substring(i, 1).Equals(" "))
                {
                    break;
                }
                else
                {
                    codProd += aux.Substring(i, 1);
                }
            }

            if (codProd.Equals(""))
            {
            }
            else
            {
                Producto datos = new Producto();

                datos = ClienteTCP.ObtenerDatosProd(Convert.ToInt32(codProd));

                precioProd = datos.Precio;
                cantProd = datos.Cantidad_Existente;
            }           
        }

        //Maneja la funcionalidad del botón de comprobar la cantidad de un producto respectivo existente en el inventario
        private void btnComprobarProd_Click(object sender, EventArgs e)
        {
            //Condicional para controlar el ingreso de información por el usuario y mostrar mensaje en caso que hayan campos de ingreso de datos vacíos
            if (this.cbxListaProductos.Text.Equals(""))
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("Es necesario que ingrese la información en todos los campos solicitados antes de proceder a agregar el producto para la venta", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Producto datos = new Producto(); //Crea el objeto "datos" de la clase "Producto" para tener acceso a los métodos de la clase

                    //Asignación del valor ingresado por el usuario al objeto "datos"
                    datos.Codigo = Convert.ToInt32(codProd);

                    if (ClienteTCP.ComprobarCantidad(datos) != 0)
                    {
                        datos.Cantidad_Existente = ClienteTCP.ComprobarCantidad(datos);

                        MessageBox.Show("Se tienen " + datos.Cantidad_Existente + " unidades en inventario", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("El producto se encuentra agotado", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Servidor no Disponible");
                }
            }
        }

        //Maneja la funcionalidad de agregar un producto al listado de productos a vender al clientes del supermercado previo a que se consolide la venta
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            //Condicional para controlar el ingreso de información por el usuario y mostrar mensaje en caso que hayan campos de ingreso de datos vacíos
            if (this.txtCantidadVendida.Text.Equals("") || this.cbxListaProductos.Text.Equals(""))
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("Es necesario que ingrese la información en todos los campos solicitados antes de proceder a agregar el producto para la venta", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.txtCantidadVendida.Text.Equals("0"))
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("La cantidad a registrar para a compra debe ser mayor a cero", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Producto datos = new Producto();

                datos = ClienteTCP.ObtenerDatosProd(Convert.ToInt32(codProd));

                cantProd = datos.Cantidad_Existente;

                int cantRegistrada = 0;

                foreach (var item in listaRegistroVentas)
                {
                    if (item.Codigo_Producto == Convert.ToInt32(codProd))
                    {
                        cantRegistrada += item.Cantidad_Vendida;
                    }
                }

                if (Convert.ToInt32(this.txtCantidadVendida.Text) > cantProd || (Convert.ToInt32(this.txtCantidadVendida.Text)+cantRegistrada) > cantProd)
                {
                    //Muestra mensaje en pantalla
                    MessageBox.Show("La cantidad de producto indicada excede la cantidad de producto disponible", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool prueba = false;                   

                    for (int i = 0; i < listaRegistroVentas.Count; i++)
                    {
                        if (Convert.ToInt32(codProd) == listaRegistroVentas[i].Codigo_Producto)
                        {
                            prueba = true;
                        }                        
                    }

                    if (prueba)
                    {
                        //Muestra mensaje en pantalla
                        MessageBox.Show("El producto ya fue agregado, si desea modificarlo, proceda a eliminarlo de la lista e ingreselo nuevamente", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        RegistroVentas registroVenta = new RegistroVentas();
                        Ventas ventaProducto = new Ventas();

                        ventaProducto.Codigo_Cajero = this.txtCodigoCajero.Text;
                        ventaProducto.Codigo = Convert.ToInt32(this.txtCodigoVenta.Text);
                        ventaProducto.Fecha_Venta = lblFecha.Text;
                        ventaProducto.Cantidad_Vendida = Convert.ToInt32(txtCantidadVendida.Text);
                        ventaProducto.Codigo_Producto = Convert.ToInt32(codProd);
                        ventaProducto.Precio_Producto = precioProd;
                        ventaProducto.Monto_Total = ventaProducto.Cantidad_Vendida * ventaProducto.Precio_Producto;

                        this.listaVentas.Add(ventaProducto); //Agrega el objeto a la lista

                        registroVenta.Cantidad_Vendida = Convert.ToInt32(txtCantidadVendida.Text);
                        registroVenta.Codigo_Producto = Convert.ToInt32(codProd);
                        registroVenta.Precio_Producto = precioProd;
                        registroVenta.Monto_Total = registroVenta.Cantidad_Vendida * registroVenta.Precio_Producto;

                        listaRegistroVentas.Add(registroVenta); //Agrega el objeto a la lista

                        this.dgvVentas.DataSource = null;
                        this.dgvVentas.DataSource = listaRegistroVentas;

                        //Cambia los títulos de columnas específicas de la tabla
                        this.dgvVentas.Columns[0].HeaderText = "Código Producto";
                        this.dgvVentas.Columns[1].HeaderText = "Precio Unitario Producto";
                        this.dgvVentas.Columns[2].HeaderText = "Cantidad Vendida";
                        this.dgvVentas.Columns[3].HeaderText = "Monto total por Producto";

                        this.txtCantidadVendida.Text = "";
                        this.cbxListaProductos.Text = "";
                    }                                     
                }
            }           
        }
                
        //Maneja la funcionalidad de consolidar la venta al cliente del supermercado y enviar los datos de la venta al servidor para que sean almacenados en la base de datos
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (dgvVentas.DataSource == null)
            {
                MessageBox.Show("Debe ingresar primero los productos que se van a vender", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.txtCodigoVenta.Text = ClienteTCP.ObtenerCodigoVenta().ToString();

                foreach (var item in listaVentas)
                {
                    item.Codigo = ClienteTCP.ObtenerCodigoVenta();                    
                }             

                if (ClienteTCP.RegistrarVenta(this.listaVentas) == 0)
                {                    
                    double total = 0;
                    foreach (var dato in this.listaVentas)
                    {
                        total = total + dato.Monto_Total;
                    }

                    this.txtTotalPagar.Text = total.ToString();
                    MessageBox.Show("Venta registrada por un monto total de " + total, "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);                                      

                    this.cbxListaProductos.Enabled = false;
                    this.txtCantidadVendida.Enabled = false;
                    this.btnVender.Enabled = false;
                    this.btnAgregarVenta.Enabled = false;
                    this.btnComprobarProd.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnNuevoCliente.Enabled = true;
                }
                else
                {
                    MessageBox.Show("La cantidad del producto con el código "+ ClienteTCP.RegistrarVenta(this.listaVentas) + " a comprar excede la cantidad en inventario o se encuentra agotado, no es posible proceder con la venta, por favor genere una nueva solicitud","Alto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.btnNuevoCliente.Enabled = true;
                    this.btnVender.Enabled = false;
                }
            }
        }

        //Maneja la funcionalidad de limpiar los datos de la venta realizada para que se pueda proceder con una nueva venta
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            this.listaVentas.Clear();
            this.listaRegistroVentas.Clear();
            this.cbxListaProductos.Enabled = true;
            this.cbxListaProductos.SelectedIndex = -1;
            this.txtCantidadVendida.Enabled = true;
            this.txtCantidadVendida.Text = "";
            this.txtTotalPagar.Text = "";
            this.txtCodigoVenta.Text = "0";
            this.btnVender.Enabled = true;
            this.btnAgregarVenta.Enabled = true;
            this.btnComprobarProd.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnNuevoCliente.Enabled = false;
            this.dgvVentas.DataSource = null;
        }

        //Maneja la funcionalidad de eliminar un producto del listado de productos a vender al clientes del supermercado previo a que se consolide la venta
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvVentas.DataSource == null)
            {
                MessageBox.Show("No hay registros por eliminar", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int indice = this.dgvVentas.CurrentRow.Index, confirmacion = indice+1;

                var opcion = MessageBox.Show("Esta seguro que desea eliminar el producto seleccionado en la fila " + confirmacion, "¡Atención!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (opcion == DialogResult.Yes)
                {
                    this.listaVentas.RemoveAt(indice);
                    this.listaRegistroVentas.RemoveAt(indice);

                    if (this.listaRegistroVentas.Count!=0)
                    {
                        this.dgvVentas.DataSource = null;
                        this.dgvVentas.DataSource = this.listaRegistroVentas;
                    }
                    else
                    {
                        this.dgvVentas.DataSource = null;
                    }
                }                                            
            }           
        }

        //Método para restringir el ingreso de números en el campo de ingreso de nombre en pantalla
        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }
        
        //Método para restringir el ingreso de números en el campo de ingreso de primer apellido en pantalla
        private void txtApellido1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de números en el campo de ingreso de segundo apellido en pantalla
        private void txtApellido2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de texto en el campo de ingreso de cantidad en pantalla
        private void txtCantidadVendida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Método para manejar el evento de cambio de estado de los radiobuttons para seleccionar las opciones de registrar o login de un cajero
        private void rdbRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            //Condicional para controlar el estado de los radioButtons
            if (this.rdbRegistrar.Checked == true)
            {
                this.txtNombre.Enabled = true;
                this.txtApellido1.Enabled = true;
                this.txtApellido2.Enabled = true;
                this.txtID.Enabled = true;
                this.btnRegistrar.Enabled = true;
            }

            //Condicional para controlar el estado de los radioButtons
            if (this.rdbLogin.Checked == true)
            {
                this.txtNombre.Enabled = false;
                this.txtApellido1.Enabled = false;
                this.txtApellido2.Enabled = false;
                this.txtID.Enabled = true;
                this.btnRegistrar.Enabled = true;
            }
        }


        //Método para manejar el evento de cambio de estado de los radiobuttons para seleccionar las opciones de registrar o login de un cajero
        private void rdbLogin_CheckedChanged(object sender, EventArgs e)
        {
            //Condicional para controlar el estado de los radioButtons
            if (this.rdbRegistrar.Checked == true)
            {
                this.txtNombre.Enabled = true;
                this.txtApellido1.Enabled = true;
                this.txtApellido2.Enabled = true;
                this.txtID.Enabled = true;
                this.btnRegistrar.Enabled = true;
            }

            //Condicional para controlar el estado de los radioButtons
            if (this.rdbLogin.Checked == true)
            {
                this.txtNombre.Enabled = false;
                this.txtApellido1.Enabled = false;
                this.txtApellido2.Enabled = false;
                this.txtID.Enabled = true;
                this.btnRegistrar.Enabled = true;
            }
        }

        //Método para manejar el evento de cambio de la caja de texto que contiene el número de caja asignada a un cajero
        private void txtCaja_TextChanged(object sender, EventArgs e)
        {
            this.txtCodigoCajero.Text = this.txtID.Text;
        }

        //Método para manejar el evento de cambio de la caja de texto que contiene el número de código de venta general
        private void txtCodigoVenta_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCodigoVenta.Text.Equals(""))
            {
                this.lblEstadoCodVenta.Text = "";
                this.lblEstadoCodVenta.ForeColor = Color.Red;
            }
            else if (this.txtCodigoVenta.Text.Equals("0"))
            {
                this.lblEstadoCodVenta.Text = "Código pendiente de asignación";
                this.lblEstadoCodVenta.ForeColor = Color.Red;
            }
            else
            {
                this.lblEstadoCodVenta.Text = "Código asignado";
                this.lblEstadoCodVenta.ForeColor = Color.Green;
            }
        }  
    }
}

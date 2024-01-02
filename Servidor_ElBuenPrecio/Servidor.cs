using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Entidades;
using Newtonsoft.Json;
using Datos;

namespace Servidor_ElBuenPrecio
{
    public partial class frmServidor : Form
    {
        //Definición de variables globales
        TcpListener tcpListener;
        Thread subprocesoEscuchaClientes;
        EscribirEnTextboxDelegado modificarTextotxtBitacora;
        ModoficarListBoxDelegado modificarListBoxClientes;
        ManejoDatos accesoDatos = new ManejoDatos();
        private DateTime fecha = DateTime.Today;
        private bool servidorIniciado;                
        private string bitacora ="";
        
        public frmServidor()
        {
            InitializeComponent();

            modificarTextotxtBitacora = new EscribirEnTextboxDelegado(EscribirEnTextbox);
            modificarListBoxClientes = new ModoficarListBoxDelegado(ModificarListBox);
      
            this.lstBContadorClientes.Items.Add("Clientes:\n");            
            this.txtCodigoProd.Enabled = false;
            this.txtDescripcionProd.Enabled = false;
            this.txtPrecioProd.Enabled = false;
            this.cbxCategoriaProd.Enabled = false;
            this.txtCantidadProd.Enabled = false;
            this.txtCajaAsignada.Text = "0";
            this.lblEstado.ForeColor = Color.Red;
            this.lblEstado.Text = "Sin iniciar";
            this.lblFecha.Text = fecha.ToString("d");

            //Limpia el listado del comboBox
            this.cbxActProd.Items.Clear();            
        }

        //Delegado, necesario para modificar controles de la interfaz gráfica desde un subproceso
        private delegate void EscribirEnTextboxDelegado(string texto);
        private delegate void ModoficarListBoxDelegado(string texto, bool agregar);

        //Método utilizado por el delegado para modificar la interfaz gráfica desde un subproceso
        private void EscribirEnTextbox(string texto)
        {
            this.txtBitacora.AppendText(DateTime.Now.ToString() + " - " + texto);
            this.txtBitacora.AppendText(Environment.NewLine);
        }

        //Método utilizado por el delegado para modificar la interfaz gráfica desde un subproceso
        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
            {
                this.lstBContadorClientes.Items.Add(texto);
            }
            else
            {
                this.lstBContadorClientes.Items.Remove(texto);
            }

        }

        //Método para manejar la funcionalidad de iniciar el servidor
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 16380);
            servidorIniciado = true;

            subprocesoEscuchaClientes = new Thread(new ThreadStart(EscucharClientes));
            subprocesoEscuchaClientes.Start();
            subprocesoEscuchaClientes.IsBackground = true;
            this.lblEstado.Text = "Escuchando clientes... en (127.0.0.1, 16830)";
            this.lblEstado.ForeColor = Color.Green;
            this.btnIniciar.Enabled = false;
            this.btnDetener.Enabled = true;
            this.consultarToolStripMenuItem.Enabled = true;
            this.cbxCajPendientes.Enabled = true;
            this.txtCajaAsignada.Enabled = true;
            this.btnActivar.Enabled = true;
            this.txtCodigoCat.Enabled = true;
            this.txtDescripcionCat.Enabled = true;
            this.btnRegistrarCat.Enabled = true;
            this.rdbActualizar.Enabled = true;
            this.rdbRegistrar.Enabled = true;
            this.btnRegistrarProd.Enabled = true;
            this.itmSalir.Enabled = false;

            this.txtBitacora.Text = "Servidor iniciado... en (127.0.0.1, 16830)\n";
        }

        //Método para manejar la funcionalidad de detener el servidor
        private void btnDetener_Click(object sender, EventArgs e)
        {
            servidorIniciado = false;
            tcpListener.Stop();
            subprocesoEscuchaClientes.Abort();

            this.lblEstado.ForeColor = Color.Red;
            this.lblEstado.Text = "Sin iniciar";
            this.btnIniciar.Enabled = true;
            this.btnDetener.Enabled = false;
            this.consultarToolStripMenuItem.Enabled = false;
            this.cbxCajPendientes.Enabled = false;
            this.txtCajaAsignada.Enabled = false;
            this.btnActivar.Enabled = false;
            this.txtCodigoCat.Enabled = false;
            this.txtDescripcionCat.Enabled = false;
            this.btnRegistrarCat.Enabled = false;
            this.rdbActualizar.Enabled = false;
            this.rdbRegistrar.Enabled = false;
            this.btnRegistrarProd.Enabled = false;
            this.itmSalir.Enabled = true;

            this.txtBitacora.Text = "Servidor detenido...\n";
        }

        //Mpetodo para iniciar la escucha de clientes por parte del servidor
        private void EscucharClientes()
        {
            tcpListener.Start();
            while (servidorIniciado)
            {
                //Se bloquea hasta que un cliente se haya conectado al servidor 
                TcpClient client = tcpListener.AcceptTcpClient();
                /*Se crea un nuevo hilo para manejar la comunicación con los clientes que se conectan al servidor*/
                Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                clientThread.Start(client);
            }
        }

        //Método para manejar la comunicación con los clientes por parte del servidor
        private void ComunicacionCliente(object cliente)
        {
            TcpClient tcCliente = (TcpClient)cliente;
            StreamReader reader = new StreamReader(tcCliente.GetStream());
            StreamWriter servidorStreamWriter = new StreamWriter(tcCliente.GetStream());//El StreamWriter debe ser único por subproceso y por cliente por eso se pasa por referencia

            while (servidorIniciado)
            {
                try
                {
                    /*Esta sección se bloquea hasta que el cliente envíe unmensaje*/
                    var mensaje = reader.ReadLine();
                    MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensaje);//Se deserializa el objeto recibido mediante json
                    SeleccionarMetodo(mensajeRecibido.Metodo, mensaje, ref servidorStreamWriter);
                }
                catch (Exception)
                {
                    //Ocurrió un error en el socket 
                    break;
                }
            }

            tcCliente.Close();
        }

        /// Método donde se procesa el mensaje recibido para seleccionar el método que está solicitanto el cliente
        /// <param name="pMetodo">Nombre del método que se debe invocar</param>
        /// <param name="pMensaje">Mensaje enviado por el cliente</param>
        public void SeleccionarMetodo(string pMetodo, string pMensaje, ref StreamWriter servidorStreamWriter)
        {
            switch (pMetodo)
            {
                case "Conectar":
                    MensajeSocket<string> mensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    Conectar(mensajeConectar.Entidad);
                    break;
                case "RegistrarCajero":
                    MensajeSocket<Cajero> mensajeCajero = JsonConvert.DeserializeObject<MensajeSocket<Cajero>>(pMensaje);// Se deserializa el objeto recibido mediante json
                    RegistrarCajero(mensajeCajero.Entidad, ref servidorStreamWriter);
                    break;
                case "LoginCajero":         
                    MensajeSocket<Cajero> mensajeCrearLibro = JsonConvert.DeserializeObject<MensajeSocket<Cajero>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    LoginCajero(mensajeCrearLibro.Entidad, ref servidorStreamWriter);
                    break;
                case "ObtenerProductos":
                    ObtenerProductos(ref servidorStreamWriter);
                    break;
                case "ComprobarCantidad":
                    MensajeSocket<Producto> mensajeComprobarUsuario = JsonConvert.DeserializeObject<MensajeSocket<Producto>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    ComprobarCantidad(mensajeComprobarUsuario.Entidad, ref servidorStreamWriter);
                    break;
                case "ObtenerCodigoVenta":
                    MensajeSocket<string> mensajeCodVenta = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    ObtenerCodigoVenta(ref servidorStreamWriter);
                    break;
                case "ObtenerDatosProd":
                    MensajeSocket<int> mensajeDatosProd = JsonConvert.DeserializeObject<MensajeSocket<int>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    ObtenerDatosProd(mensajeDatosProd.Entidad, ref servidorStreamWriter);
                    break;
                case "RegistrarVenta":
                    MensajeSocket<List<Ventas>> mensajeRegistrarVenta = JsonConvert.DeserializeObject<MensajeSocket<List<Ventas>>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    RegistrarVenta(mensajeRegistrarVenta.Entidad, ref servidorStreamWriter);
                    break;
                case "Desconectar":
                    MensajeSocket<string> mensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                    Desconectar(mensajeDesconectar.Entidad);
                break;
                default:
                    break;
            }
        }

        //Método para escribir en el contro de clientes y en bítácora cuando se conectan los clientes
        private void Conectar(string pIdentificadorCliente)
        {
            this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { pIdentificadorCliente + " se ha conectado..."  });
            this.lstBContadorClientes.Invoke(modificarListBoxClientes, new object[] { pIdentificadorCliente + " Conectado..."  , true });
        }

        //Método para escribir en el control de clientes y en bitácora cuando se desconectan los clientes
        private void Desconectar(string pIdentificadorCliente)
        {
            this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { pIdentificadorCliente + " se ha desconectado..." });
            this.lstBContadorClientes.Invoke(modificarListBoxClientes, new object[] { pIdentificadorCliente + " desconectado..." , true });
        }

        //Método para almacenar en base de datos el registro de nuevos cajeros realizados en el formulario de clientes 
        private void RegistrarCajero(Cajero nuevoCajero, ref StreamWriter servidorStreamWriter)
        {
            bool prueba = accesoDatos.RegCajero(nuevoCajero);            

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(prueba));
            servidorStreamWriter.Flush();

            if (prueba == true)
            {
                bitacora = "Registro de nuevo cajero, pendiente";
                this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { bitacora });
            }
            else
            {
                bitacora = "Registro de nuevo cajero, fallido";
                this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { bitacora });
            }
        }

        //Método para obtener de base de datos la información para enviar al formulario cajero para validar el login 
        private void LoginCajero(Cajero logCajero, ref StreamWriter servidorStreamWriter)
        {            
            logCajero = accesoDatos.ObtnDatosCajero(logCajero);

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(logCajero));
            servidorStreamWriter.Flush();                      
        }

        //Método para obtener de la base de datos el listado de información de los productos almacenados y enviarlo al cajero
        private void ObtenerProductos(ref StreamWriter servidorStreamWriter)
        {
            List<string> listaProductos = new List<string>();

            listaProductos = accesoDatos.obtnListadoDescProductos();      

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listaProductos));
            servidorStreamWriter.Flush();
        }

        //Método para obtener datos de productos de la base de datos para enviarlo al cajero y comprobar la cantidad
        private void ComprobarCantidad(Producto datosProducto, ref StreamWriter servidorStreamWriter)
        {
            datosProducto = accesoDatos.ObtnCantProducto(datosProducto.Codigo);

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(datosProducto.Cantidad_Existente));
            servidorStreamWriter.Flush();
        }

        //Metodo para obtener el código de venta que se utilizará para consolidar la venta final y enviarlo al cajero
        private void ObtenerCodigoVenta(ref StreamWriter servidorStreamWriter)
        {
            int codigoVenta = accesoDatos.ObtnCodigoVenta();

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(codigoVenta));
            servidorStreamWriter.Flush();
        }

        //Método para obtener información de un producto específico y enviarlo al cajero
        private void ObtenerDatosProd(int codProd, ref StreamWriter servidorStreamWriter)
        {
            Producto datosProd = new Producto();

            datosProd = accesoDatos.ObtnDatosProducto(codProd);   

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(datosProd));
            servidorStreamWriter.Flush();
        }

        //Método para obtener información de un producto de la base de datos
        private Producto ObtenerCantProd(int codP)
        {
            Producto datProd = new Producto();

            datProd = accesoDatos.ObtnCantProducto(codP);

            return datProd;
        }

        //Método para realizar el registro de una venta realizada por un cajero en la base de datos
        private void RegistrarVenta(List<Ventas> datoVenta, ref StreamWriter servidorStreamWriter)
        {
            List<Producto> listadoProd = new List<Producto>();                
            bool inventarioExistente = true, prueba = false;
                       
            foreach (var item in datoVenta)
            {
                Producto producto = new Producto();
                producto.Codigo = item.Codigo_Producto;    
                producto.Cantidad_Existente = ObtenerCantProd(producto.Codigo).Cantidad_Existente - item.Cantidad_Vendida;

                if (producto.Cantidad_Existente < 0 )
                {
                    inventarioExistente = false;
                    break;
                }
                else
                {
                    listadoProd.Add(producto);                    
                }                
            }
            
            if (inventarioExistente == true)
            {
                if (accesoDatos.ActCantProductoVenta(listadoProd).Equals("Ok"))
                {
                    prueba = true;                    
                }
                else
                {
                   MessageBox.Show(accesoDatos.ActCantProductoVenta(listadoProd), "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (accesoDatos.RegVenta(datoVenta).Equals("Ok") && prueba)
                {
                    
                   //Se asigna valor cero como indicador de que no ocurrió el break del ciclo foreach que comprueba si aún hay producto existente
                   listadoProd[0].Codigo = 0;
                }
                else
                {
                    MessageBox.Show(accesoDatos.RegVenta(datoVenta), "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }               
            }

            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(listadoProd[0].Codigo));
            servidorStreamWriter.Flush();
        }       

        //Método para manejar la funcionalidad de activar un cajero registrado y que no tenga caja asignada aún
        private void btnActivar_Click(object sender, EventArgs e)
        {
            bool error = false;           

            //Condicional para controlar el ingreso de información por el usuario y mostrar mensaje en caso que no se haya asignado una caja al cliente
            if (this.txtCajaAsignada.Text.Equals("0") || this.txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Es necesario que asigne una caja y seleccione un cajero pendiente de activación antes de continuar", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de activación de cajero fallido" });
            }
            else
            {
                Cajero cajero = new Cajero();

                try
                {
                    //Asignación del valor ingresado por el usuario al objeto
                    cajero.Usuario = this.txtID.Text;
                    cajero.Caja = Int32.Parse(this.txtCajaAsignada.Text);
                    cajero.Nombre = this.txtNombre.Text;

                    error = false; //Asigna un valor a la variable correspondiente
                }
                catch (Exception)
                {
                    error = true; //Asigna un valor a la variable correspondiente
                }

                if (error == true)
                {
                    //Muestra mensaje en pantalla
                    MessageBox.Show("El valor caja asignada ingresado no es correcto o es demasiado grande, favor ingrese un número válido", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de activación fallido" });
                }
                else
                {
                    if (accesoDatos.ActivarCajero(cajero).Equals("Ok"))
                    {
                        bitacora = "Se asignó al usuario: " + cajero.Usuario + " - " + cajero.Nombre + ", a la caja " + cajero.Caja;
                        this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { bitacora });
                    }
                    else
                    {
                        MessageBox.Show(accesoDatos.ActivarCajero(cajero), "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de activación fallido" });
                    }                  
                        this.txtID.Text = "";
                        this.txtNombre.Text = "";
                        this.txtApellido1.Text = "";
                        this.txtApellido2.Text = "";
                        this.txtCajaAsignada.Text = "0";
                        this.cbxCajPendientes.SelectedIndex = -1;                                         
                }                
            }
        }

        //Método para manejar la funcionalidad del botón que registra una categoría nueva en la base de datos
        private void btnRegistrarCat_Click(object sender, EventArgs e)
        {
            //Condicional para controlar el ingreso de información por el usuario y mostrar mensaje en caso que hayan campos de ingreso de datos vacíos
            if (this.txtCodigoCat.Text.Equals("") || this.txtDescripcionCat.Text.Equals(""))
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("Es necesario que ingrese la información en todos los campos solicitados antes de proceder a registrar la información de la categoría", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro de categoría fallido" });
            }
            else
            {
                //Declaración de variable
                bool error;

                Categoria dat = new Categoria(); //Crea el objeto "datos" de la clase "Categoría" para tener acceso a los métodos de la clase
                
                //Prueba sección de código y captura error en caso de presentarse
                try
                {

                    //Asignación del valor ingresado por el usuario al objeto "datos"
                    dat.Codigo = Int32.Parse(this.txtCodigoCat.Text);

                    error = false; //Asigna un valor a la variable correspondiente
                }
                catch (Exception)
                {
                    error = true; //Asigna un valor a la variable correspondiente
                }

                if (error == true)
                {
                    //Muestra mensaje en pantalla
                    MessageBox.Show("El número ingresado no es correcto o es demasiado grande, favor ingrese números válidos", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro de categoría fallido" });
                }
                else
                {
                    dat.Descripcion = this.txtDescripcionCat.Text;

                    if (accesoDatos.RegCategoria(dat) == true)
                    {
                        bitacora = "Se registró una categoría: " + dat.Codigo + " - " + dat.Descripcion;
                        this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { bitacora });

                        MessageBox.Show("Se registró la categoría correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El código ya se encuentra registrado", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro de categoría fallido" });
                    }

                    this.txtCodigoCat.Text = "";
                    this.txtDescripcionCat.Text = "";
                }
            }
        }

        //Método para manejar la funcionalidad del botón de registro o actualización de un producto en la base de datos
        private void btnRegistrarProd_Click(object sender, EventArgs e)
        {
            //Condicional para controlar la operación dependiendo de la selección del radioButton por parte del usuario y mostrar mensaje en pantalla en caso de que no haya selección aún
            if (this.rdbActualizar.Checked == false && this.rdbRegistrar.Checked == false)
            {
                //Muestra mensaje en pantalla
                MessageBox.Show("Debe seleccionar una opción antes de continuar", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro o actualización de producto fallido" });
            }
            else if (this.rdbActualizar.Checked == true)
            {
                //Condicional para presentar mensaje en caso de que el usuario no seleccione un producto
                if (this.cbxActProd.Text.Equals(""))
                {
                    //Muestra mensaje en pantalla
                    MessageBox.Show("Debe seleccionar un producto antes de continuar", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro o actualización de producto fallido" });
                }
                else
                {
                    bool error;

                    Producto datos = new Producto(); //Crea el objeto "datos" de la clase "Producto" para tener acceso a los métodos de la clase                    

                    //Prueba sección de código y captura error en caso de presentarse
                    try
                    {
                        //Asignación del valor ingresado por el usuario al objeto "datos"
                        datos.Cantidad_Existente = Int32.Parse(this.txtCantidadProd.Text);
                        datos.Codigo = Int32.Parse(this.txtCodigoProd.Text);
                        datos.Descripcion = this.txtDescripcionProd.Text;

                        error = false; //Asigna un valor a la variable correspondiente
                    }
                    catch (Exception)
                    {
                        error = true; //Asigna un valor a la variable correspondiente
                    }

                    if (error == true)
                    {
                        //Muestra mensaje en pantalla
                        MessageBox.Show("El valor de cantidad ingresado no es correcto o es demasiado grande, favor ingrese un número válido", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro o actualización de producto fallido" });
                    }
                    else
                    {
                        if (accesoDatos.ActCantInventarioProducto(datos).Equals("Ok"))
                        {
                            bitacora = "Se actualizó a " + datos.Cantidad_Existente + " unidades la cantidad de: ";
                            this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { bitacora });

                            bitacora = datos.Codigo + " - " + datos.Descripcion;
                            this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { bitacora });

                            MessageBox.Show("Se actualizó la cantidad del producto correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(accesoDatos.ActCantInventarioProducto(datos), "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro o actualización de producto fallido" });
                        }
                        
                        this.txtCodigoProd.Text = "";
                        this.txtPrecioProd.Text = "";
                        this.txtCantidadProd.Text = "";
                        this.txtDescripcionProd.Text = "";
                        this.cbxCategoriaProd.SelectedIndex = -1;
                        this.cbxActProd.SelectedIndex = -1;
                    }
                }
            }
            else if (this.rdbRegistrar.Checked == true)
            {
                //Condicional para controlar el ingreso de información por el usuario y mostrar mensaje en caso que hayan campos de ingreso de datos vacíos
                if (this.txtCodigoProd.Text.Equals("") || this.txtPrecioProd.Text.Equals("") || this.txtCantidadProd.Text.Equals("") || this.cbxCategoriaProd.Text.Equals("") || this.txtDescripcionProd.Text.Equals(""))
                {
                    //Muestra mensaje en pantalla
                    MessageBox.Show("Es necesario que ingrese la información en todos los campos solicitados antes de proceder a registrar la información del producto", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro o actualización de producto fallido" });
                }
                else if (Double.Parse(this.txtPrecioProd.Text) == 0 || this.txtCodigoProd.Text.Equals("0")) //Condicional para controlar que no se ingrese un precio de cero por parte del usuario
                {
                    //Muestra mensaje en pantalla
                    MessageBox.Show("Es necesario que el precio y/o el código del producto sea mayor a cero", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro o actualización de producto fallido" });
                }
                else
                {
                    //Declaración de variables
                    String categoria = "", aux;
                    bool error;

                    Producto datos = new Producto(); //Crea el objeto "datos" de la clase "Producto" para tener acceso a los métodos de la clase                    

                    //Prueba sección de código y captura error en caso de presentarse
                    try
                    {
                        //Asignación del valor ingresado por el usuario al objeto "datos"
                        datos.Codigo = Int32.Parse(this.txtCodigoProd.Text);
                        datos.Precio = Double.Parse(this.txtPrecioProd.Text);
                        datos.Cantidad_Existente = Int32.Parse(this.txtCantidadProd.Text);

                        error = false; //Asigna un valor a la variable correspondiente
                    }
                    catch (Exception)
                    {
                        error = true; //Asigna un valor a la variable correspondiente
                    }

                    if (error == true)
                    {
                        //Muestra mensaje en pantalla
                        MessageBox.Show("Uno de los números ingresados no es correcto o es demasiado grande, favor ingrese números válidos", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro o actualización de producto fallido" });
                    }
                    else
                    {
                        aux = this.cbxCategoriaProd.Text; //Asigna valor seleccionado por el usuario a la variable

                        //Ciclo para extraer el código de la categoría seleccionada por el usuario
                        for (int i = 0; i < aux.Length; i++)
                        {
                            if (aux.Substring(i, 1).Equals(" "))
                            {
                                break;
                            }
                            else
                            {
                                categoria += aux.Substring(i, 1);
                            }
                        }
                               
                        //Asignación del valor ingresado por el usuario al objeto "datos"
                        datos.Codigo_Categoria = Int32.Parse(categoria);
                        datos.Descripcion = this.txtDescripcionProd.Text;

                        if (accesoDatos.RegProducto(datos) == true)
                        {
                            bitacora = "Se registró el producto " + datos.Codigo + " - " + datos.Descripcion;
                            this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { bitacora });

                            MessageBox.Show("Se registró el producto correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show("El código ya se encuentra registrado", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            this.txtBitacora.Invoke(modificarTextotxtBitacora, new object[] { "Intento de registro o actualización de producto fallido" });
                        }                    

                        this.txtCodigoProd.Text = "";
                        this.txtPrecioProd.Text = "";
                        this.txtCantidadProd.Text = "";
                        this.txtDescripcionProd.Text = "";
                        this.cbxCategoriaProd.SelectedIndex = -1;
                    }
                }
            }            
        }

        //Método para manejar el evento cuando se selecciona un cajero del combobox respectivo
        private void cbxCajPendientes_SelectedValueChanged(object sender, EventArgs e)
        {
            string usuario = "", aux; //Declaración de variable

            aux = this.cbxCajPendientes.Text; //Asigna valor seleccionado por el usuario a la variable

            //Ciclo para extraer el código del producto seleccionado por el usuario
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux.Substring(i, 1).Equals(" "))
                {
                    break;
                }
                else
                {
                    usuario += aux.Substring(i, 1);
                }
            }

            //Condicional para presentar mensaje en caso de que el usuario no seleccione una categoría
            if (usuario.Equals(""))
            {
            }
            else
            {
                this.txtID.Text = usuario;

                Cajero cajero = accesoDatos.obtnCajerosSelec(usuario);                                                                   
                                       
                this.txtNombre.Text = cajero.Nombre;
                this.txtApellido1.Text = cajero.Primer_Apellido;
                this.txtApellido2.Text = cajero.Segundo_Apellido;
            }
        }

        //Método para manejar el evento de seleccionar un producto del combobox respectivo para actualizar un la cantidad en inventario de un producto
        private void cbxActProd_SelectedValueChanged(object sender, EventArgs e)
        {
            string codigo = "", aux; //Declaración de variable

            aux = this.cbxActProd.Text; //Asigna valor seleccionado por el usuario a la variable

            //Ciclo para extraer el código del producto seleccionado por el usuario
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux.Substring(i, 1).Equals(" "))
                {
                    break;
                }
                else
                {
                    codigo += aux.Substring(i, 1);
                }
            }

            //Condicional para presentar mensaje en caso de que el usuario no seleccione una categoría
            if (codigo.Equals(""))
            {
            }
            else
            {
                this.txtCodigoProd.Text = codigo;

                Producto producto = accesoDatos.obtnProductoSelec(codigo);

                this.txtPrecioProd.Text = producto.Precio.ToString();
                this.txtDescripcionProd.Text = producto.Descripcion;
                this.txtCantidadProd.Text = producto.Cantidad_Existente.ToString();

                this.cbxCategoriaProd.Text = producto.Codigo_Categoria.ToString()+ " - " + producto.Descripcion_Categoria;
            }
        }

        //Método para manejar el evento de desplegar los datos del combobox de productos para actualizar la cantidad en inventario de un producto específico
        private void cbxActProd_DropDown(object sender, EventArgs e)
        {
            this.cbxActProd.DataSource = null;

            List<string> ListaDatosProducto = accesoDatos.obtnListadoDescProductos();

            this.cbxActProd.DataSource = ListaDatosProducto;
        }

        //Método para manejar el evento de desplegar los datos del combobox de categorías para el registro de un producto
        private void cbxCategoriaProd_DropDown_1(object sender, EventArgs e)
        {
            this.cbxCategoriaProd.DataSource = null;

            List<string> ListaDatosCategorias = accesoDatos.obtnListadoDescCategorias();

            this.cbxCategoriaProd.DataSource = ListaDatosCategorias;
        }

        //Método para manejar el evento de desplegar los datos del combobox de cajeros para activar un cajero
        private void cbxCajPendientes_DropDown(object sender, EventArgs e)
        {
            this.cbxCajPendientes.DataSource = null;

            List<string> ListadoCajerosPend = accesoDatos.obtnListadoCajerosPend();

            this.cbxCajPendientes.DataSource = ListadoCajerosPend;
        }


        //Método para restringir el ingreso de létras y caracteres en el campo de ingreso de código en pantalla
        private void txtCodigoProd_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de létras y caracteres en el campo de ingreso de código en pantalla, a excepción del punto decimal
        private void txtPrecioProd_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosDecimales(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de létras y caracteres en el campo de ingreso de código en pantalla
        private void txtCantidadProd_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de létras y caracteres en el campo de ingreso de código en pantalla
        private void txtCodigoCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }

        //Método para restringir el ingreso de létras y caracteres en el campo de ingreso de código en pantalla
        private void txtCajaAsignada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e); //Ejecuta el método estático de la clase "Validaciones" correspondiente
        }
        
        //Método para manejar el evento de cambio de estado de los radiobuttons para seleccionar las opciones de actualizar o registrar un producto
        private void rdbActualizar_CheckedChanged(object sender, EventArgs e)
        {
            //Condicional para controlar el estado de los radioButtons
            if (this.rdbActualizar.Checked == true)
            {
                this.cbxActProd.Enabled = true;
                this.txtCodigoProd.Enabled = false;
                this.txtDescripcionProd.Enabled = false;
                this.txtPrecioProd.Enabled = false;
                this.cbxCategoriaProd.Enabled = false;
                this.txtCantidadProd.Enabled = true;
                this.cbxCategoriaProd.SelectedIndex = -1;
                this.txtCodigoProd.Text = "";
                this.txtPrecioProd.Text = "";
                this.txtCantidadProd.Text = "";
                this.txtDescripcionProd.Text = "";
            }

            //Condicional para controlar el estado de los radioButtons
            if (this.rdbActualizar.Checked == false)
            {
                this.cbxActProd.SelectedIndex = -1;
                this.cbxActProd.Enabled = false;
                this.txtCodigoProd.Enabled = true;
                this.txtDescripcionProd.Enabled = true;
                this.txtPrecioProd.Enabled = true;
                this.cbxCategoriaProd.Enabled = true;
                this.txtCantidadProd.Enabled = true;
                this.txtCodigoProd.Text = "";
                this.txtPrecioProd.Text = "";
                this.txtCantidadProd.Text = "";
                this.txtDescripcionProd.Text = "";
            }
        }

        //Método para manejar el evento de cambio de estado de los radiobuttons para seleccionar las opciones de actualizar o registrar un producto
        private void rdbRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            //Condicional para controlar el estado de los radioButtons
            if (this.rdbActualizar.Checked == true)
            {
                this.cbxActProd.Enabled = true;
                this.txtCodigoProd.Enabled = false;
                this.txtDescripcionProd.Enabled = false;
                this.txtPrecioProd.Enabled = false;
                this.cbxCategoriaProd.Enabled = false;
                this.txtCantidadProd.Enabled = true;
                this.cbxCategoriaProd.SelectedIndex = -1;
                this.txtCodigoProd.Text = "";
                this.txtPrecioProd.Text = "";
                this.txtCantidadProd.Text = "";
                this.txtDescripcionProd.Text = "";
            }

            //Condicional para controlar el estado de los radioButtons
            if (this.rdbActualizar.Checked == false)
            {
                this.cbxActProd.SelectedIndex = -1;
                this.cbxActProd.Enabled = false;
                this.txtCodigoProd.Enabled = true;
                this.txtDescripcionProd.Enabled = true;
                this.txtPrecioProd.Enabled = true;
                this.cbxCategoriaProd.Enabled = true;
                this.txtCantidadProd.Enabled = true;
                this.txtCodigoProd.Text = "";
                this.txtPrecioProd.Text = "";
                this.txtCantidadProd.Text = "";
                this.txtDescripcionProd.Text = "";
            }
        }
        
        //Maneja la función de salir del servidor
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Muestra el formulario respectivo
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarProductos frm = new MostrarProductos();
            frm.Show();

        }

        //Muestra el formulario respectivo
        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarCategorias frm = new MostrarCategorias();
            frm.Show();
        }

        //Muestra el formulario respectivo
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVentas frm = new MostrarVentas();
            frm.Show();
        }

        private void cajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarCajeros frm = new MostrarCajeros();
            frm.Show();
        }


        private void Servidor_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void cbxActProd_DropDownClosed(object sender, EventArgs e)
        {
        }

        private void cbxActProd_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cbxActProd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Servidor_Load(object sender, EventArgs e)
        {
        }
    }
}

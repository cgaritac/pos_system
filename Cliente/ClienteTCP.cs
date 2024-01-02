using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Entidades;
using Newtonsoft.Json;

namespace Cliente
{
    public class ClienteTCP
    {
        //Definición de variable globales
        private static IPAddress ipServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;

        /// <summary>
        /// Conecta el cliente tcp con el servidor
        /// </summary>
        /// <param name="pIdentificadorCliente">Identificador o nombre del cliente</param>
        /// <returns>Retorna true si se conecta con el servidor</returns>
        public static bool Conectar(string pIdentificadorCliente)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 16380);
                cliente.Connect(serverEndPoint);
                MensajeSocket<string> mensajeConectar = new MensajeSocket<string> { Metodo = "Conectar", Entidad = pIdentificadorCliente };

                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                clienteStreamWriter.Flush();


            }
            catch (SocketException err)
            {
                Console.WriteLine(err.ToString());
                return false;
            }

            return true;
        }

        /// <summary>
        /// Desconecta el cliente del servidor
        /// </summary>
        /// <param name="pIdentificadorCliente">Identificador o nombre del cliente</param>
        public static void Desconectar(string pIdentificadorCliente)
        {
            MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Entidad = pIdentificadorCliente };

            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
            clienteStreamWriter.Flush();
            //Se cierra la conexión del cliente
            cliente.Close();
        }

        //Método para enviar flujo de datos al servidor para obtener listado de productos
        public static List<String> ObtenerProductos()
        {
            List<string> listaProductos = new List<string>();

            try
            {
                MensajeSocket<string> mensajeProductos = new MensajeSocket<string> { Metodo = "ObtenerProductos" };

                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeProductos));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                listaProductos = JsonConvert.DeserializeObject<List<string>>(mensaje);

                return listaProductos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Método para enviar flujo de datos al servidor para registrar cajeros
        public static bool RegistrarCajero(Cajero nuevoCajero)
        {
            try
            {
                bool comprobacion;
                MensajeSocket<Cajero> mensajeCajero = new MensajeSocket<Cajero> { Metodo = "RegistrarCajero", Entidad = nuevoCajero };

                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeCajero));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                comprobacion = JsonConvert.DeserializeObject<bool>(mensaje);

                return comprobacion;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para enviar flujo de datos al servidor para el login de cajeros
        public static Cajero LoginCajero(Cajero logCajero)
        {
            try
            {
                Cajero caja;
                MensajeSocket<Cajero> mensajeCajero = new MensajeSocket<Cajero> { Metodo = "LoginCajero", Entidad = logCajero };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeCajero));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                caja = JsonConvert.DeserializeObject<Cajero>(mensaje);
                
                return caja;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para enviar flujo de datos al servidor para comprobar la cantidad de un producto 
        public static int ComprobarCantidad(Producto codigoProducto)
        {
            try
            {
                int cantidadProd;
                MensajeSocket<Producto> mensajeCajero = new MensajeSocket<Producto> { Metodo = "ComprobarCantidad", Entidad = codigoProducto };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeCajero));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                cantidadProd = JsonConvert.DeserializeObject<int>(mensaje);

                return cantidadProd;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para enviar flujo de datos al servidor para obtener el código de venta de la base de datos 
        public static int ObtenerCodigoVenta()
        {
            int codVenta = 0;

            try
            {                
                MensajeSocket<string> mensajeCodVenta = new MensajeSocket<string> { Metodo = "ObtenerCodigoVenta" };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeCodVenta));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                codVenta = JsonConvert.DeserializeObject<int>(mensaje);

                return codVenta;
            }
            catch (Exception)
            {
                return codVenta;
                throw;
            }
        }

        //Método para enviar flujo de datos al servidor para obtener los datos de un producto de la base de datos
        public static Producto ObtenerDatosProd(int codigoProd)
        {
            try
            {
                Producto datosProd = new Producto();
                MensajeSocket<int> mensajeDatProd = new MensajeSocket<int> { Metodo = "ObtenerDatosProd", Entidad = codigoProd };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDatProd));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                datosProd = JsonConvert.DeserializeObject<Producto>(mensaje);

                return datosProd;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para enviar flujo de datos al servidor para registrar una venta en la base de datos 
        public static int RegistrarVenta(List<Ventas> datoVenta)
         {
            try
            {
                int codigoProd;
                MensajeSocket<List<Ventas>> mensajedatoVenta = new MensajeSocket<List<Ventas>> { Metodo = "RegistrarVenta", Entidad = datoVenta };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajedatoVenta));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                codigoProd = JsonConvert.DeserializeObject<int>(mensaje);

                return codigoProd;
            }
            catch (Exception)
            {
                throw;
            }
         }
    }
}

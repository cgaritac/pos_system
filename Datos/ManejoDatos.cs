using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace Datos
{
    public class ManejoDatos
    {
        private SqlConnectionStringBuilder bldr = new SqlConnectionStringBuilder(); //Crea el objeto "bldr" de la clase "SqlConnectionStringBuilder" para tener acceso a los métodos de la clase

        public ManejoDatos()
        {
            //Manejo de la base de datos, apertura de la conexión e ingreso de datos a la base de datos
            bldr.DataSource = ".\\SQLEXPRESS";
            bldr.InitialCatalog = "BuenPrecio";
            bldr.IntegratedSecurity = true;
        }              

        //Método para manejar el registro en base de datos de una categoría de producto
        public bool RegCategoria(Categoria datos)
        {
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            string SQL = "INSERT into Categoria(Codigo, Descripcion)";
            SQL += " VALUES ('" + datos.Codigo + "', '" + datos.Descripcion + "')";
            try
            {
                conx.Open();
                SqlCommand comandoInsertar = new SqlCommand(SQL, conx);
                comandoInsertar.ExecuteNonQuery();
                conx.Close(); //Cierra la conexión  

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Método para manejar la obtención de la descripción de categorías de acuerdo a su código de la base de datos
        public List<string> obtnListadoDescCategorias()
        {
            List<string> ListaDatosCategorias = new List<string>();
            
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Categoria", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al comboBox
            while (registro.Read())
            {
                ListaDatosCategorias.Add(registro["Codigo"].ToString() + " - " + registro["Descripcion"].ToString());
            }

            conx.Close(); //Cierra la conexión

            return ListaDatosCategorias;
        }

        //Método para obtener de la base de datos el listado de categorías registrado
        public List<Categoria> ObtnListadoCategorias()
        {
            //Crea el objeto "lista" de la clase "List<Categoria>" para tener acceso a los métodos de la clase
            List<Categoria> lista = new List<Categoria>();

            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Categoria", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto categoria para agregarlo a la colección generica lista de objetos
            while (registro.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Codigo = Convert.ToInt32(registro["Codigo"]);
                categoria.Descripcion = registro["Descripcion"].ToString();

                lista.Add(categoria); //Agrega el objeto a la lista
            }
            conx.Close(); //Cierra la conexión

            return lista;
        }

        //Método para obtener de la base de datos el listado de descripciones de productos de acuerdo a su código respectivo
        public List<string> obtnListadoDescProductos()
        {
            List<string> ListaDatosProducto = new List<string>();

            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Producto", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.HasRows)
            {
                //Ciclo que recorre los registros de la base de datos y asigna los registros al comboBox
                while (registro.Read())
                {
                    ListaDatosProducto.Add(registro["Codigo"].ToString() + " - " + registro["Descripcion"].ToString());
                }
            }              

            conx.Close(); //Cierra la conexión

            return ListaDatosProducto;     
        }    

        //Método para obtener de la base de datos, la información de un producto respectivo
        public Producto obtnProductoSelec(string codigo)
        {
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("Select Producto.Codigo, Producto.Descripcion, Precio, Cantidad, CodigoCategoria, Categoria.Descripcion as DescripcionCategoria from Producto Inner Join Categoria On Producto.CodigoCategoria = Categoria.Codigo Where Producto.Codigo =" + codigo, conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            Producto producto = new Producto();

            while (registro.Read())
            {

                producto.Descripcion = registro["Descripcion"].ToString();
                producto.Precio = Convert.ToDouble(registro["Precio"]);
                producto.Cantidad_Existente = Convert.ToInt32(registro["Cantidad"]);
                producto.Codigo_Categoria = Convert.ToInt32(registro["CodigoCategoria"]);
                producto.Descripcion_Categoria = registro["DescripcionCategoria"].ToString();
            }

            conx.Close(); //Cierra la conexión

            return producto;
        }

        //Método para actualizar en la base de datos el inventario de un producto respectivo
        public string ActCantInventarioProducto(Producto datos)
        {
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            String SQL = "Update Producto Set Cantidad = " + datos.Cantidad_Existente + "Where Codigo = " + datos.Codigo;

            try
            {
                conx.Open();
                SqlCommand comandoActualizar = new SqlCommand(SQL, conx);
                comandoActualizar.ExecuteNonQuery();                
                conx.Close(); //Cierra la conexión  

                return "Ok";

            }
            catch (Exception err)
            {
                return err.ToString();
            }            
        }

        //Método para registrar en la base de datos un producto respectivo
        public bool RegProducto(Producto datos)
        {    
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            String SQL = "INSERT into Producto(Codigo, Descripcion, Precio, Cantidad, CodigoCategoria)";
            SQL += " VALUES ('" + datos.Codigo + "', '" + datos.Descripcion + "', '" + datos.Precio + "', '" + datos.Cantidad_Existente + "', '" + datos.Codigo_Categoria + "')";

            try
            {
                conx.Open();
                SqlCommand comandoInsertar = new SqlCommand(SQL, conx);
                comandoInsertar.ExecuteNonQuery();
                conx.Close(); //Cierra la conexión 

                return true;
            }
            catch (Exception)
            {
                return false;
            }             
        }

        //Método para obtener de la base de datos la cantidad de un producto respectivo
        public Producto ObtnCantProducto(int codP)
        {
            Producto datProd = new Producto();

            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Producto Where Codigo = " + codP, conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al comboBox
            registro.Read();

            datProd.Precio = Convert.ToDouble(registro["Precio"]);
            datProd.Cantidad_Existente = Convert.ToInt32(registro["Cantidad"]);
            datProd.Descripcion = registro["Descripcion"].ToString();

            conx.Close(); //Cierra la conexión  

            return datProd;
        }

        //Método para obtener de la base de datos, la información de un producto respectivo
        public Producto ObtnDatosProducto(int codProd)
        {
            Producto datosProd = new Producto();
            
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Producto Where Codigo = " + codProd, conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al comboBox
            registro.Read();

            datosProd.Precio = Convert.ToDouble(registro["Precio"]);
            datosProd.Cantidad_Existente = Convert.ToInt32(registro["Cantidad"]);
            datosProd.Descripcion = registro["Descripcion"].ToString();

            conx.Close(); //Cierra la conexión    

            return datosProd;
        }

        //Método para actualizar la cantidad de producto con base en una venta
        public string ActCantProductoVenta(List<Producto> listadoProd)
        {
            SqlConnection conn = new SqlConnection(bldr.ConnectionString);
            string SQL = "";
            try
            {
                conn.Open();

                foreach (var item in listadoProd)
                {
                    SQL = "Update Producto	Set Cantidad = " + item.Cantidad_Existente + "Where Codigo = " + item.Codigo;
                    SqlCommand comandoActualizar = new SqlCommand(SQL, conn);
                    comandoActualizar.ExecuteNonQuery();
                }
                conn.Close(); //Cierra la conexión  
                return "Ok";
            }
            catch (Exception er)
            {
                return er.ToString();
            }
        }

        //Método para obtener la información de un listado de productos
        public List<Producto> ObtnListadoProductos()
        {
            //Crea el objeto "lista" de la clase "List<Producto>" para tener acceso a los métodos de la clase
            List<Producto> lista = new List<Producto>();                                           

            SqlConnection conx = new SqlConnection(bldr.ConnectionString);

            //Manejo de la base de datos y apertura de la conexión
            SqlCommand comando = new SqlCommand("Select Producto.Codigo, Producto.Descripcion, Precio, Cantidad, CodigoCategoria, Categoria.Descripcion as DescripcionCategoria from Producto Inner Join Categoria On Producto.CodigoCategoria = Categoria.Codigo", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto producto para agregarlo a la colección generica lista de objetos
            while (registro.Read())
            {
                Producto producto = new Producto();
                producto.Codigo = Convert.ToInt32(registro["Codigo"]);
                producto.Descripcion = registro["Descripcion"].ToString();
                producto.Precio = Convert.ToDouble(registro["Precio"]);
                producto.Cantidad_Existente = Convert.ToInt32(registro["Cantidad"]);
                producto.Codigo_Categoria = Convert.ToInt32(registro["CodigoCategoria"]);
                producto.Descripcion_Categoria = registro["DescripcionCategoria"].ToString();

                lista.Add(producto); //Agrega el objeto a la lista
            }
            conx.Close(); //Cierra la conexión

            return lista;
        }

        //Método para registrar un cajero
        public bool RegCajero(Cajero nuevoCajero)
        {
            SqlConnection conx2 = new SqlConnection(bldr.ConnectionString);

            string SQL = "INSERT into Cajero(Usuario, Nombre, PrimerApellido, SegundoApellido, CajaAsignada, Activo)";
            SQL += " VALUES ('" + nuevoCajero.Usuario + "', '" + nuevoCajero.Nombre + "', '" + nuevoCajero.Primer_Apellido + "', '" + nuevoCajero.Segundo_Apellido + "', '" + nuevoCajero.Caja + "', '" + nuevoCajero.Activo + "')";
            try
            {
                SqlCommand comandoInsertar = new SqlCommand(SQL, conx2);
                conx2.Open();
                comandoInsertar.ExecuteNonQuery();
                conx2.Close(); //Cierra la conexión      

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Método para obtener los datos de un cajero para el login
        public Cajero ObtnDatosCajero(Cajero logCajero)
        {
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);

            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Cajero WHERE Usuario = " + "'" + logCajero.Usuario + "'", conx);
                conx.Open();
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    logCajero.Nombre = registro["Nombre"].ToString();
                    logCajero.Primer_Apellido = registro["PrimerApellido"].ToString();
                    logCajero.Segundo_Apellido = registro["SegundoApellido"].ToString();
                    logCajero.Caja = Convert.ToInt32(registro["CajaAsignada"]);
                    int activo = Convert.ToInt32(registro["Activo"]);

                    if (activo == 0)
                    {
                        logCajero.Activo = false;

                    }
                    else
                    {
                        logCajero.Activo = true;
                    }
                    conx.Close(); //Cierra la conexión
                }
                else
                {
                    logCajero.Caja = 0;
                }                    

                return logCajero;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para obtener datos específicos de un cajero
        public Cajero obtnCajerosSelec(string usuario)
        {
            try
            {                
                SqlConnection conx = new SqlConnection(bldr.ConnectionString);
                SqlCommand comando = new SqlCommand("Select * from Cajero Where Usuario =" + "'" + usuario + "'", conx);
                conx.Open();
                SqlDataReader registro = comando.ExecuteReader();

                Cajero cajero = new Cajero();

                while (registro.Read())
                {
                    cajero.Nombre = registro["Nombre"].ToString();
                    cajero.Primer_Apellido = registro["PrimerApellido"].ToString();
                    cajero.Segundo_Apellido = registro["SegundoApellido"].ToString();
                }

                conx.Close(); //Cierra la conexión

                return cajero;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Método para obtener de la base de datos el listado de cajeros pendiente
        public List<string> obtnListadoCajerosPend()
        {
            List<string> ListadoCajerosPend = new List<string>();
            
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Cajero WHERE Activo = 0", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al comboBox
            while (registro.Read())
            {
                ListadoCajerosPend.Add(registro["Usuario"].ToString() + " - " + registro["Nombre"].ToString());
            }

            conx.Close(); //Cierra la conexión

            return ListadoCajerosPend;
        }

        //Método actualizar la base de datos cuando se activa un cajero
        public string ActivarCajero(Cajero cajero)
        {
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("Select * From Cajero where CajaAsignada = " + cajero.Caja, conx);

            try
            {
                conx.Open();
                SqlDataReader registro = comando.ExecuteReader();

                registro.Read();

                cajero.Usuario = registro["Usuario"].ToString();

                conx.Close(); //Cierra la conexión

                return "La caja ya se encuentra asignada, por favor asigne otro número de caja";
            }
            catch (Exception)
            {
                SqlConnection conx2 = new SqlConnection(bldr.ConnectionString);
                String SQL = "Update Cajero Set Activo = " + 1 + ", " + "CajaAsignada = " + cajero.Caja + "Where Usuario = " + "'" + cajero.Usuario + "'";

                try
                {
                    conx2.Open();
                    SqlCommand comandoActualizar = new SqlCommand(SQL, conx2);
                    comandoActualizar.ExecuteNonQuery();
                    conx2.Close(); //Cierra la conexión 

                    return "Ok";
                }
                catch (Exception err2)
                {
                    return err2.ToString();
                }
            }
        }                                    

        //Método para obtener la información de un listado de cajeros de la base de datos
        public List<Cajero> ObtnListadoCajeros()
        {
            //Crea el objeto "lista" de la clase "List<Cajero>" para tener acceso a los métodos de la clase
            List<Cajero> lista = new List<Cajero>();
            int activo = 0;

            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT * FROM Cajero", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto cajero para agregarlo a la colección generica lista de objetos
            while (registro.Read())
            {
                Cajero cajero = new Cajero();
                cajero.Usuario = registro["Usuario"].ToString();
                cajero.Nombre = registro["Nombre"].ToString();
                cajero.Primer_Apellido = registro["PrimerApellido"].ToString();
                cajero.Segundo_Apellido = registro["SegundoApellido"].ToString();
                cajero.Caja = Convert.ToInt32(registro["CajaAsignada"]);
                activo = Convert.ToInt32(registro["Activo"]);

                if (activo == 1)
                {
                    cajero.Activo = true;
                }
                else
                {
                    cajero.Activo = false;
                }

                lista.Add(cajero); //Agrega el objeto a la lista
            }
            conx.Close(); //Cierra la conexión

            return lista;
        }

        //Método para obtener el código de venta a utilizar con base en los registros de la base de datos
        public int ObtnCodigoVenta()
        {
            int codigoVenta = 0;

            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("SELECT TOP 1 * FROM Ventas ORDER BY LineaVenta Desc", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                try
                {
                    codigoVenta = Convert.ToInt32(registro["CodigoVenta"]) + 1;
                    conx.Close(); //Cierra la conexión  
                    return codigoVenta;
                }
                catch (Exception)
                {
                    conx.Close(); //Cierra la conexión  
                    throw;
                }
            }
            else
            {
                conx.Close(); //Cierra la conexión  
                return codigoVenta = 1;
            }    
        }                                    

        //Método para registrar una venta
        public string RegVenta(List<Ventas> datoVenta)
        {
            SqlConnection conx = new SqlConnection(bldr.ConnectionString);

            try
            {
                conx.Open();

                foreach (var dato in datoVenta)
                {
                    String SQL = "INSERT into Ventas(CodigoVenta, CodigoCajero, FechaVenta, CodigoProducto, PrecioProducto, Cantidad, MontoTotal)";
                    SQL += " VALUES ('" + dato.Codigo + "', '" + dato.Codigo_Cajero + "', '" + dato.Fecha_Venta + "', '" + dato.Codigo_Producto + "', '" + dato.Precio_Producto + "', '" + dato.Cantidad_Vendida + "', '" + dato.Monto_Total + "')";
                    SqlCommand comandoInsertar = new SqlCommand(SQL, conx);
                    comandoInsertar.ExecuteNonQuery();
                }
                conx.Close(); //Cierra la conexión  

                return "Ok";
            }
            catch (Exception er)
            {
                return er.ToString();
            }
        }

        //Método para obtener la información de un listado de ventas
        public List<Ventas> ObtnListadoVentas()
        {
            //Crea el objeto "lista" de la clase "List<Ventas>" para tener acceso a los métodos de la clase
            List<Ventas> lista = new List<Ventas>();

            SqlConnection conx = new SqlConnection(bldr.ConnectionString);
            SqlCommand comando = new SqlCommand("Select Ventas.CodigoVenta, Ventas.CodigoCajero, Ventas.FechaVenta, Ventas.CodigoProducto, Producto.Precio, Ventas.Cantidad, Ventas.MontoTotal from Ventas inner Join Producto on Producto.Codigo = Ventas.CodigoProducto", conx);
            conx.Open();
            SqlDataReader registro = comando.ExecuteReader();

            //Ciclo que recorre los registros de la base de datos y asigna los registros al objeto cajero para agregarlo a la colección generica lista de objetos
            while (registro.Read())
            {
                Ventas venta = new Ventas();
                venta.Codigo = Convert.ToInt32(registro["CodigoVenta"]);
                venta.Codigo_Cajero = registro["CodigoCajero"].ToString();
                venta.Fecha_Venta = registro["FechaVenta"].ToString();
                venta.Codigo_Producto = Convert.ToInt32(registro["CodigoProducto"]);
                venta.Cantidad_Vendida = Convert.ToInt32(registro["Cantidad"]);
                venta.Monto_Total = Convert.ToDouble(registro["MontoTotal"]);
                venta.Precio_Producto = Convert.ToDouble(registro["Precio"]);

                lista.Add(venta); //Agrega el objeto a la lista
            }
            conx.Close(); //Cierra la conexión

            return lista;
        }
    }
}

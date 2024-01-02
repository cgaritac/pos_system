using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    public class Ventas
    {
        //Definición de variables globales
        private int codigo, cantidadVendida, codigoProducto;
        private double montoTotal, precioProducto;
        private String fechaVenta, codigoCajero;

        //Constructor
        public Ventas()
        {
                
        }

        //Metodo de get y set de la variable correspondiente
        public int Codigo
        {
            get { return codigo; }

            set { codigo = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Codigo_Cajero
        {
            get { return codigoCajero; }

            set { codigoCajero = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Fecha_Venta
        {
            get { return fechaVenta; }

            set { fechaVenta = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public int Codigo_Producto
        {
            get { return codigoProducto; }

            set { codigoProducto = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public double Precio_Producto
        {
            get { return precioProducto; }

            set { precioProducto = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public int Cantidad_Vendida
        {
            get { return cantidadVendida; }

            set { cantidadVendida = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public double Monto_Total
        {
            get { return montoTotal; }

            set { montoTotal = value; }
        }
    }
}
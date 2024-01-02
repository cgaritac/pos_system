using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    [Serializable]
    class RegistroVentas
    {
        //Definición de variables globales
        private int cantidadVendida, codigoProducto;
        private double montoTotal, precioProducto;

        //Constructor
        public RegistroVentas()
        {
                
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    //Clase para manejar la información de los productos
    public class Producto
    {
        //Definición de variables globales
        private double precio;
        private int codigoProducto, cantidadExistente, categoriaProducto;
        private string descripcionProducto, DescCategoriaProducto;

        //Constructor
        public Producto()
        {
                
        }

        //Metodo de get y set de la variable correspondiente
        public int Codigo
        {
            get { return codigoProducto; }

            set { codigoProducto = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Descripcion
        {
            get { return descripcionProducto; }

            set { descripcionProducto = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public double Precio
        {
            get { return precio; }

            set { precio = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public int Cantidad_Existente
        {
            get { return cantidadExistente; }

            set { cantidadExistente = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public int Codigo_Categoria
        {
            get { return categoriaProducto; }

            set { categoriaProducto = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Descripcion_Categoria
        {
            get { return DescCategoriaProducto; }

            set { DescCategoriaProducto = value; }
        }
    }
}
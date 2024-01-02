using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    //Clase para manejar la información de las categorías
    public class Categoria
    {
        //Definición de variables globales
        private int codigoCategoria;
        private string descripcionCategoria;

        //Constructor
        public Categoria()
        {
                
        }

        //Metodo de get y set de la variable correspondiente
        public int Codigo
        {
            get { return codigoCategoria; }

            set { codigoCategoria = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Descripcion
        {
            get { return descripcionCategoria; }

            set { descripcionCategoria = value; }
        }
    }
}

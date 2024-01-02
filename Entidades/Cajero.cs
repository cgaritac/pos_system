using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    [Serializable]
    //Clase para manejar la información de los cajeros
    public class Cajero
    {
        //Definición de variables globales
        private string usuario, nombre, apellido1, apellido2;
        private int caja;
        private bool activo;

        //Constructor
        public Cajero()
        {
                
        }

        //Metodo de get y set de la variable correspondiente
        public string Usuario
        {
            get { return usuario; }

            set { usuario = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Primer_Apellido
        {
            get { return apellido1; }

            set { apellido1 = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public string Segundo_Apellido
        {
            get { return apellido2; }

            set { apellido2 = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public int Caja
        {
            get { return caja; }

            set { caja = value; }
        }

        //Metodo de get y set de la variable correspondiente
        public bool Activo
        {
            get { return activo; }

            set { activo = value; }
        }
    }
}

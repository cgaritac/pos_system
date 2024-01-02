using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Servidor_ElBuenPrecio
{
    //Clase para manejar las validaciones
    class Validaciones
    {
        //Método para permitir el ingreso de letras por parte del usuario
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Por favor ingrese solamente letras", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //Método para permitir el ingreso de números por parte del usuario
        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Por favor ingrese solamente numeros", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //Método para permitir el ingreso de números con decimales por parte del usuario
        public static void SoloNumerosDecimales(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Por favor ingrese solamente numeros o numeros con punto decimal mayores a cero", "¡Alto!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
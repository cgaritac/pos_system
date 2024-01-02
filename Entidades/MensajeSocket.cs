using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    /// <summary>
    /// Clase utilizada para enviar mensajes entre el cliente y el servidor
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class MensajeSocket<T>
    {
        /// <summary>
        /// Propiedad utilizada para indicar el nombre del método que debe ejecutarse en el servidor
        /// </summary>
        public string Metodo { get; set; }

        /// <summary>
        /// Propiedad utilizada para enviar la entidad que se debe procesar en el método solicitado por el cliente
        /// La entidad puede ser de cualquier tipo, se debe indicar al momento de crear la instancia de la clase
        /// </summary>
        public T Entidad { get; set; }
    }
}

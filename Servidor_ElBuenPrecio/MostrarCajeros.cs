using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Datos;

namespace Servidor_ElBuenPrecio
{
    public partial class MostrarCajeros : Form
    {
        ManejoDatos accesoDatos = new ManejoDatos();

        public MostrarCajeros()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Cajero>" para tener acceso a los métodos de la clase
            List<Cajero> lista = new List<Cajero>();

            lista = accesoDatos.ObtnListadoCajeros();            

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvCajeros.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvCajeros.Columns[2].HeaderText = "Primer Apellido";
            this.dgvCajeros.Columns[3].HeaderText = "Segundo Apellido";
            this.dgvCajeros.Columns[4].HeaderText = "Caja Asignada";

            //Muestra mensaje en pantalla
            MessageBox.Show("Datos actualizados con éxito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarCajeros_Load(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Cajero>" para tener acceso a los métodos de la clase
            List<Cajero> lista = new List<Cajero>();

            lista = accesoDatos.ObtnListadoCajeros();

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvCajeros.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvCajeros.Columns[2].HeaderText = "Primer Apellido";
            this.dgvCajeros.Columns[3].HeaderText = "Segundo Apellido";
            this.dgvCajeros.Columns[4].HeaderText = "Caja Asignada";
        }
    }
}

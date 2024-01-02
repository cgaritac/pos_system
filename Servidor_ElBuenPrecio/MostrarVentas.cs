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
    public partial class MostrarVentas : Form
    {
        ManejoDatos accesoDatos = new ManejoDatos();

        public MostrarVentas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarVentas_Load(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Cajero>" para tener acceso a los métodos de la clase
            List<Ventas> lista = new List<Ventas>();

            //Llama al método para obtener el listado de ventas de la base de datos
            lista = accesoDatos.ObtnListadoVentas();

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvVentas.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvVentas.Columns[0].HeaderText = "Código Venta";
            this.dgvVentas.Columns[1].HeaderText = "Código Cajero";
            this.dgvVentas.Columns[2].HeaderText = "Fecha Venta";
            this.dgvVentas.Columns[3].HeaderText = "Codigo Producto";
            this.dgvVentas.Columns[4].HeaderText = "Precio Unitario Producto";
            this.dgvVentas.Columns[5].HeaderText = "Cantidad Vendida";
            this.dgvVentas.Columns[6].HeaderText = "Monto Total";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Cajero>" para tener acceso a los métodos de la clase
            List<Ventas> lista = new List<Ventas>();
            
            //Llama al método para obtener el listado de ventas de la base de datos
            lista = accesoDatos.ObtnListadoVentas();
            
            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvVentas.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvVentas.Columns[0].HeaderText = "Código Venta";
            this.dgvVentas.Columns[1].HeaderText = "Código Cajero";
            this.dgvVentas.Columns[2].HeaderText = "Fecha Venta";
            this.dgvVentas.Columns[3].HeaderText = "Codigo Producto";
            this.dgvVentas.Columns[4].HeaderText = "Precio";
            this.dgvVentas.Columns[5].HeaderText = "Cantidad Vendida";
            this.dgvVentas.Columns[6].HeaderText = "Monto Total";

            //Muestra mensaje en pantalla
            MessageBox.Show("Datos actualizados con éxito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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
    public partial class MostrarProductos : Form
    {
        ManejoDatos accesoDatos = new ManejoDatos();

        public MostrarProductos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarProductos_Load(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Producto>" para tener acceso a los métodos de la clase
            List<Producto> lista = new List<Producto>();

            lista = accesoDatos.ObtnListadoProductos();

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvProductos.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvProductos.Columns[0].HeaderText = "Código Producto";
            this.dgvProductos.Columns[1].HeaderText = "Descripción Producto";
            this.dgvProductos.Columns[3].HeaderText = "Cantidad Existente";
            this.dgvProductos.Columns[4].HeaderText = "Código Categoría";
            this.dgvProductos.Columns[5].HeaderText = "Descripción Categoría";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Categoria>" para tener acceso a los métodos de la clase
            List<Producto> lista = new List<Producto>();

            lista = accesoDatos.ObtnListadoProductos();

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvProductos.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvProductos.Columns[0].HeaderText = "Código Producto";
            this.dgvProductos.Columns[1].HeaderText = "Descripción Producto";
            this.dgvProductos.Columns[3].HeaderText = "Cantidad Existente";
            this.dgvProductos.Columns[4].HeaderText = "Código Categoría";
            this.dgvProductos.Columns[5].HeaderText = "Descripción Categoría";

            //Muestra mensaje en pantalla
            MessageBox.Show("Datos actualizados con éxito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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
    //Clase para mostrar el listado completo de registros de categorías almacenadas en la base de datos
    public partial class MostrarCategorias : Form
    {
        ManejoDatos accesoDatos = new ManejoDatos();

        //Método constructor
        public MostrarCategorias()
        {
            InitializeComponent(); //Inicializa los componentes del formulario
        }

        //Método para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarCategorias_Load(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Categoria>" para tener acceso a los métodos de la clase
            List<Categoria> lista = new List<Categoria>();

            lista = accesoDatos.ObtnListadoCategorias();            

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvCategorias.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvCategorias.Columns[0].HeaderText = "Código";
            this.dgvCategorias.Columns[1].HeaderText = "Descripción";
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            //Crea el objeto "lista" de la clase "List<Categoria>" para tener acceso a los métodos de la clase
            List<Categoria> lista = new List<Categoria>();

            lista = accesoDatos.ObtnListadoCategorias();

            //Asigna los valores de la colección genérica lista de objetos a la tabla en pantalla
            this.dgvCategorias.DataSource = lista;

            //Cambia los títulos de columnas específicas de la tabla
            this.dgvCategorias.Columns[0].HeaderText = "Código";
            this.dgvCategorias.Columns[1].HeaderText = "Descripción";

            //Muestra mensaje en pantalla
            MessageBox.Show("Datos actualizados con éxito", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

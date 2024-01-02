/*
Universidad: UNED
Curso:        Programación Avanzada
Código:       00830
Tema:         Proyecto final
Estudiante:   Carlos Garita Campos
Periodo:      II Cuatrimestre 2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cliente;
using Servidor_ElBuenPrecio;

namespace Inicio
{
    public partial class frmInicio : Form
    {
        //Declaración de variables globales
        bool inicioServ = false;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        //Método para el manejo de la funcionalidad de llamar al formulario servidor
        private void btnServidor_Click(object sender, EventArgs e)
        {
            if (inicioServ)
            {                
                 MessageBox.Show("El servidor ya se encuentra iniciado", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Stop);                               
            }
            else
            { 
                frmServidor frm = new frmServidor();
                frm.Show();
                inicioServ = true;
            }
        }

        //Método para el manejo de la funcionalidad de llamar al formulario cajero
        private void btnCajero_Click(object sender, EventArgs e)
        {
            if (!inicioServ)
            {
                MessageBox.Show("Es necesario que inicie primeramente el servidor", "Alto", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmCliente frm = new frmCliente();
                frm.Show();
            }
        }

        //Método para manejar el cierre del formulario inicio, para que finalice por completo el programa
        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        //Método para manejar la opción de salir del formulario inicio, para que finalice por completo el programa
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

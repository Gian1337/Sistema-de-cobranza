using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cola miCola = new Cola();

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if(txtCliente.Text.Length == 0)
            {
                MessageBox.Show("Error al cargar un cliente");
            }
            else
            {
                cliente unNuevoCliente = new cliente();
                unNuevoCliente.Nombre = txtCliente.Text; 
                miCola.Encolar(unNuevoCliente);
                Mostrar_Cola();
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacio())
            {
                MessageBox.Show("No hay ningun cliente");
            }
            else
            {
                miCola.Desencolar();
                Mostrar_Cola();
            }
        }

        private void Mostrar_Cola()
        {
            lstCola.Items.Clear();
            MostrarCliente(miCola.Inicio);
        }

        private void MostrarCliente(cliente unCliente)
        {
            if(unCliente != null)
            {
                lstCola.Items.Add(unCliente.Nombre);


                if (unCliente.Siguiente != null)
                {
                    MostrarCliente(unCliente.Siguiente);
                }
            
            }
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Teoria se encuentra en cliente.cs");
        }
    }
}

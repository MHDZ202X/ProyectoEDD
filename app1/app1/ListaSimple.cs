using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class ListaSimple : Form
    {
        ListaSimple1 lista;
        public ListaSimple()
        {
            InitializeComponent();
            lista = new ListaSimple1();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string nombre = txtNombre.Text;
            NodolistaS n = new NodolistaS(numero, nombre, null);
            // lista.Head = n;
            lista.Agregar(n);

            txtNombre.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtNumero.Focus();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuenta: " + lista.CuentaNodos());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista: " + lista.ToString());
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            lista.Vaciar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            string nombre = txtNombre.Text;
            NodolistaS n = new NodolistaS(numero, nombre, null);
            //Lista.head = n;
            lista.eliminar(numero);
        }


    }
}

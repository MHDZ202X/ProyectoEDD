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
    public partial class ListaCircularSimple : Form
    {
        NodoListaCircular n;
        private ListaCircular MiLista = new ListaCircular();
        public ListaCircularSimple()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MiLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new NodoListaCircular();
                    n.Dato = int.Parse(txtNodo.Text);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                }
                else
                {
                    MessageBox.Show("El dato ya existe en la lista.");
                    txtNodo.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void btnEliminarNodo_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtEliminar.Text);

                if (!MiLista.BuscarDato(dato))
                {
                    MessageBox.Show("No se encontró el dato");
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                    return;
                }
                MiLista.Borrar(dato);
                lblLista.Text = MiLista.ToString();
                txtEliminar.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Número de nodos en la lista:" + MiLista.ContarNodos());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMostrar.Text = MiLista.ToString();
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog Dialogo = new FolderBrowserDialog();
            //if (Dialogo.ShowDialog() == DialogResult.OK)
            //{
            //    string dato = lblLista.Text;
            //    string ruta = Dialogo.SelectedPath + "\\ListaN.txt";
            //    using (var writer = new StreamWriter(ruta))
            //    {
            //        writer.Close();
            //    }
            //    File.WriteAllText(ruta, dato);
            //    MessageBox.Show("Datos guardados.");
            //}
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //OpenFileDialog Seleccionar = new OpenFileDialog();
            //if (Seleccionar.ShowDialog() == DialogResult.OK)
            //{
            //    MiLista.Head = null;
            //    int contador = 0;
            //    string ruta = Seleccionar.FileName;
            //    string linea = File.ReadAllText(ruta);
            //    string[] Lista = linea.Split(',');
            //    foreach (string i in Lista)
            //    {
            //        n = new NodoListaCircular();
            //        n.Dato = int.Parse(Lista[contador]);
            //        MiLista.Agregar(n);
            //        lblLista.Text = MiLista.ToString();
            //        contador++;
            //    }
            //}
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            MiLista.Head = null;
            lblLista.Text = MiLista.ToString();
            lblMostrar.Text = MiLista.ToString();
        }
    }
}

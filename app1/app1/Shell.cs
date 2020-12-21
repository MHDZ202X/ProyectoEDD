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
    public partial class Shell : Form
    {
        Random aleatorio;
        Shell arrayshell;
        int[] v;

        DateTime inicio;
        DateTime final;
        TimeSpan duracion;
        public Shell()
        {
            InitializeComponent();

            arrayshell = new Shell();
            aleatorio = new Random();

            lblTiempo.Visible = false;
            label4.Visible = false;
            txtLista.Visible = false;
            btnLista.Visible = false;

            btnRandom.Visible = false;

            label2.Visible = false;
            ltbDesordenados.Visible = false;
            label1.Visible = false;
            ltbOrdenados.Visible = false;

            btnLimpiar.Visible = false;
            btnShell.Visible = false;
        }

        int valor, i = 0;

    
        private void btnRandom_Click(object sender, EventArgs e)
        {
            ltbDesordenados.Items.Clear();

            aleatorio = new Random();

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = aleatorio.Next(10000);
                ltbDesordenados.Items.Add(v[i]);
            }

            label4.Visible = false;
            txtLista.Visible = false;
            btnLista.Visible = false;
            btnRandom.Visible = false;

            label2.Visible = true;
            ltbDesordenados.Visible = true;
            label1.Visible = true;
            ltbOrdenados.Visible = true;

            btnLimpiar.Visible = true;
            btnShell.Visible = true;
        }
        private void btnShell_Click(object sender, EventArgs e)
        {
            inicio = DateTime.Now;
            arrayshell.MetodoShell(v);
            final = DateTime.Now;
            duracion = final - inicio;
            lblTiempo.Text = "Tiempo Transcurrido: " + duracion;
            for (int i = 0; i < v.Length; i++)
            {
                ltbOrdenados.Items.Add(v[i]);

            }
            lblTiempo.Visible = true;
            btnShell.Visible = false;
        }

        private void MetodoShell(int[] v)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introducir el tamaño del Arreglo", "Aviso");
                return;
            }

            v = new int[int.Parse(textBox1.Text)]; //Tamaño del arreglo
            ltbDesordenados.Items.Clear();

            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;

            label4.Visible = true;
            txtLista.Visible = true;
            btnLista.Visible = true;

            btnRandom.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ltbDesordenados.Items.Clear();
            ltbOrdenados.Items.Clear();
            textBox1.Clear();

            lblTiempo.Visible = false;
            label4.Visible = false;
            txtLista.Visible = false;
            btnLista.Visible = false;

            btnRandom.Visible = false;

            label2.Visible = false;
            ltbDesordenados.Visible = false;
            label1.Visible = false;
            ltbOrdenados.Visible = false;

            btnLimpiar.Visible = false;
            btnShell.Visible = false;

            label3.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            if (txtLista.Text == "")
            {
                MessageBox.Show("Ingrese los Valores");
                return;
            }
            valor = int.Parse(txtLista.Text);
            v[i++] = valor;
            ltbDesordenados.Items.Add(v[i - 1]);
            txtLista.Clear();
            txtLista.Focus();

            btnRandom.Visible = false;

            label2.Visible = true;
            ltbDesordenados.Visible = true;
            label1.Visible = true;
            ltbOrdenados.Visible = true;

            btnLimpiar.Visible = true;
            btnShell.Visible = true;
        }


    }
}
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
    public partial class Pila : Form
    {
        Pila1 lista;

        Pilas objeto = new Pilas();
        public Pila()
        {
            InitializeComponent();
            lista = new Pila1();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtMaxim.Text);
            objeto = new Pilas(m);
            MessageBox.Show("Pila Creada");
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int n;             //Boton que crea los valore
            n = int.Parse(txtNum.Text);
            objeto.push(n);
            txtNum.Clear();
            txtNum.Focus();


            if (txtNum.Text == "")
            {
                PilaPush.Items.Insert(0, n);
                PilaPush.SetSelected(0, true);
            }
            else
            {
                PilaPush.Items.Insert(0, txtNum.Text);
                return;
            }
            Pilas pila = new Pilas();
            if (pila.pila_llena() == true)
            {

            }
            txtNum.Focus();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            int n;
            n = objeto.pop();          //indica que este valor se eliminara
            PilaPush.SetSelected(0, true);
            LblPop.Text = PilaPush.SelectedItem.ToString();
            PilaPush.Items.RemoveAt(0);
            Pilapop.Items.Insert(0, LblPop.Text);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Pilapop.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

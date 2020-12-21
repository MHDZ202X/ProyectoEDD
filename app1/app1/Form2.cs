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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnListasimple_Click(object sender, EventArgs e)
        {
            ListaSimple LS = new ListaSimple();
            LS.Show();
        }

        private void btnListDobleMenteEnlazada_Click(object sender, EventArgs e)
        {
            ListaDoblementeEnlazada LDE = new ListaDoblementeEnlazada();
            LDE.Show();
        }

        private void btnCircular_Click(object sender, EventArgs e)
        {
            ListaCircularSimple LCS = new ListaCircularSimple();
            LCS.Show();
        }

        private void btnCircular2ble_Click(object sender, EventArgs e)
        {
            ListaCircularDoble LCD = new ListaCircularDoble();
            LCD.Show();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            ColaSimple CS = new ColaSimple();
            CS.Show();
        }

        private void btnGrafos_Click(object sender, EventArgs e)
        {
            Grafo GRA = new Grafo();
            GRA.Show();
        }

        private void btnArbol_Click(object sender, EventArgs e)
        {
            ArbolBin ARB = new ArbolBin();
            ARB.Show();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            Pila PI = new Pila();
            PI.Show();
        }
    }
}

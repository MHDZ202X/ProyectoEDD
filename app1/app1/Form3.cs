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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            Burbuja BUR = new Burbuja();
            BUR.Show();
        }

        private void btnCocktail_Click(object sender, EventArgs e)
        {
            Cocktail COC = new Cocktail();
            COC.Show();
        }

        private void btnCounting_Click(object sender, EventArgs e)
        {
            Counting COUN = new Counting();
            COUN.Show();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            Shell SHE = new Shell();
            SHE.Show();
        }

        private void btnRadix_Click(object sender, EventArgs e)
        {
            Radix RAD = new Radix();
            RAD.Show();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstructura_Click(object sender, EventArgs e)
        {
            Form EDD = new Form2();
            EDD.Show();
        }

        private void btnOrdenamiento_Click(object sender, EventArgs e)
        {
            Form3 MET = new Form3();
            MET.Show();
        }
    }
}

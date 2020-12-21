using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace app1
{
    public partial class ListaCircularDoble : Form
    {
        ListaCircular2 milista;
        public ListaCircularDoble()
        {
            InitializeComponent();
            milista = new ListaCircular2();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            NodoCircular2 n;
            int d = Int32.Parse(txtdato.Text);
            n = new NodoCircular2();
            n.Dato = d;
            n.Siguiente = null; //este comando ya existe
            n.Atras = null;
            milista.Agregar(n);
            txtdato.Clear();
            txtdato.Focus();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblContar.Text = milista.MostrarDatos();
            lblContarDes.Text = milista.MostrarDatosAnt();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (milista.Buscar(int.Parse(txtdato.Text)))
            {
                buscando.Text = "Si esta";
            }
            else
            {
                buscando.Text = "No esta";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            milista.Eliminar(int.Parse(txtdato.Text));
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            label2.Text = milista.ContarNodos() + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmDatos x = new FrmDatos();
            //x.Show();
            //this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Archivo CSV|*.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<string> filas = new List<string>();

                List<string> cabeceras = new List<string>();
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    cabeceras.Add(col.HeaderText);
                }
                string SEP = txtSEP.Text;
                filas.Add(string.Join(SEP, cabeceras));

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    try
                    {

                        List<string> celdas = new List<string>();
                        foreach (DataGridViewCell c in fila.Cells)
                            celdas.Add(c.Value.ToString());

                        filas.Add(string.Join(SEP, celdas));
                    }
                    catch (Exception ex)
                    { }
                }

                File.WriteAllLines(sfd.FileName, filas);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int m = dataGridView1.Rows.Add();
            //colocamos la nueva informacion 
            dataGridView1.Rows[m].Cells[0].Value = lblContar.Text;
        }
        //private void btnAbrir_Click_1(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog() { Filter = "Archivo CSV|*.csv" };
        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        string SEP = txtSEP.Text;

        //        string[] lineas = File.ReadAllLines(ofd.FileName);
        //        string[] cabeceras = lineas[0].Split(new[] { SEP }, StringSplitOptions.None);

        //        dataGridView1.Columns.Clear();
        //        foreach (string c in cabeceras)
        //            dataGridView1.Columns.Add(c, c);

        //        for (int i = 1; i < lineas.Length; i++)
        //        {
        //            string[] celdas = lineas[i].Split(new[] { SEP }, StringSplitOptions.None);
        //            dataGridView1.Rows.Add(celdas);
        //        }
        //    }
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    class Pila1
    {
        private NodoPila head;

        public NodoPila Head
        {
            get { return head; }
            set { head = value; }
        }

        public Pila1()
        {
            head = null;
        }
        public Pila1(NodoPila head)
        {
            this.head = head;
        }

        public void Agregar(NodoPila n)
        {
            if (head == null)
            {
                head = n;
                return;
            }
            if (n.Dato < head.Dato)
            {
                n.Sig = head;
                head = n;
                return;
            }

            NodoPila h = head;
            while (h.Sig != null)
            {
                if (n.Dato < h.Sig.Dato)
                {
                    break;
                }
                h = h.Sig;
            }
            //Final
            if (h.Sig == null)
            {
                h.Sig = n;
                return;
            }
            n.Sig = h.Sig;
            h.Sig = n;

        }


        public void Eliminar()
        {

            if (head == null)
            {

                MessageBox.Show("La Cola esta vacia");
                return;
            }
            else
            {
                MessageBox.Show("Salio :" + head);

                head = head.Sig;
                return;

            }


            //while (head != null)  { if (true) {   }}




        }


        public override string ToString()
        {
            string regreso = "";
            NodoPila h = head;

            while (h != null)
            {
                regreso += h.Dato + " ";
                h = h.Sig;
            }
            return regreso;
        }
    }
}


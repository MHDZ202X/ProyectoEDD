using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    class Pilas
    {
        static void main(string[] args)
        {
            int[] array1 = { 1 };
            int[] array2 = { 0, 0, 0, 0, 0 };
        }
        private int Maximo; //valor maximo de la pila
        private int Cima;
        private int[] LaPila; // vector que alacena lla info en la pila
        public Pilas() { }
        public Pilas(int max)
        {
            LaPila = new int[max];
            Maximo = max;
            Cima = -1;
        }
        public Boolean pila_llena()
        {
            if (Cima == Maximo - 1)  //Si cima es igual a +1 o la pila esta llena, es verdad
            { return true; }
            else
            { return false; }
        }
        public Boolean pila_Vacia()
        {
            if (Cima == -1)  //Si cima es igual a -1 o la pila esta vacia, es verdad
                return true;
            else
                return false;
        }
        public void push(int n) //ocuparemos en el push el valor n que se ocupara cada vez que agreguemos un valor
        {

            if (pila_llena() == true)
            {
                MessageBox.Show("Pila Llena");

            }

            else

            {
                Cima++; LaPila[Cima] = n;
            }


        }


        public int pop() //si pila vacia es igual a true mandara mensaje que esta vacia
        {
            int n = 0;
            if (pila_Vacia() == true)
            {

                return n;
            }
            else
            {
                n = LaPila[Cima];
                Cima = -1;
                return n;
            }
        }

    }
}

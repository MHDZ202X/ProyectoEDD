using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class NodoCircular2
    {
        private int dato;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        //tiene un apuntador al siguiente nodo
        private NodoCircular2 siguiente;
        public NodoCircular2 Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        // y tiene un apuntador al nodo anterior
        private NodoCircular2 atras;

        public NodoCircular2 Atras
        {
            get { return atras; }
            set { atras = value; }
        }

        public NodoCircular2()
        {
            dato = 0;
            siguiente = null;


        }
        public NodoCircular2(int dato, NodoCircular2 siguiente)
        {
            this.Dato = dato;
            this.Siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}

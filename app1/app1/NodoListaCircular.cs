using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class NodoListaCircular
    {
        private int dato;
        private NodoListaCircular siguiente;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoListaCircular Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public NodoListaCircular()
        {
            dato = 0;
            siguiente = null;
        }

        public NodoListaCircular(int dato, NodoListaCircular siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
     class NodoListaDoblementeEnla
    {

        private int dato;
        private NodoListaDoblementeEnla siguiente;
        private NodoListaDoblementeEnla anterior;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoListaDoblementeEnla Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public NodoListaDoblementeEnla Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public NodoListaDoblementeEnla(int dato, NodoListaDoblementeEnla siguiente, NodoListaDoblementeEnla anterior)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.anterior = anterior;
        }

        public NodoListaDoblementeEnla()
        {
            dato = 0;
            siguiente = null;
            anterior = null;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}

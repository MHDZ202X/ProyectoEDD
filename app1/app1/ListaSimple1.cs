using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    public class ListaSimple1
    {
        private NodolistaS head;

        public NodolistaS Head
        {
            get { return head; }
            set { head = value; }
        }
        public ListaSimple1()
        {
            head = null;
        }
        public ListaSimple1(NodolistaS x)
        {
            head = x;
        }
        //METODO
        public void Agregar(NodolistaS n)
        {
            //LA LISTA ESTA VACIA :) :B
            if (head == null)
            {
                head = n;
                return;
            }

            //INSERCION AL INICIO
            if (n.Numero < head.Numero)
            {
                n.Siguiente = head;
                head = n;
                return;
            }

            //CIPIAR A HEAD..... PARA PODER RECORRER
            NodolistaS h = head;
            while (h.Siguiente != null)
            {
                if (n.Numero < h.Siguiente.Numero)
                {
                    break;
                }
                h = h.Siguiente;
            }
            n.Siguiente = h.Siguiente;
            h.Siguiente = n;

        }
        public int CuentaNodos()
        {
            int cuenta = 0;
            NodolistaS h = head;
            while (h != null)
            {
                cuenta++;
                h = h.Siguiente;
            }
            return cuenta;
        }

        public void Vaciar()
        {
            head = null;
        }

        public override string ToString()
        {
            string lista = "";
            NodolistaS h = head;
            while (h != null)
            {
                lista += h.Numero + " ";
                h = h.Siguiente;
            }

            return lista;
        }
        public bool Buscar(int b)
        {

            NodolistaS h = head;
            while (h != null)
            {
                if (h.Numero == b)
                {
                    return true;
                }

                h = h.Siguiente;
            }
            return false;
        }
        public void eliminar(int n)
        {
            NodolistaS h = head;
            while (h != null)
            {
                NodolistaS anterior, nodo;
                nodo = head;
                anterior = null;

                while (nodo != null && nodo.Numero < n)
                {
                    anterior = nodo;
                    nodo = nodo.Siguiente;
                }
                if (nodo == null || nodo.Numero != n)
                {
                    return;
                }
                else
                {
                    if (anterior == null)
                    {
                        head = nodo.Siguiente;
                    }
                    else
                    {
                        anterior.Siguiente = nodo.Siguiente;
                    }
                }
                h = h.Siguiente;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class Shell1
    {
        public void MetodoShell(int[] arreglo)
        {
            int salto = 0;
            int sw = 0;
            int auxiliar = 0;
            int e = 0;
            salto = arreglo.Length / 2; // Tamaño del arreglo / 2 ... 10/2... salto = 5

            while (salto > 0) // Mientras salto (5) sea mayor a 0
            {
                sw = 1;
                while (sw != 0) //Mientras sw (1) se diferente de 0... 1 es diferente de 0.
                {
                    sw = 0;
                    e = 1;
                    while (e <= (arreglo.Length - salto)) // Mientras e (1) es menor o igual a el tamaño del arreglo (10)
                                                          // menos salto (5). 1 <= (10-5)... Mientras 1 <= 5.
                    {
                        if (arreglo[e - 1] > arreglo[(e - 1) + salto]) // Si el numero en el arreglo [e-1]  (arreglo en la posicion 0)
                                                                       // es mayor a el numero en el arreglo ([e-1] + salto)
                                                                       // (arreglo en la pisicion 5)
                        {
                            auxiliar = arreglo[(e - 1) + salto];
                            arreglo[(e - 1) + salto] = arreglo[e - 1];
                            arreglo[e - 1] = auxiliar;
                            sw = 1;
                        }
                        e++; //e equivale a 0 al primer momento, icrementa 1 en 1 
                    }
                }
                salto = salto / 2; //salto /2... 5/2 = 2
            }

        }
    }
}

from os import system

system("cls")

from lista_circular import ListaCircular

lista = ListaCircular()


lista.agregarfinal(10)
lista.agregarfinal(25)
lista.agregarfinal(65)
lista.agregarfinal(88)
lista.agregarfinal(96)


lista.agregarinicio(8)
lista.agregarinicio(5)


lista.ReniverInicio()

lista.Recorrer()

print("primero:",lista.primero.dato)
print("ultimo",lista.ultimo.dato)
print("ultimo.siguiente apunta a :",lista.ultimo.siguiente.dato)
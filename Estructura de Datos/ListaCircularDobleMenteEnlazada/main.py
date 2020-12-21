from os import system
system("cls")

from Lista_Circular_Doblemente_Enlazada import ListaCurcularDobleEnlazada1

lista = ListaCurcularDobleEnlazada1()

lista.agregar_final(12)
lista.agregar_final(45)
lista.agregar_final(18)
lista.agregar_final(36)
lista.agregar_final(10)

lista.eliminarfinal()

lista.recorrer_inicio_a_fin()
print("*" * 25)
lista.recorrer_fin_a_inicio()

print("Dato encontrado:",lista.buscar(10))
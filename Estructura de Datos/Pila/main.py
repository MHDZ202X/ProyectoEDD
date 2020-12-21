from pila import Pila1

Pila = Pila1(5)

Pila.push(10)
Pila.push(15)
Pila.push(75)
Pila.push(55)


Pila.pop()

Pila.show()

print("Size: %d"%(Pila.Size()))
print("Estad:",Pila.empty())
print("Top: %d"%(Pila.Top()))
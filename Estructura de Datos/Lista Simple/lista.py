class Nodo:
    def __init__(self, nombre=None, cedula=None, sig=None):
        self.nombre = nombre
        self.cedula = cedula
        self.sig = sig

    def __str__(self):
        return "%s %s" %(self.nombre,self.cedula)

class Lsimple:
    def __init__(self):
        self.cabeza = None
        self.cola = None

    def agregar(self,elemento):
        if self.cabeza == None:
            self.cabeza = elemento

        if self.cola != None:
            self.cola.sig = elemento

        self.cola = elemento
    
    def listar(self):
        aux = self.cabeza
        while aux != None:
            print(aux)
            aux = aux.sig
        
if __name__ =="__main__":
    lis = Lsimple()

    while(True):
        print("--menu--\n"+
          "1.Agregar\n"
          "2.Listar\n" )

        num = input("ingrese opcion:")
        if num == "1":
            nombre = input("ingrese el nombre :")
            cedula = input("ingrese la cedula :")
            nod = Nodo(nombre, cedula)
            lis.agregar(nod)
        elif num == "2":
            lis.listar()


            
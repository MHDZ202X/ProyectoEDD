from nodo import Nodo

class arbolbin:
    def __init__(self):
        self.root = None

    def empty(self):
        if self.root == None:
            return True
        else:
            return False
    
    def add(self,value):
        if self.empty():
            self.root = Nodo(value = value, is_root=True)
        else:
            nodo = self.__get_place(value)
            if value <= nodo.value:
                nodo.left = Nodo(value=value, parent=nodo, is_right = True)
            else:
                nodo.right = Nodo(value=value, parent=nodo, is_right = True)
                
    def __get_place(self,value):

        aux = self.root
        while aux:
            temp = aux
            if value <= aux.value:
                aux=aux.left
            else:
                aux = aux.right
        return temp

    def show_in_order(self,nodo):
        if nodo:
            self.show_in_order(nodo.left)
            print(nodo.value)
            self.show_in_order(nodo.right)

    def show_pre_order(self,nodo):
        if nodo:
            print(nodo.value)
            self.show_pre_order(nodo.left)
            self.show_pre_order(nodo.right)
            
    def show_pos_order(self,nodo):
        if nodo:
            self.show_pos_order(nodo.left)
            self.show_pos_order(nodo.right)
            print(nodo.value)

    def  search(self,nodo,value):
        if nodo == None:
            return None
        else:
            if nodo.value == value:
                return nodo
            elif value <= nodo.value:
                return self.search(nodo.left, value)
            else:
                return self.search(nodo.right, value)

                
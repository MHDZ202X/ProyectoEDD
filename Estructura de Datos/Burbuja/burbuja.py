def bubblesort( array ):
    length = len(array) - 1
    
    for i in range(0, length):
        print(f"pasada#{i + 1}")
        for j in range(0, length):
            print(f"comparacion:{array[j]}>{array[j + 1]}")
            if array[j] > array  [ j + 1 ]:
                aux = array[j]
                array[j] = array[ j + 1 ]
                array[j + 1] =  aux
        print(f"listas{array}")
    return array

scores = [70, 90, 0, 80, 60, 85]
print("antes de ordenar:")
print(scores)
print("despues de ordenar:")
bubblesort(bubblesort(scores))
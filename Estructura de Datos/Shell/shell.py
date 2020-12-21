def shellsort( array ):
    length = len(array)
    interval = length //2  

    while interval > 0:
        print(f"===intervalo:{interval}===")
        for i in range(interval,length):
            insert_value = array[i]
            insert_index = i
            print(f"{array[insert_index-interval]}>{insert_value}")

            while insert_index >= interval and array[insert_index-interval]>insert_value:
                array[insert_index] = array[insert_index-interval]
                insert_index -= interval
            
            array [insert_index] = insert_value
        
        interval //=2

    return array

scores = [70, 90, 0, 80, 60, 85]

print("antes de ordenar:")
print(scores)
print("despues de ordenar:")
print(shellsort(scores))
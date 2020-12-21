import sys

Mylista  = [0,25,56,68,-45,-9,5,44,-15,10]

x = int(0)
y=len(Mylista)
while x<y:
    if x == 0 or Mylista[x]>= Mylista[x-1]:
        x=x+1

    else:
        temporal = Mylista[x-1]
        Mylista[x-1] = Mylista[x]
        Mylista[x] = temporal
        x=x-1
result =(Mylista)
print(result)
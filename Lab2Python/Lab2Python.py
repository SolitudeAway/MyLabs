a=int(input("Ввести число 1: "))
b=int(input("Ввести число 2: "))
c=int(input("Ввести число 3: "))

if (a >= c):
    if (b > c):
        sum = a + b
    else:
        sum = a + c    
elif (b >= c):
    sum = b + c
elif (a > b):
    sum = a + c
else:
    sum = b + c
print("Отримана сума: ", sum)
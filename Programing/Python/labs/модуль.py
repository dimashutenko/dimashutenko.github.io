import random
print('Task 14\n')
mylist =[]
n=input('Enter n: ')
print('List 1', end=': ')
i=0
while i<int(n):
    variable = (random.randint(0,100))
    if variable%2==0:
        mylist.append(variable)
        print(variable, end=' ')
        i+=1
mylist.clear()
print('\nList 2', end=': ')
i=0
variable = (random.randint(0,20))
while i<int(n):
    variable+= 3
    mylist.append(variable)
    print(variable, end=' ')
    i+=1
mylist.clear()
print('\nList 3', end=': ')
i=0
while i<int(n):
    variable = (random.randint(0,10))
    mylist.append(variable)
    if variable%3==0:
        print(variable**3, end=' ')
    else:
        print(variable, end=' ')
    i+=1
print('\n\nTask 15\n')
print('\nList 1', end=': ')
for i in range(41):
    if 3<=i and i%3==0:
        print(str(i), end=' ')
print('\nList 2', end=': ')
for i in range(81):
    if i%5==0:
        print(str(i), end=' ')

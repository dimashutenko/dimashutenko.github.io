import random
list1=[]
for i in range(10):
    list1.append(random.randint(-1,1))
print('list:',list1)
index=list1.index(0)
list1=list1[(index+1):len(list1)]
print(list1)

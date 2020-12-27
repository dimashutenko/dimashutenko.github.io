#Задано список (в). Написати програму, яка визначить суму елементів тих рядків, 
# у яких на побічної діагоналі стоять невід‘ємні числа.
import random
list1=[]
list2=[]
list3=[]
list4=[]
list5=[]
result=[]
i=0
while i<5:
    list1.append(random.randint(-10,10))
    list2.append(random.randint(-10,10))
    list3.append(random.randint(-10,10))
    list4.append(random.randint(-10,10))
    list5.append(random.randint(-10,10))
    result.append(0)
    i+=1
mylist=[list1,list2,list3,list4,list5]
for thislist in mylist:
    print('\n\n\n')
    for element in thislist:
        print('   ',element,end='      ')
        if element>=0 and thislist.index(element)==4-mylist.index(thislist):
            for elem in thislist:
                #result[mylist.index(thislist)]+=elem
                variable=result[mylist.index(thislist)]+elem
                result[mylist.index(thislist)]=variable
print('\n\nresult: ',result)

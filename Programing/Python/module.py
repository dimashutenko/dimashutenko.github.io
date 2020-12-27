import random
list1=[]
list2=[]
list3=[]
i=0
while i<5:
    list1.append(random.randint(-10,10))
    list2.append(random.randint(-10,10))
    list3.append(random.randint(-10,10))
    i+=1
mylist=[list1,list2,list3]
min_elem_3_collumn=10
min_elem_4_collumn=10
sum_1_row=0
for elem in list1:
        if elem%2==0:
            sum_1_row+=elem
for thislist in mylist:
    print('                ',thislist)
    for element in range(3):
        if thislist[3]<=min_elem_3_collumn:
            min_elem_3_collumn=thislist[3]
        if thislist[4]<=min_elem_4_collumn:
            min_elem_4_collumn=thislist[4]
print('\nmin elem in 3 collumn:',min_elem_3_collumn)
print('min elem in 4 collumn:',min_elem_4_collumn)
print('sum of even numbers of 1 row:',sum_1_row)

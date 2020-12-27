school={'1a':'25','2a':'24','3a':'23','4a':'22','5a':'21','6a':'20','7a':'19','8a':'18','9a':'17','10a':'26'}
print('current info about classes and students: '+str(school))
SearchQuery=input('Enter class: ')
print('In class '+SearchQuery+' '+school[SearchQuery]+' students')
change_class = input('\nChange time, choose class to change number of students: ')
change_number = input('enter new number of students in class '+change_class + ': ')
for Class in school.keys():
    if Class == change_class:
        school[Class] = change_number
print(school)
new_class=input('\nEnter class ro be formed: ')
school[new_class] = input('enter number of students in new class '+new_class + ': ')
print('\ncurrent info about classes and students: '+str(school))
delete_class=input('\nEnter class ro be removed: ')
del school[delete_class]
print('\ncurrent info about classes and students: '+str(school))

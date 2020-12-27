text = 'тестовий текст, аа бб ввв гггг'
chars = list(text)
print(text)
results=[]
max_counter = 0
counter = 0
letter='`'
for i in range(len(chars)):
    if i<len(chars)-1:
        if chars[i] == chars[i+1]:
            counter+=1
            letter=chars[i]
        elif chars[i] != chars[i+1]:
            counter = 0
        if chars[i] == chars[i+1] and counter>=1:
            results.append([])
            results[-1].append(letter)
            results[-1].append(counter+1)
print(results)
count=0
j=0
while j<len(results):
    if j < (len(results)-1):
        if results[j][0] == results[j+1][0]:
            #print (results[j],end=' - deleted')
            del results[j]
            j-=1
            count+=1
    j+=1
print('\nresults',results)
maximum=0
maximum_letter='`'
for i in range(len(results)):
    if results[i][1]>=maximum:
        maximum = results[i][1]
        maximum_letter = results[i][0]
print('Найбільше повторень у літери ', maximum_letter)



word_list = ['hello', 'world', 'my', 'name', 'is', 'Anna']
char = 'o'
newlist = []

for i in word_list:
    if i.find(char) > -1:
        newlist.append(i)
print newlist

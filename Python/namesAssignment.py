students = [
     {'first_name':  'Michael', 'last_name': 'Jordan'},
     {'first_name': 'John', 'last_name': 'Rosales'},
     {'first_name': 'Mark', 'last_name': 'Guillen'},
     {'first_name': 'KB', 'last_name': 'Tonel'}
]


def names(x):
    characters = 0
    counter = 0
    for i in x:
        counter += 1
        name = i['first_name'] + " " + i['last_name']
        characters = len(i['first_name'] + i['last_name'])
        print counter, name, characters

names(students)

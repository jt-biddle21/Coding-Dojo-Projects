def typelist(l):
    string = ""
    sum = 0
    for i in l:
        if isinstance(i, str):
            string = string + i
        if isinstance(i, (int, float)):
            sum = sum + i
    print string, sum
    if string == "":
        print "Your list is of integer type!"
    if sum == 0:
        print "Your list is of the mixed type!"

typelist(["10", "10", "20", "98.98", "100"])

def odd_even():
    for i in range(2000):
        if i % 2 == 1:
            print "Number is", i, "which is an odd number"
        if i % 2 == 0:
            print "Number is", i, "which is an even number"

print odd_even()

def multiply(x, y):
    for i in range(len(x)):
        x[i] = x[i] * y
    print x


multiply([2, 2, 2, 2, 2], 2)

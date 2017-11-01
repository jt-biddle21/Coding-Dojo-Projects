def cointoss():
    heads = 0
    tails = 0
    for i in range(1, 5001):
        import random
        x = random.randint(0, 1)
        if x == 1:
            heads += 1
            print "Attempt", "#", i, "It's heads!", "You got", heads, "head(s) so far and", tails, "tail(s) so far!"
        elif x == 0:
            tails += 1
            print "Attempt", "#", i, "It's tails!", "You got", heads, "head(s) so far and", tails, "tail(s) so far!"


cointoss()




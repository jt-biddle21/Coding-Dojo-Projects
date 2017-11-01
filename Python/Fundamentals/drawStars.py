def draw_stars(x):
    for i in range(len(x)):
        if isinstance(x[i], str):
            print x[i][0] * len(x[i])
        else:
            print "* " * x[i]


draw_stars([1, "bob", 2, 4])

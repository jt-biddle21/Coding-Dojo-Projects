def filtertype(x):
    if isinstance(x, str):
        if len(x) >= 50:
            print "Thats a long sentence!"
        elif len(x) < 50:
            print "Thats a short sentence!"
    elif isinstance(x, list):
        if len(x) >= 10:
            print "Thats a long list!"
        elif len(x) < 10:
            print "Thats a short list!"
    elif isinstance(x, int):
        if x >= 100:
            print "Thats a large number!"
        elif x < 100:
            print "Thats a small number!"

filtertype()


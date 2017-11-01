count = 0
for i in range(10):
    checkerboard = ""
    if count == 0:
        checkerboard += "* " * 5
        count = count + 1
        print checkerboard
    elif count == 1:
        checkerboard += " *" * 5
        count = count - 1
        print checkerboard

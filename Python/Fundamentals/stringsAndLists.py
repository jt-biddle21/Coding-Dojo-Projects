words = "It's thanksgiving day. It's my birthday, too!"
print words.find("day")
print words.replace("day", "month")

x = [2, 54, -2, 7, 12, 98]
print max(x)
print min(x)

y = ["hello", 2, 54, -2, 7, 12, 98, "world"]
print y[0]
print y[-1]
for i in range(len(y)/2):
    print (y[i], y[-1-i])

z = [19, 2, 54, -2, 7, 12, 98, 32, 10, -3, 6]
z.sort()
print z
v = z[:len(z)/2]
w = z[len(z)/2:]
print v
print w
w.insert(0, v)
print w

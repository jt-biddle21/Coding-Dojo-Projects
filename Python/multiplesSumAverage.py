for i in range(1, 1000, 2):
    print i

for i in range(5, 1000000, 5):
    print i

# ^^^^Multiples^^^^

a = [1, 2, 5, 10, 255, 3]
sum = 0
for i in range(len(a)):
    sum = sum + a[i]
print sum
avg = sum / len(a)
print avg
# ^^^^SUM & AVG^^^^

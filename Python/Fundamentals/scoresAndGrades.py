def gradepercent(x):
    grade = ""
    if x <= 100 and x >= 90:
        grade = "Grade - A"
        print grade
    elif x <= 89 and x >= 80:
        grade = "Grade - B"
        print grade
    elif x <= 79 and x >= 70:
        grade = "Grade - C"
        print grade
    elif x <= 69 and x >= 60:
        grade = "Grade - D"
        print grade
    elif x <= 60:
        grade = "Grade - F"
        print grade


import random
x = random.randint(59, 100)

gradepercent(x)


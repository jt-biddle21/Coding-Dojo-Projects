class Car(object):
    def __init__(self, kind, speed, price, fuel, mileage):
        self.kind = kind
        self.speed = speed
        self.price = price
        self.fuel = fuel
        self.mileage = mileage
        self.tax = 0.12
        self.displayinfo()

    def displayinfo(self):
        print "Type:", self.kind
        print "Price:", self.price
        print "Speed:", self.speed, "mph"
        print "Fuel Level:", self.fuel
        print "Mileage:", self.mileage, "mpg"
        if self.price > 10000:
            self.tax = 0.15
            print "Tax:", self.tax
        else:
            print "Tax:", self.tax


nissan = Car("Nissan", 150, 11000, "Empty", 32)
ford = Car("Ford", 55, 13500, "Half Full", 6)
suzuki = Car("Suzuki", 70, 5599, "Quarter Tank", 45)
chevy = Car("Chevy", 60, 12500, "Full", 4)
honda = Car("Honda", 25, 999, "Empty", 15)
subaru = Car("Subaru", 65, 10050, "3/4 Full", 28)

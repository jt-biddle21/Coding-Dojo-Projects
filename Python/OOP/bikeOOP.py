class Bike(object):
    def __init__(self, name, price, max_speed):
        self.name = name
        self.price = price
        self.max_speed = max_speed
        self.miles = 0

    def displayinfo(self):
        print self.name
        print self.price
        print self.max_speed
        print self.miles

    def ride(self):
        print "Riding...!"
        self.miles += 10
        print "You rode a total of 10 miles!"
        return self

    def reverse(self):
        print "Reversing...!"
        self.miles -= 10
        if self.miles < 0:
            print "Unable to ride backwards anymore! You're back at 0 miles!"
            self.miles = 0
        else:
            print "Somehow you managed to ride -10 miles!"
        return self

    def showmiles(self):
        print self.miles


trek = Bike("Trek", "$250", "30mph")
trek.ride().ride().ride().reverse().displayinfo()

#  The methods that need 'return self' are the ones that are being chained off of. Like .ride() and .reverse()
#  If you wanted to chain together displayinfo(), then you would need to add 'return self' to that method
#  In order to prevent negatives, just add a if statement in the method like I did for the reverse methond



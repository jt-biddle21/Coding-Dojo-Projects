# function input
my_dict = {
  "Speros": "(555) 555-5555",
  "Michael": "(999) 999-9999",
  "Jay": "(777) 777-7777"
}
#function output
# [("Speros", "(555) 555-5555"), ("Michael", "(999) 999-9999"), ("Jay", "(777) 777-7777")]


def maketuples(x):
    newtuple = ()
    for z in x:
        print z
        newtuple = newtuple + (x[z])
    for i in my_dict.itervalues():
        print i
    newtuple = newtuple + (x[z])
    print newtuple



maketuples(my_dict)

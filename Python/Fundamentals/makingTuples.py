# function input
my_dict = {
  "Speros": "(555) 555-5555",
  "Michael": "(999) 999-9999",
  "Jay": "(777) 777-7777"
}
#function output
# [("Speros", "(555) 555-5555"), ("Michael", "(999) 999-9999"), ("Jay", "(777) 777-7777")]


def maketuples(x_dict):
    # newtuple = ()
    for z in x_dict:
        print z
        newtuple = newtuple + (x[z])

    for i in my_dict.itervalues():
        print i

    newtuple = newtuple + (x[z])
    print newtuple


def tuple_from_dict(a_dict):
    rv = ()
    for k, v in a_dict.iteritems():
        rv += k, v,
    return rv


# maketuples(my_dict)
new_tuple = tuple_from_dict(my_dict)

print (new_tuple)
print(type(new_tuple))

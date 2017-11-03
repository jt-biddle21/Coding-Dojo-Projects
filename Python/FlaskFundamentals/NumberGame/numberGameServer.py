from flask import Flask, render_template, request, session, redirect
app = Flask(__name__)
app.secret_key = "secretkey"


def setrandom():
    import random
    x = random.randint(0, 101)
    session['randnumber'] = x
    return x


def resetrandom():
    session.pop('randnumber')


@app.route('/')
def initialpage():
    return render_template('index.html')


@app.route('/guess', methods=["POST"])
def storedata():
    session["number"] = request.form["number"]
    return redirect('/')


app.run(debug=True)

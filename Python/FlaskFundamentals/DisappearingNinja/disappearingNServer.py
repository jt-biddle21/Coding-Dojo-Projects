from flask import Flask, render_template
app = Flask(__name__)


@app.route('/')
def homepage():
    return render_template("index.html")


@app.route('/ninjas')
def allninja():
    return render_template("allninjas.html")


@app.route('/ninjas/orange')
def orangeninja():
    return render_template("ninjaorange.html")


@app.route('/ninjas/purple')
def purpninja():
    return render_template("purpninja.html")


@app.route('/ninjas/blue')
def blueninja():
    return render_template("blueninja.html")


@app.route('/ninjas/red')
def redninja():
    return render_template("redninja.html")


@app.route('/ninjas/123')
def hacker():
    return render_template("hacker.html")


@app.route('/ninjas/blue')
def hacker2():
    return render_template("hacker.html")


app.run(debug=True)

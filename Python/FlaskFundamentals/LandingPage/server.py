from flask import Flask, render_template, request, redirect
app = Flask(__name__)


@app.route('/')
def index():
    return render_template("index.html")


@app.route("/ninjas", methods=["GET"])
def ninjas():
    return render_template("ninjas.html")


@app.route("/dojo/new", methods=["GET"])
def dojoform():
    return render_template("dojonew.html")


app.run(debug=True)

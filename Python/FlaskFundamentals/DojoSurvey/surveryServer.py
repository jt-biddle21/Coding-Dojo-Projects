from flask import Flask, render_template, request, redirect
app = Flask(__name__)


@app.route("/")
def homepage():
    return render_template("index.html")


@app.route("/results", methods=["POST"])
def resultspage():

    return render_template("results.html", name=request.form["yourname"])


@app.route("/dojoform")
def formpage():
    return render_template("form.html")
    return redirect("/")


app.run(debug=True)

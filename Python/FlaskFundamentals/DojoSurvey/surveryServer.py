from flask import Flask, render_template, request
app = Flask(__name__)


@app.route("/")
def homepage():
    return render_template("index.html")


@app.route("/results", methods=["POST"])
def resultspage():
    return render_template("results.html", name=request.form['name'], location=request.form["location"], lang=request.form["lang"], comment=request.form['comment'])


@app.route("/dojoform")
def formpage():
    return render_template("form.html")


app.run(debug=True)

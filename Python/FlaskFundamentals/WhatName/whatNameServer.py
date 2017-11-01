from flask import Flask, render_template, request, redirect
dom = Flask(__name__)


@dom.route("/")
def initialpage():
    return render_template("homepage.html")


@dom.route("/yourname", methods=["POST"])
def younamepage():
    print request.form["yourname"]
    return redirect("/")


dom.run(debug=True)

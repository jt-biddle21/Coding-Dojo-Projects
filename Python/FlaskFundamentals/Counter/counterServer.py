from flask import Flask, render_template, session
app = Flask(__name__)
app.secret_key = "secretman"


@app.route('/')
def homepage():
    session["counter"] += 1
    return render_template("index.html", counter=session["counter"])


app.run(debug=True)

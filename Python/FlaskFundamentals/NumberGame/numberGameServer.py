import random
import pprint
from flask import Flask, render_template, request, session, redirect
app = Flask(__name__)
app.secret_key = "secretkey"


@app.route('/')
def index():
    session['number'] = random.randrange(0, 100)
    pprint.pprint(session['number'])
    return render_template('index.html')


@app.route('/guess', methods=['POST'])
def guess():
    if not session.get('number'):
        return redirect('/')
    answer = None
    try:
        user_guess = int(request.form['guess'])
    except ValueError:
        bad_guess = request.form['guess'] if request.form['guess'] else "No guess at all"
        answer = "{} is not a number. Please try again.".format(bad_guess)
        return render_template("index.html", answer=answer)
    if user_guess > session["number"]:
        answer = "Too High"
    if user_guess < session['number']:
        answer = "Too Low"
    if answer is None:
        answer = 'Correct. You guessed {}. Click submit to play again!'.format(user_guess, session['number'])
        session.pop('number')
    return render_template("index.html", answer=answer)


app.run(debug=True)

from flask import Flask, render_template, request, redirect, flash, session
from mysqlconnection import MySQLConnector
import re

app = Flask(__name__)
app.secret_key = "BoiItsSecret"
mysql = MySQLConnector(app, "email_validate")
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')


@app.route('/')
def index():
    return render_template('emailValid.html')


@app.route('/success')
def success():
    get_all_emails_query = "SELECT * FROM emails"
    all_emails = mysql.query_db(get_all_emails_query)
    return render_template('success.html', bemail=all_emails)


@app.route('/validate', methods=["POST"])
def validate():
    session['email'] = request.form['email']
    if len(session['email']) < 1:
        flash("Email cannot be blank!")
        return redirect('/')
    elif not EMAIL_REGEX.match(session['email']):
        flash("Invalid Email Address!")
        return redirect('/')
    else:
        add_email_query = "INSERT INTO emails (email) VALUES (:qemail)"
        data = {"qemail": request.form["email"]}
        mysql.query_db(add_email_query, data)
    return redirect('/success')


app.run(debug=True)

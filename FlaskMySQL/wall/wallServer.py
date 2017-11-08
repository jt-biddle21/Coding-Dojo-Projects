from flask import Flask, render_template, request, flash, session, redirect
from mysqlconnection import MySQLConnector
import re
import md5

app = Flask(__name__)
app.secret_key = "mysecretmofo"
mysql = MySQLConnector(app, "wall")
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')


@app.route('/')
def index():
    return render_template('index.html')


# route to accept the submitted form and validate it
@app.route('/register', methods=["POST"])
def register():
    is_valid = True
    # email validations
    if len(request.form["email"]) == 0:
        flash("Email field is required")
        is_valid = False
    elif not EMAIL_REGEX.match(request.form['email']):
        flash("Invalid email")
        is_valid = False

    # first name validations
    if len(request.form["fname"]) < 0:
        flash("First name is required")
        is_valid = False
    elif not request.form["fname"].isalpha():
        flash("Invalid first name")
        is_valid = False

    # last name validations
    if len(request.form["lname"]) < 0:
        flash("Last name is required")
        is_valid = False
    elif not request.form["lname"].isalpha():
        flash("Invalid last name")
        is_valid = False

    # password validations
    if len(request.form["pw"]) < 8:
        flash("Password must be at least 8 characters")
        is_valid = False
    elif request.form["pw"] != request.form["confpw"]:
        flash("Passwords do not match")
        is_valid = False

    if is_valid:
        add_user = "INSERT INTO users (first_name, last_name, email, password, created_at, updated_at) VALUES (:fn, :ln, :em, :pw, NOW(), NOW())"
        user_data = {'fn': request.form['fname'], 'ln': request.form['lname'], 'em': request.form['email'], 'pw': request.form['pw']}
        mysql.query_db(add_user, user_data)
        flash("User created in DB!")

    return redirect('/')


@app.route('/login', methods=["POST"])
def login():
    #is there a user with that email?
    find_user_q = "SELECT * FROM users WHERE email = :email"
    data = {'email': request.form['email1']}
    found_user = mysql.query_db(find_user_q, data)
    if len(found_user) == 0: #No user registered
        flash("No user registered with that email!")
    else:   #if so, does the password they entered match what is in the DB?
        if found_user[0]['password'] != request.form['pw1']:
            flash("Password is incorrect")
        else:
            session['name'] = found_user[0]['first_name']
            session['user_id'] = found_user[0]['user_id']
            return redirect('/wall')

    return redirect('/')

@app.route('/wall')
def show_wall():
    return render_template('wall.html')


app.run(debug=True)

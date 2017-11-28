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
        first_name = request.form['fname']
        last_name = request.form['lname']
        email = request.form['email']
        password = md5.new(request.form['pw']).hexdigest()
        add_user = "INSERT INTO users (first_name, last_name, email, password, created_at) VALUES (:fn, :ln, :em, :pw, NOW())"
        user_data = {'fn': first_name, 'ln': last_name, 'em': email, 'pw': password}
        mysql.query_db(add_user, user_data)
        flash("User created in DB!")
    return redirect('/')


@app.route('/login', methods=["POST"])
def login():
    #is there a user with that email?
    password = md5.new(request.form['pw1']).hexdigest()
    email = request.form['email1']
    find_user_q = "SELECT * FROM users WHERE users.email = :email AND users.password = :password"
    data = {'email': email, 'password': password}
    found_user = mysql.query_db(find_user_q, data)
    if len(found_user) == 0: #No user registered
        flash("No user registered with that email!")
    else:   #if so, does the password they entered match what is in the DB?
        if found_user[0]['password'] != password:
            flash("Password is incorrect")
        else:
            session['name'] = found_user[0]['first_name']
            session['password'] = found_user[0]['password']
            session['user_id'] = found_user[0]['user_id']
            return redirect('/wall')

    return redirect('/')


@app.route('/wall')
def show_wall():
    if 'name' not in session:
        flash("You need to log in first to view your wall!")
        return redirect('/')
    jointhem_yeah_q = "SELECT * FROM messages JOIN users ON users.user_id = messages.user_user_id ORDER BY messages.created_at DESC"
    joinboys = mysql.query_db(jointhem_yeah_q)
    comment_q = "SELECT * FROM comments JOIN users ON users.user_id = comments.user_user_id JOIN messages ON messages.message_id = comments.message_id ORDER BY comments.created_at DESC"
    commentque = mysql.query_db(comment_q)
    return render_template('wall.html', join=joinboys, comm=commentque)


@app.route('/postmessage', methods=["POST"])
def message():
    messagepost = request.form['post']
    create_msg_q = "INSERT INTO messages (user_user_id, message, created_at) VALUES (:ui, :msg, NOW())"
    msg_data = {'ui': session['user_id'], 'msg': messagepost}
    mysql.query_db(create_msg_q, msg_data)
    return redirect('/wall')


@app.route('/postcomment', methods=["POST"])
def comment():
    commentpost = request.form['comment']
    create_cmt_q = "INSERT INTO comments (user_user_id, comment, created_at, message_id) VALUES (:cui, :cmt, NOW(), :mi)"
    cmt_data = {'cui': session['user_id'], 'mi': request.form['message_id'], 'cmt': commentpost}
    mysql.query_db(create_cmt_q, cmt_data)
    return redirect('/wall')


@app.route('/logout')
def logout():
    if 'name' not in session:
        return redirect('/')
    elif 'password' not in session:
        return redirect('/')
    elif 'user_id' not in session:
        return redirect('/')
    session.pop('name')
    session.pop('password')
    session.pop('user_id')
    return redirect('/')


app.run(debug=True)

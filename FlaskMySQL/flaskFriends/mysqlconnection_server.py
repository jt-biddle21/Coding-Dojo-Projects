from flask import Flask, render_template, request, redirect
from mysqlconnection import MySQLConnector

app = Flask(__name__)
mysql = MySQLConnector(app, "flask_friends")


@app.route('/')
def index():
    get_all_friends_query = "SELECT * FROM friends"
    all_friends = mysql.query_db(get_all_friends_query)
    return render_template('index.html', friends=all_friends)


@app.route('/add_friend', methods=["POST"])
def addfriend():
    add_friend_query = "INSERT INTO friends (name, age, friends_since) VALUES (:qname, :qage, :qfriends_since)"
    data = {"qname": request.form["name"], "qage": request.form["age"], "qfriends_since": request.form["friends"]}
    mysql.query_db(add_friend_query, data)
    return redirect('/')


app.run(debug=True)

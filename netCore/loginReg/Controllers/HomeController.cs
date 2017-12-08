using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;
using loginReg.Models;

namespace loginReg.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
        if(TempData["CustomError"] != null)
        {
            ViewBag.emailError = TempData["CustomError"];
        }
            return View();
        }

        [HttpGet]
        [Route("/logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/loggedIn")]
        public IActionResult Logged()
        {
            int? u = HttpContext.Session.GetInt32("UserId");
            List<Dictionary<string, object>> UsertoMessages = DbConnector.Query("SELECT users.id, first_name, message, messageposted_at, messages_id FROM users JOIN messages ON users.id = messages.user_id");
            List<Dictionary<string, object>> UsertoComments = DbConnector.Query("SELECT users.id, first_name, comment, commentposted_at, messages_id, comment_id, message_id, message  FROM users JOIN comments ON users.id = comments.user_id JOIN messages ON comments.message_id = messages_id");
            List<Dictionary<string, object>> Userid = DbConnector.Query($"SELECT * from users where id = '{u}'");
            ViewBag.username = Userid;
            ViewBag.messages = UsertoMessages;
            ViewBag.comments = UsertoComments;
            return View();
        }

        [HttpPost]
        [Route("/loggingIn")]
        public IActionResult Logging(string useremail, string userpassword)
        {
            User NewUser = new User
            {
                Email = useremail,
                Password = userpassword,
            };
            TryValidateModel(NewUser);
            ViewBag.errors = ModelState.Values;
            if(useremail == null || userpassword == null)
            {
                TempData["CustomError"] = "Please fill out your field out properly";
                return RedirectToAction("Index");
            }
            List<Dictionary<string, object>> Userid = DbConnector.Query($"SELECT * from users where email = '{useremail}'");
            //if no matching email
            if (Userid.Count == 0)
            {
                TempData["CustomError"] = "Invalid email";
                return View();
            }
            //matching email, wrong password
            else if ((string)Userid[0]["password"] != userpassword)
            {
                TempData["CustomError"] = "Invalid password";
                return View();
            }
            else
            {
                int id = (int)Userid[0]["id"];
                HttpContext.Session.SetInt32("UserId", id);
            }
            return RedirectToAction("Logged");
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult Registrate(string fname, string lname, string useremail, string userpassword)
        {
            List<Dictionary<string, object>> emailDupeChecker = DbConnector.Query($"SELECT * FROM users where email = '{useremail}'");
            if (emailDupeChecker.Count > 0)
            {
                TempData["CustomError"] = "Email already in use";
                return RedirectToAction("Index");
            }
            User NewUser = new User
            {
                First_Name = fname,
                Last_Name = lname,
                Email = useremail,
                Password = userpassword,
            };
            TryValidateModel(NewUser);
            ViewBag.errors = ModelState.Values;
            string firstname = fname;
            string lastname = fname;
            string email = useremail;
            string password = userpassword;
            if (firstname == null && lastname == null && email == null && password == null)
            {
                return View();
            }
            else
            {
                List<Dictionary<string, object>> Users = DbConnector.Query($"INSERT INTO users (first_name, last_name, email, password) VALUES ('{firstname}', '{lastname}', '{email}', '{password}')");
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        [Route("/comment")]
        public IActionResult Comment(string content, string hiddenMessageId)
        {
            Comment NewComment = new Comment
            {
                PostComment = content,
            };
            TryValidateModel(NewComment);
            ViewBag.errors = ModelState.Values;
            string comment = content;
            if (comment == null)
            {
                return RedirectToAction("Logged");
            }
            else
            {
                int? z = HttpContext.Session.GetInt32("UserId");
                List<Dictionary<string, object>> Comment = DbConnector.Query($"INSERT INTO comments (comment, commentposted_at, message_id, user_id) VALUES ('{content}', NOW(), '{hiddenMessageId}', '{z}')");
                return RedirectToAction("Logged");
            }
        }

        [HttpPost]
        [Route("/postmessage")]
        public IActionResult MessagePosting(string message)
        {
            Message NewMessage = new Message
            {
                MessagePost = message,
            };
            TryValidateModel(NewMessage);
            ViewBag.errors = ModelState.Values;
            string msg = message;
            if (msg == null)
            {
                return RedirectToAction("Logged");
            }
            else
            {
                int? x = HttpContext.Session.GetInt32("UserId");
                List<Dictionary<string, object>> PostMessage = DbConnector.Query($"INSERT INTO messages (message, user_id, messageposted_at) VALUES ('{message}', '{x}', NOW())");
                List<Dictionary<string, object>> Messages = DbConnector.Query($"SELECT * FROM messages");
                Dictionary<string,object> unique = new Dictionary<string, object>();
                foreach(var n in Messages){
                    unique.Add( n["messages_id"].ToString(), n);
                }
                return RedirectToAction("Logged");
            }
        }
    }
}

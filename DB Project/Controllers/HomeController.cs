using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data.SqlClient;
using DBProject.Models;

namespace DBProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Adventure()
        {
            return View();
        }

        public ActionResult Controversial()
        {
            return View();
        }

        public ActionResult Fantasy()
        {
            return View();
        }

        public ActionResult Fiction()
        {
            return View();
        }

        public ActionResult Historical()
        {
            return View();
        }

        public ActionResult Horror()
        {
            return View();
        }

        public ActionResult Mystery()
        {
            return View();
        }

        public ActionResult Romance()
        {
            return View();
        }

        public ActionResult ScienceFiction()
        {
            return View();
        }

        public ActionResult SelfHelp()
        {
            return View();
        }

        public ActionResult Suspense()
        {
            return View();
        }

        public ActionResult Thriller()
        {
            return View();
        }

        public ActionResult YoungAdult()
        {
            return View();
        }

        public ActionResult Recommendations()
        {
            return View();
        }

        public void RecommendHistorical()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Historical')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["History"] = Output;
            HttpContext.Response.Redirect("Historical", false);
        }

        public void RecommendAdventure()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Adventure')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["Adventure"] = Output;
            HttpContext.Response.Redirect("Adventure", false);
        }

        public void RecommendControversial()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Controversial')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["Controversial"] = Output;
            HttpContext.Response.Redirect("Controversial", false);
        }

        public void RecommendFantasy()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Fantasy')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["Fantasy"] = Output;
            HttpContext.Response.Redirect("Fantasy", false);
        }

        public void RecommendFiction()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Fiction')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["Fiction"] = Output;
            HttpContext.Response.Redirect("Fiction", false);
        }

        public void RecommendHorror()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Horror')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["Horror"] = Output;
            HttpContext.Response.Redirect("Horror", false);
        }

        public void RecommendMystery()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Mystery')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["Mystery"] = Output;
            HttpContext.Response.Redirect("Mystery", false);
        }

        public void RecommendRomance()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Romance')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["Romance"] = Output;
            HttpContext.Response.Redirect("Romance", false);
        }

        public void RecommendScienceFiction()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Science-Fiction')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["ScienceFiction"] = Output;
            HttpContext.Response.Redirect("ScienceFiction", false);
        }

        public void RecommendSelfHelp()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Self-Help')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["SelfHelp"] = Output;
            HttpContext.Response.Redirect("SelfHelp", false);
        }

        public void RecommendSuspense()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Suspense')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["Suspense"] = Output;
            HttpContext.Response.Redirect("Suspense", false);
        }

        public void RecommendThriller()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Thriller')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["Thriller"] = Output;
            HttpContext.Response.Redirect("Thriller", false);
        }

        public void RecommendYoungAdult()
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM Recommend('Young-Adult')";
            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }
            con.Close();
            Session["YoungAdult"] = Output;
            HttpContext.Response.Redirect("YoungAdult", false);
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            return View();
        }

        public ActionResult SearchResult()
        {
            return View();
        }

        public ActionResult EmptyCart()
        {
            return View();
        }

        public ActionResult OrderPlaced()
        {
            return View();
        }

        public ActionResult RequestaBook()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult Home()
        {
            Session["errmsg"] = "";
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult DisplayBook(string clickbook)
        {
            string email = Session["userId"].ToString();
            int id = Convert.ToInt32(clickbook);
            string title = "";
            string genre = "";
            int price = 0;
            int stock = 0;
            string date = "";
            string author = "";
            string rate = "";
            int bookpic = id;
            int result = CRUD.DisplayBook(id, ref title, ref genre, ref price, ref stock, ref date, ref author, ref rate);

            if (true)
            {
                Session["bookpic"] = id;
                Session["title"] = title;
                Session["genre"] = genre;
                Session["price"] = price;
                Session["stock"] = stock;
                Session["date"] = date;
                Session["author"] = author;
                Session["rate"] = rate;
                string path = "~/Content/";
                string bookid = (id).ToString();
                string ext = ".jpg";
                string image = string.Concat(path, bookid, ext);
                Session["img"] = image;

                string comma = ",";
                string mailbook = string.Concat(email, comma, id);
                Session["mailbook"] = mailbook;
            }

            Session["errmsg"] = "";
            Session["result"] = result;
            return View("DisplayBook");
        }

        public ActionResult UpdateRating(string rating, string mailbook)
        {
            string info = Session["mailbook"].ToString();
            string[] arr = info.Split(',');
            string email = arr[0];
            string id = arr[1];

            int bookid = Convert.ToInt32(id);
            float rate = float.Parse(rating);
            int result = CRUD.UpdateRating(bookid, rate, email);

            if (result == -1)
            {
                Session["errmsg"] = "Something went wrong while connecting with the database.";
                Session["userId"] = email;
                Session["clickbook"] = id;
                return View("DisplayBook");
            }
            else if (result == 0)
            {
                Session["errmsg"] = "Can't Update Rating. You have already rated this book!";
                Session["userId"] = email;
                Session["clickbook"] = id;
                return View("DisplayBook");
            }

            Session["errmsg"] = "";
            Session["userId"] = email;
            Session["clickbook"] = id;
            return View("Home");
        }

        public ActionResult UserSignUp(string fname, string lname, string check, string email, string address, string phone, string password, string confirm)
        {
            int result = CRUD.UserSignUp(fname, lname, check, email, address, phone, password, confirm);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("SignUp", (object)data);
            }
            else if (result == 0)
            {
                String data = "User Already Exists";
                return View("SignUp", (object)data);
            }

            Session["errmsg"] = "";
            Session["userId"] = email;
            return RedirectToAction("Home");
        }

        public ActionResult UserLogin(string email, string password)
        {
            int result = CRUD.UserLogin(email, password);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("Login", (object)data);
            }
            else if (result == 0)
            {
                String data = "Incorrect Username or Password.";
                return View("Login", (object)data);

            }

            Session["errmsg"] = "";
            Session["userId"] = email;
            return RedirectToAction("Home");
        }

        public ActionResult AddToCart(string mailbook)
        {
            string data = Session["mailbook"].ToString();
            string[] arr = data.Split(',');
            string email = arr[0];
            string bookid = arr[1];
            int result = CRUD.UserAddToCart(email, Convert.ToInt32(bookid));

            if (result == -1)
            {
                String error = "Something went wrong while connecting with the database.";
                Session["errmsg"] = error;
                Session["userId"] = email;
                Session["clickbook"] = bookid;
                return View("DisplayBook");
            }
            else if (result == 0)
            {
                String error = "The Stock Has Finished!";
                Session["errmsg"] = error;
                Session["userId"] = email;
                Session["clickbook"] = bookid;
                return View("DisplayBook");
            }

            Session["userId"] = email;
            return RedirectToAction("DisplayCart");
        }

        public ActionResult PlaceOrder(string userId)
        {
            string email = Session["userId"].ToString();
            int result = CRUD.PlaceOrder(email);
            if (result == -1)
            {
                Session["errmsg"] = "Something went wrong while connecting with the database.";
                Session["userId"] = email;
                return View("DisplayCart");
            }

            Session["userId"] = email;
            return RedirectToAction("OrderPlaced");
        }

        public ActionResult DisplayCart(Cart dr, string forcart)
        {
            string email = Session["userId"].ToString();

            string connectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();
            string connection1 = "select title, Quantity, Quantity*Price as TotalPrice from cart join books on cart.bookid=books.bookid where email=";
            string newconnec = string.Concat(connection1, "'", email, "'");
            SqlCommand com = new SqlCommand(newconnec, sqlconn);
            SqlDataAdapter da = new SqlDataAdapter(com);

            SqlDataReader sdr = com.ExecuteReader();

            List<Cart> objmodel = new List<Cart>();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    var details = new Cart();
                    details.title = sdr["title"].ToString();
                    details.Quantity = Convert.ToInt32(sdr["Quantity"]);
                    details.TotalPrice = Convert.ToInt32(sdr["TotalPrice"]);
                    objmodel.Add(details);

                }
                dr.Cart_Info = objmodel;
                sqlconn.Close();
            }
            else
            {
                return RedirectToAction("EmptyCart");
            }
            Session["userId"] = email;
            return View("DisplayCart", dr);
        }

        public ActionResult DeleteFromCart(string delete)
        {
            int result = CRUD.EmptyCart(delete);
            if (result == -1)
            {
                String data = "Something went wrong while connecting with the database.";
                return View("Home", (object)data);
            }

            Session["userId"] = delete;
            return RedirectToAction("Home");
        }

        public ActionResult UserRequestBook(string title, string author)
        {

            string email = Session["userId"].ToString();
            int result = CRUD.RequestBook(title, author, email);
            if (result == -1)
            {
                Session["errmsg"] = "Something went wrong while connecting with the database.";
                Session["userId"] = email;
                return View("UserRequestBook");
            }
            Session["userId"] = title;
            return RedirectToAction("Home");
        }

        public void SearchBook(string SEARCH)
        {
            String par = CRUD.SearchMYBook(SEARCH);
            Session["parameter"] = par;
            HttpContext.Response.Redirect("SearchResult", false);
        }
    }
}
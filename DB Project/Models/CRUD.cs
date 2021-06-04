using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DBProject.Models
{
    public class CRUD
    {
        public static int UserSignUp(string fname, string lname, string check, string email, string address, string phone, string password, string confirm)
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("dbo.SignUp", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@Fname", SqlDbType.VarChar, 50).Value = fname;
                cmd.Parameters.Add("@Lname", SqlDbType.VarChar, 50).Value = lname;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
                cmd.Parameters.Add("@address", SqlDbType.VarChar, 250).Value = address;
                cmd.Parameters.Add("@phone", SqlDbType.Char, 11).Value = phone;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = password;
                cmd.Parameters.Add("@Confirm", SqlDbType.VarChar, 50).Value = confirm;
                cmd.Parameters.Add("@gender", SqlDbType.Char,1).Value = check;

                cmd.Parameters.Add("@str", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@str"].Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int UserLogin(string email, string password)
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd;
            int result;

            try
            {
                cmd = new SqlCommand("Login", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;

                cmd.Parameters.Add("@str", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@str"].Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int UpdateRating(int bookid, float rating, string email)
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd;
            int result;

            try
            {
                cmd = new SqlCommand("RateBook", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@bookid", SqlDbType.Int).Value = bookid;
                cmd.Parameters.Add("@rating", SqlDbType.Float).Value = rating;

                cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
                cmd.Parameters.Add("@str", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@str"].Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int UserAddToCart(string email, int bookid)
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd;
            int result;

            try
            {
                cmd = new SqlCommand("AddToCart", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
                cmd.Parameters.Add("@bookId", SqlDbType.VarChar, 50).Value = bookid;

                cmd.Parameters.Add("@str", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@str"].Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int DisplayBook(int id, ref string title, ref string genre, ref int price, ref int stock, ref string date, ref string author, ref string rate)
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd;
            int result = 0;

            try
            {
                cmd = new SqlCommand("DisplayBook", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@bookid", SqlDbType.Int).Value = id;

                cmd.Parameters.Add("@title", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@genre", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@price", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@date", SqlDbType.Char, 10).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@author", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@rate", SqlDbType.Float).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@flag", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result = Convert.ToInt32(cmd.Parameters["@flag"].Value);
                title = Convert.ToString(cmd.Parameters["@title"].Value);
                genre = Convert.ToString(cmd.Parameters["@genre"].Value);
                price = Convert.ToInt32(cmd.Parameters["@price"].Value);
                stock = Convert.ToInt32(cmd.Parameters["@stock"].Value);
                date = Convert.ToString(cmd.Parameters["@date"].Value);
                author = Convert.ToString(cmd.Parameters["@author"].Value);

                rate = Convert.ToString(cmd.Parameters["@rate"].Value);
                //result = Convert.ToString(cmd.Parameters["@str"].Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    
        public static int PlaceOrder(string email)
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd;
            int result;

            try
            {
                cmd = new SqlCommand("PlaceOrder", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
                cmd.Parameters.Add("@str", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@str"].Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int EmptyCart(string email)
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd;
            int result;

            try
            {
                cmd = new SqlCommand("EmptyCart", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email;
                cmd.Parameters.Add("@str", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@str"].Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int RequestBook(string title, string author, string email)
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd;
            int result;

            try
            {
                cmd = new SqlCommand("RequestBook", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@title", SqlDbType.VarChar, 250).Value = title;
                cmd.Parameters.Add("@author", SqlDbType.VarChar, 250).Value = author;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 250).Value = email;

                cmd.Parameters.Add("@str", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["@str"].Value);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
                result = -1; //-1 will be interpreted as "error while connecting with the database."
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        
        public static String SearchMYBook(string key)
        {
            String ConnectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=Connection;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String Output = "";
            SqlCommand cmd;
            SqlDataReader dataReader;
            string input = "SELECT * FROM SEARCH('";
            input = input + key;
            input = input + "')";

            cmd = new SqlCommand(input, con);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + '+' + dataReader.GetValue(1) + '+' + dataReader.GetValue(2) + '+' + dataReader.GetValue(3) + '+' + dataReader.GetValue(4) + '|';
            }

            con.Close();
            return Output;
        }
    }
}
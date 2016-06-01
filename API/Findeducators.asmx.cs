using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
namespace API
{
    /// <summary>
    /// Summary description for Findeducators
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Findeducators : System.Web.Services.WebService
    {

        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["FindEducatorsContext"].ToString());
        
        JavaScriptSerializer sr = new JavaScriptSerializer();


        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string AuthenticateUser(string username, string password)
        {
            try
            {
                con.Open();
                string strQuery = "Select * from userlogins where username=@username and password=@password";
                SqlCommand cmd=new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = strQuery;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader dr = cmd.ExecuteReader();

                bool isUserValidate = false;

                while (dr.Read())
                {
                    isUserValidate = true;
                }

                if (isUserValidate)
                {
                    return sr.Serialize("true");
                }
                else
                {
                    return sr.Serialize("false");
                }

            }
            catch (Exception)
            {
                return sr.Serialize("false");
            }
            finally
            {
                con.Close();
            }
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string RegisterUser(string username, string password)
        {
            try
            {
                con.Open();
                string strQuery = "Select * from userlogins where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = strQuery;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader dr = cmd.ExecuteReader();

                bool isUserValidate = false;

                while (dr.Read())
                {
                    isUserValidate = true;
                }

                if (isUserValidate)
                {
                    return sr.Serialize("true");
                }
                else
                {
                    return sr.Serialize("false");
                }

            }
            catch (Exception)
            {
                return sr.Serialize("false");
            }
            finally
            {
                con.Close();
            }
        }


        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string GetCities(string username, string password)
        {
            try
            {
                con.Open();
                string strQuery = "Select * from userlogins where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = strQuery;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader dr = cmd.ExecuteReader();

                bool isUserValidate = false;

                while (dr.Read())
                {
                    isUserValidate = true;
                }

                if (isUserValidate)
                {
                    return sr.Serialize("true");
                }
                else
                {
                    return sr.Serialize("false");
                }

            }
            catch (Exception)
            {
                return sr.Serialize("false");
            }
            finally
            {
                con.Close();
            }
        }


        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string GetAreas(string username, string password)
        {
            try
            {
                con.Open();
                string strQuery = "Select * from userlogins where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = strQuery;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader dr = cmd.ExecuteReader();

                bool isUserValidate = false;

                while (dr.Read())
                {
                    isUserValidate = true;
                }

                if (isUserValidate)
                {
                    return sr.Serialize("true");
                }
                else
                {
                    return sr.Serialize("false");
                }

            }
            catch (Exception)
            {
                return sr.Serialize("false");
            }
            finally
            {
                con.Close();
            }
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string GetJobs(string username, string password)
        {
            try
            {
                con.Open();
                string strQuery = "Select * from userlogins where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = strQuery;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader dr = cmd.ExecuteReader();

                bool isUserValidate = false;

                while (dr.Read())
                {
                    isUserValidate = true;
                }

                if (isUserValidate)
                {
                    return sr.Serialize("true");
                }
                else
                {
                    return sr.Serialize("false");
                }

            }
            catch (Exception)
            {
                return sr.Serialize("false");
            }
            finally
            {
                con.Close();
            }
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public string GetTeachers(string username, string password)
        {
            try
            {
                con.Open();
                string strQuery = "Select * from userlogins where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = strQuery;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader dr = cmd.ExecuteReader();

                bool isUserValidate = false;

                while (dr.Read())
                {
                    isUserValidate = true;
                }

                if (isUserValidate)
                {
                    return sr.Serialize("true");
                }
                else
                {
                    return sr.Serialize("false");
                }

            }
            catch (Exception)
            {
                return sr.Serialize("false");
            }
            finally
            {
                con.Close();
            }
        }

    }
}

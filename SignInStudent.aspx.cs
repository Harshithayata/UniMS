using System;
using System;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace WebApplication35
{
    public partial class SignInStudent : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader srdr;
        string constr =
             "Server = tcp:universitymanagementsystem.database.windows.net,1433;Initial Catalog = UniversityManagementSystem; Persist Security Info=False;User ID = project1; Password=project@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            lblMsg.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            lblMsg.Visible = true;
            string userrole = "";
            string username = "";
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand()
                {
                    CommandText = "select * from Students where UserName=@uname and Password=@upwd",
                    Connection = con
                };
                cmd.Parameters.AddWithValue("@uname", txtUserName.Text);
                cmd.Parameters.AddWithValue("@upwd", txtUserPwd.Text);
                con.Open();
                srdr = cmd.ExecuteReader();
                if (srdr.HasRows)
                {
                    while (srdr.Read())
                    {
                        userrole = srdr["Role"].ToString();
                        username = srdr["UserName"].ToString();
                    }
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket
                  (1, username, DateTime.Now, DateTime.Now.AddMinutes(5), true,
                  userrole, FormsAuthentication.FormsCookiePath);
                    string hashCookies = FormsAuthentication.Encrypt(ticket);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashCookies);
                    Response.Cookies.Add(cookie);
                    string returnurl = Request.QueryString["ReturnUrl"];
                    if (returnurl == null)
                    { returnurl = "Student.aspx"; }
                    Response.Redirect(returnurl);


                }
                else
                {
                    lblMsg.Text = "Login Failed!!! ";
                    lblMsg.Text += "<br/> Either user name or Password Incorrect";

                }

            }
            catch (Exception ex) { lblMsg.Text = "Error!!!" + ex.Message; }
            finally
            {
                con.Close();
            }
        }
    }
}
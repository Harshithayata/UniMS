using System;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace WebApplication35
{
    public partial class Admission : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        static DataSet ds;
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
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand()
                {
                    Connection = con,
                    CommandText = "insert into Students(UserName,Password,Role,Fee,RollNo,class)values(@uname,@pwd,@role,@fee,@roll,@cls)"
                };
                cmd.Parameters.AddWithValue("@uname", txtuname.Text);
                cmd.Parameters.AddWithValue("@pwd", txtpwd.Text);
                cmd.Parameters.AddWithValue("@role", txtrole.Text);
                cmd.Parameters.AddWithValue("@fee", txtfee.Text);
                cmd.Parameters.AddWithValue("@roll", txtroll.Text);
                cmd.Parameters.AddWithValue("@cls", txtcls.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                lblMsg.Text = "Admission done Successfully"; ;
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
}
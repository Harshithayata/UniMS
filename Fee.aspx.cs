using System;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace WebApplication35
{
    public partial class Fee : System.Web.UI.Page
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
                    CommandText = "update Students set Fee=Fee+@fee where RollNo=@roll"
                };
               // cmd.Parameters.AddWithValue("@uname", txtuname.Text);
                cmd.Parameters.AddWithValue("@fee", txtfee.Text);
                cmd.Parameters.AddWithValue("@roll", txtId.Text);
                con.Open();
                cmd.ExecuteNonQuery();

                    lblMsg.Text = "Fee Paid successfully";
              
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
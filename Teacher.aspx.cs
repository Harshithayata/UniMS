using System;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

namespace WebApplication35
{
    public partial class Teacher : System.Web.UI.Page
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
                    CommandText = "select * from Teacher where UserName=@uname"
                };
                cmd.Parameters.AddWithValue("@uname", txtId.Text);

                sda = new SqlDataAdapter(cmd);
                ds = new DataSet();
                cmd.Connection.Open();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvStudents.DataSource = ds.Tables[0];
                    dgvStudents.DataBind();
                    lblMsg.Text = "Teacher Details Found,It is displayed Below";
                }
                else
                {
                    lblMsg.Text = "Teacher with such username doesnot exists";
                }


            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
}
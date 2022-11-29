using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

public partial class student_dtails : System.Web.UI.Page
{
    public static SqlConnection _Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
        {
            Response.Redirect("login.aspx");
        }
        u1.Text = "Welcome: " + Session["uname"].ToString();
        
        if (_Connection.State == ConnectionState.Open)
        {
            _Connection.Close();
        }

        _Connection.Open();
        SqlCommand _cmd = _Connection.CreateCommand();
        _cmd.CommandType = CommandType.Text;
        _cmd.CommandText = "select regno,name,lastname,joiningdate,birthdate,class,contactno,email from registration where username=('" + Session["uname"].ToString() + "') ";
        _cmd.ExecuteNonQuery();

        DataTable _dt = new DataTable();
        SqlDataAdapter _da = new SqlDataAdapter(_cmd);

        _da.Fill(_dt);


        GridView1.DataSource = _dt;
        GridView1.DataBind();


        _Connection.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("edit_student_details.aspx");  
    }
}
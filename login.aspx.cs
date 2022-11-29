using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    public static SqlConnection _Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
  
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        if (_Connection.State == ConnectionState.Open)
        {
            _Connection.Close();

        }
        _Connection.Open();
        SqlCommand _cmd = _Connection.CreateCommand();
        _cmd.CommandType = CommandType.Text;
        _cmd.CommandText = "select * from registration where username=('" + txtusername.Text + "') And password=('" + txtpassword.Text + "') ";
        _cmd.ExecuteNonQuery();
        DataTable _dt = new DataTable();
        SqlDataAdapter _da = new SqlDataAdapter(_cmd);
        _da.Fill(_dt);
        foreach (DataRow _dr in _dt.Rows)
        {
            Session["uname"] = _dr["username"].ToString();
            Response.Redirect("student_dtails.aspx");
        }
        _Connection.Close();


    }
}
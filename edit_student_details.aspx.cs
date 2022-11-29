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

public partial class edit_student_details : System.Web.UI.Page
{
    public static SqlConnection _Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
    string regno, fname, lname, uname, pwd, cat, cls, jd, bd, cno, eml, ph;

    string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uname"] == null)
        {
            Response.Redirect("login.aspx");
        }




        if (IsPostBack) return;

        if (_Connection.State == ConnectionState.Open)
        {
            _Connection.Close();
        }


        txtregno.Enabled = false;
        txtusername.Enabled = false;
        txtjoiningdate.Enabled = false;
        txtcategory.Enabled = false;
        txtclass.Enabled = false;

        _Connection.Open();
        SqlCommand _cmd = _Connection.CreateCommand();
        _cmd.CommandType = CommandType.Text;
        _cmd.CommandText = "select * from registration where username = ('" + Session["uname"].ToString() + "')";
        _cmd.ExecuteNonQuery();

        DataTable _dt = new DataTable();
        SqlDataAdapter _da = new SqlDataAdapter(_cmd);
        _da.Fill(_dt);

        foreach (DataRow _dr in _dt.Rows)
        {
            regno = _dr["regno"].ToString();
            fname = _dr["name"].ToString();
            lname = _dr["lastname"].ToString();
            uname = _dr["username"].ToString();
            pwd = _dr["password"].ToString();
            cat = _dr["category"].ToString();
            cls = _dr["class"].ToString();
            jd = _dr["joiningdate"].ToString();
            bd = _dr["birthdate"].ToString();
            cno = _dr["contactno"].ToString();
            eml = _dr["email"].ToString();
            ph = _dr["photo"].ToString();


        }

        txtregno.Text = regno.ToString();
        txtname.Text = fname.ToString();
        txtlastname.Text = lname.ToString();
        txtusername.Text = uname.ToString();
        txtpassword.Text = pwd.ToString();
        txtcategory.Text = cat.ToString();
        txtclass.Text = cls.ToString();
        txtjoiningdate.Text = jd.ToString();
        txtbirthdate.Text = bd.ToString();
        txtcontactno.Text = cno.ToString();
        txtemailid.Text = eml.ToString();
        image1.ImageUrl = ph.ToString();

        _Connection.Close();

    }
    protected void btnupdate_Click1(object sender, EventArgs e)
    {
        if (_Connection.State == ConnectionState.Open)
        {
            _Connection.Close();
        }

        if (FileUpload1.FileName == "")
        {

        }
        else
        {
            FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/images/student/" + FileUpload1.FileName);

            image1.ImageUrl = "images/student/" + FileUpload1.FileName;
        }

        _Connection.Open();
        SqlCommand _cmd1 = _Connection.CreateCommand();
        _cmd1.CommandType = CommandType.Text;
        _cmd1.CommandText = "update registration set name=('" + txtname.Text + "'),lastname =('" + txtlastname.Text + "'),password = ('" + txtpassword.Text + "'),birthdate = ('" + txtbirthdate.Text + "'),contactno = ('" + txtcontactno.Text + "'),email = ('" + txtemailid.Text + "'),photo = ('" + image1.ImageUrl + "') where regno=(" + txtregno.Text + ")";
        _cmd1.ExecuteNonQuery();
        _Connection.Close();

    }
    protected void c1_SelectionChanged(object sender, EventArgs e)
    {
        txtbirthdate.Text = c1.SelectedDate.ToString("dd-MM-yyyy");
    }
}
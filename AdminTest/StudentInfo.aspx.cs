using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

public partial class AdminTest_StudentInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from student", sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewStudent.DataKeyNames = new string[] {"id" };
        sqlDataAdapter.Fill(dataSet);
        GridViewStudent.DataSource = dataSet;
        GridViewStudent.DataBind();

        sqlConnection.Close();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = GridViewStudent.DataKeys[e.NewEditIndex].Value.ToString();
        Response.Redirect("./SkipPage/UpdateStudent.aspx?id=" + id);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        

        string id = GridViewStudent.DataKeys[e.RowIndex].Value.ToString();
        bool success=dao.DeleteBody(id,1);
        if (success)
        {
            Response.Write("<script>alert('删除成功！')</script>");

            //刷新该页面
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from student", sqlConnection);
            DataSet dataSet = new DataSet();
            GridViewStudent.DataKeyNames = new string[] { "id" };
            sqlDataAdapter.Fill(dataSet);
            GridViewStudent.DataSource = dataSet;
            GridViewStudent.DataBind();


            sqlConnection.Close();
        }
        else Response.Write("<script>alert('删除失败！')</script>");

       
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./SkipPage/AddStudent.aspx");
    }
}
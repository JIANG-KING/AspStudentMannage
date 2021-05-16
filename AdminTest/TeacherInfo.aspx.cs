using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_TeacherInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select teacher.*,Dept.Name as'deptname' from teacher left join dept on Dept.ID=Teacher.Department", sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewTeacher.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        GridViewTeacher.DataSource = dataSet;
        GridViewTeacher.DataBind();

        sqlConnection.Close();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = GridViewTeacher.DataKeys[e.NewEditIndex].Value.ToString();
        Response.Redirect("./SkipPage/UpdateTeacher.aspx?id=" + id);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        string id = GridViewTeacher.DataKeys[e.RowIndex].Value.ToString();
        bool success = dao.DeleteBody(id, 2);
        if (success)
        {
            Response.Write("<script>alert('删除成功！')</script>");

            //刷新该页面
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select teacher.*,Dept.Name as'deptname' from teacher left join dept on Dept.ID=Teacher.Department", sqlConnection);
            DataSet dataSet = new DataSet();
            GridViewTeacher.DataKeyNames = new string[] { "id" };
            sqlDataAdapter.Fill(dataSet);
            GridViewTeacher.DataSource = dataSet;
            GridViewTeacher.DataBind();


            sqlConnection.Close();
        }
        else Response.Write("<script>alert('删除失败！')</script>");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./SkipPage/AddTeacher.aspx");
    }
}
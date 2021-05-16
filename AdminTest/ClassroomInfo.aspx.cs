using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;


public partial class AdminTest_ClassroomInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select ClassRoom.*,dept.Name from classroom left join Dept on ClassRoom.Dept=Dept.ID", sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewClassRoom.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        GridViewClassRoom.DataSource = dataSet;
        GridViewClassRoom.DataBind();

        sqlConnection.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Redirect("./SkipPage/AddClassroom.aspx");
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //string id = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        //Response.Redirect("./SkipPage/UpdateClassroom.aspx?id=" + id);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
        //bool success = dao.DeleteBody(id, 6);
        //if (success)
        //{
        //    Response.Write("<script>alert('删除成功！')</script>");

        //    //刷新该页面
        //    SqlConnection sqlConnection = SqlTools.Connection();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from classroom", sqlConnection);
        //    DataSet dataSet = new DataSet();
        //    GridView1.DataKeyNames = new string[] { "id" };
        //    sqlDataAdapter.Fill(dataSet);
        //    GridView1.DataSource = dataSet;
        //    GridView1.DataBind();

        //    sqlConnection.Close();


        //    sqlConnection.Close();
        //}
        //else Response.Write("<script>alert('删除失败！')</script>");
    }
}
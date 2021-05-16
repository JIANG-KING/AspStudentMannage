using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;


public partial class AdminTest_DeptInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Dept.ID,Dept.Name as'deptname',Teacher.Name as'leadername' from dept left join teacher on Dept.Leader=Teacher.id", sqlConnection);
        DataSet dataSet = new DataSet();
        GridViewDept.DataKeyNames = new string[] { "id" };
        sqlDataAdapter.Fill(dataSet);
        GridViewDept.DataSource = dataSet;
        GridViewDept.DataBind();

        sqlConnection.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./SkipPage/AddDept.aspx");
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string id = GridViewDept.DataKeys[e.NewEditIndex].Value.ToString();
        Response.Redirect("./SkipPage/UpdateDept.aspx?id=" + id);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

        string id = GridViewDept.DataKeys[e.RowIndex].Value.ToString();
        bool success = dao.DeleteBody(id, 8);
        if (success)
        {
            Response.Write("<script>alert('删除成功！')</script>");

            //刷新该页面
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Dept.ID,Dept.Name as'deptname',Teacher.Name as'leadername' from dept left join teacher on Dept.Leader=Teacher.id", sqlConnection);
            DataSet dataSet = new DataSet();
            GridViewDept.DataKeyNames = new string[] { "id" };
            sqlDataAdapter.Fill(dataSet);
            GridViewDept.DataSource = dataSet;
            GridViewDept.DataBind();


            sqlConnection.Close();
        }
        else Response.Write("<script>alert('删除失败！')</script>");
    }
}
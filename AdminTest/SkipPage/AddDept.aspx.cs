using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;
public partial class AdminTest_SkipPage_AddDept : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        //获取所有老师
        SqlConnection sqlConnection = SqlTools.Connection();
        SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from teacher", sqlConnection);
        DataSet dataSet1 = new DataSet();
        sqlDataAdapter1.Fill(dataSet1);

        //所有老师绑定到系别下拉框
        DropDownListTeacher.DataSource = dataSet1;
        DropDownListTeacher.DataTextField = "name";
        DropDownListTeacher.DataBind();
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        Dept de = new Dept(
    TextBoxID.Text,
    TextBoxName.Text,
    DropDownListTeacher.SelectedValue
    );
        bool success = dao.AddBody(de, 8);
        if (success) Response.Write("<script>alert('添加成功！')</script>");
        else Response.Write("<script>alert('修改失败！该工号已存在~')</script>");
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../DeptInfo.aspx");
    }
}
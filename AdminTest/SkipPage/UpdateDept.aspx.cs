using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_SkipPage_UpdateDept : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //获取要编辑系别
            string id = Request.QueryString["id"];
            Dept de = (Dept)dao.getBody(id, 8);

            TextBoxID.Text = de.ID;
            TextBoxName.Text = de.Name;

            //获取所有老师
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from teacher", sqlConnection);
            DataSet dataSet1 = new DataSet();
            sqlDataAdapter1.Fill(dataSet1);

            //所有老师绑定到系别下拉框
            DropDownListTeacher.DataSource = dataSet1;
            DropDownListTeacher.DataTextField = "name";
            DropDownListTeacher.DataBind();

            //选中
            DropDownListTeacher.SelectedValue = de.Leader;


            sqlConnection.Close();
        }

        //不能改工号
        TextBoxID.Enabled = false;

    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        Dept de = new Dept(
            TextBoxID.Text,
            TextBoxName.Text,
            DropDownListTeacher.SelectedValue
            );
        bool success = dao.UpdateBody(de, 8);
        if (success) Response.Write("<script>alert('修改成功！')</script>");
        else Response.Write("<script>alert('修改失败！')</script>");
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../DeptInfo.aspx");
    }
}
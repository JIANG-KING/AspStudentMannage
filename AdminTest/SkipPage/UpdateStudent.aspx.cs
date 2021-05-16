using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;
public partial class AdminTest_SkipPage_AddStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //获取要编辑学生
            string id = Request.QueryString["id"];
            Student s = (Student)dao.getBody(id, 1);

            TextBoxID.Text = s.ID1;
            TextBoxName.Text = s.Name1;
            TextBoxPassword.Text = s.Password1;
            TextBoxBirth.Text = s.Birth1;
            TextBoxEmail.Text = s.Email1;
            TextBoxPhone.Text = s.Telephone1;
            TextBoxAddress.Text = s.Address1;
            TextBoxState.Text = s.State1;
            if (s.Sex1.Equals("女")) RadioButtonSexFemale.Checked = true;
            else RadioButtonSexMale.Checked = true;


            //获取所有班级
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from classinfo", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            //所有班级绑定到班级下拉框
            DropDownListClass.DataSource = dataSet;
            DropDownListClass.DataTextField = "name";
            DropDownListClass.DataBind();

            //下拉框选中该学生班级
            DropDownListClass.SelectedValue = s.Class1;

            //获取所有系别
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from dept", sqlConnection);
            DataSet dataSet1 = new DataSet();
            sqlDataAdapter1.Fill(dataSet1);

            //所有系别绑定到系别下拉框
            DropDownListDept.DataSource = dataSet1;
            DropDownListDept.DataTextField = "name";
            DropDownListDept.DataBind();
            //下拉框选中该学生系别
            DropDownListDept.SelectedValue = s.Dept1;


            sqlConnection.Close();
        }

        //不能改学号
        TextBoxID.Enabled = false;
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../StudentInfo.aspx");
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        //修改数据库中的数据
        string sex = "";
        if (RadioButtonSexFemale.Checked) sex = "女";
        else sex = "男";
        Student s = new Student(
            TextBoxID.Text,
            TextBoxPassword.Text,
            TextBoxName.Text,
            sex,
            DropDownListClass.SelectedValue,
            DropDownListDept.SelectedValue,
            TextBoxState.Text,
            TextBoxBirth.Text,
            TextBoxAddress.Text,
            "addstudent处没有此功能",
            TextBoxEmail.Text,
            TextBoxPhone.Text
            );
        bool success = dao.UpdateBody(s, 1);
        if(success) Response.Write("<script>alert('修改成功！')</script>");
        else Response.Write("<script>alert('修改失败！')</script>");

    }


}
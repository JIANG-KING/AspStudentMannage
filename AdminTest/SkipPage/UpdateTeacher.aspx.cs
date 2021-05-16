using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_SkipPage_UpdateTeacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //获取要编辑老师
            string id = Request.QueryString["id"];
            Teacher t = (Teacher)dao.getBody(id, 2);

            TextBoxID.Text = t.ID1;
            TextBoxName.Text = t.Name1;
            TextBoxPassword.Text = t.Password1;
            TextBoxBirth.Text = t.Birthday1;
            TextBoxEmail.Text = t.Email1;
            TextBoxPhone.Text = t.Telephone1;
            TextBoxAddress.Text = t.Address1;
            TextBoxState.Text = t.State1;
            TextBoxArriveDate.Text = t.ArriveDate1;
            if (t.Sex1.Equals("女")) RadioButtonSexFemale.Checked = true;
            else RadioButtonSexMale.Checked = true;


            //获取所有系别
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from dept", sqlConnection);
            DataSet dataSet1 = new DataSet();
            sqlDataAdapter1.Fill(dataSet1);

            //所有系别绑定到系别下拉框
            DropDownListDept.DataSource = dataSet1;
            DropDownListDept.DataTextField = "name";
            DropDownListDept.DataBind();
            //下拉框选中该老师系别
            DropDownListDept.SelectedValue = t.Department1;


            sqlConnection.Close();
        }

        //不能改工号
        TextBoxID.Enabled = false;
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../TeacherInfo.aspx");
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        //修改数据库中的数据
        string sex = "";
        if (RadioButtonSexFemale.Checked) sex = "女";
        else sex = "男";
        Teacher t = new Teacher(
            TextBoxID.Text,
            TextBoxPassword.Text,
            TextBoxName.Text,
            TextBoxState.Text,
            sex,
            TextBoxBirth.Text,
            TextBoxArriveDate.Text,
            TextBoxPhone.Text,
            "addstudent处没有此功能",
            TextBoxAddress.Text,
            TextBoxEmail.Text,
            DropDownListDept.SelectedValue
            );
        bool success = dao.UpdateBody(t, 2);
        if (success) Response.Write("<script>alert('修改成功！')</script>");
        else Response.Write("<script>alert('修改失败！')</script>");
    }
}
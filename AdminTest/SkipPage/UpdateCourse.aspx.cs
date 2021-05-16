using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class AdminTest_SkipPage_UpdateClass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //获取要编辑课程
            string id = Request.QueryString["id"];
            Course c = (Course)dao.getBody(id, 4);

            TextBoxID.Text =c.ID;
            TextBoxName.Text = c.Name;
            TextBoxScore.Text = c.Score;
            TextBoxDate.Text = c.Date;




            //获取所有老师
            SqlConnection sqlConnection = SqlTools.Connection();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from teacher", sqlConnection);
            DataSet dataSet1 = new DataSet();
            sqlDataAdapter1.Fill(dataSet1);

            //所有老师绑定到系别下拉框
            DropDownListTeacher.DataSource = dataSet1;
            DropDownListTeacher.DataTextField = "name";
            DropDownListTeacher.DataBind();
            //下拉框选中该课程老师
            //1.查询老师编号对应的老师姓名
            string teacherName = "";
            string sql1 = string.Format("select name from teacher where id='{0}'", c.Teacher);
            IDataReader idr = SqlTools.Read(sql1);
            if (idr.Read())
            {
                teacherName = idr.GetString(0);
            }
            //2.选中
            DropDownListTeacher.SelectedValue = teacherName;


            //绑定上课时间
            string[] dayAndNode = c.Time.Split(',');
            for (int i=0;i<dayAndNode.Length; i++)
            {
                //第一个字符为1说明是星期一
                if (dayAndNode[i].Substring(0, 1).Equals("1"))
                {
                    RadioButtonMonday.Checked = true;
                    DropDownListMonday.SelectedValue = dayAndNode[i].Substring(2, 1);
                }
                else if (dayAndNode[i].Substring(0, 1).Equals("2"))
                {
                    RadioButtonTuesday.Checked = true;
                    DropDownListTuesday.SelectedValue = dayAndNode[i].Substring(2, 1);
                }
                else if (dayAndNode[i].Substring(0, 1).Equals("3"))
                {
                    RadioButtonWed.Checked = true;
                    DropDownListWednesday.SelectedValue = dayAndNode[i].Substring(2, 1);
                }
                else if (dayAndNode[i].Substring(0, 1).Equals("4"))
                {
                    RadioButtonThur.Checked = true;
                    DropDownListThursday.SelectedValue = dayAndNode[i].Substring(2, 1);
                }
                else if (dayAndNode[i].Substring(0, 1).Equals("5"))
                {
                    RadioButtonFri.Checked = true;
                    DropDownListFriday.SelectedValue = dayAndNode[i].Substring(2, 1);
                }
            }

            //绑定课程周次
            string[] startAndEnd = c.Week.Split('-');
            DropDownListStart.SelectedValue = startAndEnd[0];
            DropDownListEnd.SelectedValue = startAndEnd[1];


            //获取所有教室
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select * from classroom", sqlConnection);
            DataSet dataSet2 = new DataSet();
            sqlDataAdapter2.Fill(dataSet2);
            //所有教室绑定到系别下拉框
            DropDownListPlace.DataSource = dataSet2;
            DropDownListPlace.DataTextField = "id";
            DropDownListPlace.DataBind();
            //选中上课地点
            DropDownListTeacher.SelectedValue = c.Place;


            sqlConnection.Close();
        }

        //不能改课程号
        TextBoxID.Enabled = false;
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        //修改数据库中的数据

        //导出上课时间
        string time = "";
        if (RadioButtonMonday.Checked)
        {
            time=time + "1="+DropDownListMonday.SelectedValue+",";
        }
        if (RadioButtonTuesday.Checked)
        {
            time = time + "2=" + DropDownListMonday.SelectedValue + ",";
        }
        if (RadioButtonWed.Checked)
        {
            time = time + "3=" + DropDownListMonday.SelectedValue + ",";
        }
        if (RadioButtonThur.Checked)
        {
            time = time + "4=" + DropDownListMonday.SelectedValue + ",";
        }
        if (RadioButtonFri.Checked)
        {
            time = time + "5=" + DropDownListMonday.SelectedValue + ",";
        }
        //去除最后一个逗号
        if (time.Length != 0)
        {
            time = time.Substring(0, time.Length - 1);
        }

        //导出上课周次
        string week = DropDownListStart.SelectedValue + "-" + DropDownListEnd.SelectedValue;

        Course c = new Course(
            TextBoxID.Text,
            TextBoxName.Text,
            DropDownListTeacher.SelectedValue,
            TextBoxDate.Text,
            time,
            week,
            DropDownListPlace.SelectedValue,
            TextBoxScore.Text
            );
        bool success = dao.UpdateBody(c, 4);
        if (success) Response.Write("<script>alert('修改成功！')</script>");
        else Response.Write("<script>alert('修改失败！')</script>");
    }

    protected void ButtonExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../CourseInfo.aspx");
    }
}
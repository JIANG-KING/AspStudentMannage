using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using test;

public partial class StudentTest_Studentmain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["student"] != null)
        {
            DataTable dt = new DataTable();//实例化一个空数据源        
            for (int k = 0; k < 5; k++)//要添加的行数，这里是5行
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
            }
            this.GridViewCourse.DataSource = dt;
            this.GridViewCourse.DataBind();//初始化表内数据
            GridViewCourse.Rows[0].Cells[0].Text = "第一节";
            GridViewCourse.Rows[1].Cells[0].Text = "第二节";
            GridViewCourse.Rows[2].Cells[0].Text = "第三节";
            GridViewCourse.Rows[3].Cells[0].Text = "第四节";
            GridViewCourse.Rows[4].Cells[0].Text = "第五节";
            Student Stu = (Student)Session["student"];
            LabelShowName.Text = Stu.Name1;
            LabelShowDept.Text = Stu.Dept1;
            LabelShowClass.Text = Stu.Class1;
            LabelShowWelcome.Text = "学生端→欢迎你:" + Stu.Name1 + "(" + Stu.ID1 + ")";
            ImageHead.ImageUrl = Stu.Photo1;
            SqlConnection sqlConnection = SqlTools.Connection();
            string sql = string.Format(@"select course  from SelectCourse where Student={0}", Stu.ID1);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection); ;
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            sqlConnection.Close();
            String[] CourseId = new string[dataSet.Tables[0].Rows.Count];
            int count = 0;
            Course[] course = new Course[dataSet.Tables[0].Rows.Count];//存储所有课程信息
            foreach (DataRow col in dataSet.Tables[0].Rows)//获取全部选课的课程号
            {
                course[count] = (Course)dao.getBody(col["course"].ToString(), 4);
                count++;
            }
            ClassRoom[] classRoom = new ClassRoom[count];
            for (int i = 0; i < count; i++)
            {
                classRoom[i] = (ClassRoom)dao.getBody(course[i].Place, 6);
            }
            string[,] ShowCourseInfo = new string[count, 5];
            string[,] ShowCoursetime = new string[count, 5];

            for (int j = 0; j < count; j++)
            {

                string[] dayAndNode = course[j].Time.Split(',');

                for (int i = 0; i < dayAndNode.Length; i++)
                {
                    if (dayAndNode[i].Substring(0, 1).Equals("1"))
                    {
                        ShowCourseInfo[j, i] = "星期一";
                        ShowCoursetime[j, i] = dayAndNode[i].Substring(2, 1);
                    }
                    else if (dayAndNode[i].Substring(0, 1).Equals("2"))
                    {
                        ShowCourseInfo[j, i] = "星期二";
                        ShowCoursetime[j, i] = dayAndNode[i].Substring(2, 1);
                    }
                    else if (dayAndNode[i].Substring(0, 1).Equals("3"))
                    {
                        ShowCourseInfo[j, i] = "星期三";
                        ShowCoursetime[j, i] = dayAndNode[i].Substring(2, 1);
                    }
                    else if (dayAndNode[i].Substring(0, 1).Equals("4"))
                    {
                        ShowCourseInfo[j, i] = "星期四";
                        ShowCoursetime[j, i] = dayAndNode[i].Substring(2, 1);
                    }
                    else if (dayAndNode[i].Substring(0, 1).Equals("5"))
                    {
                        ShowCourseInfo[j, i] = "星期五";
                        ShowCoursetime[j, i] = dayAndNode[i].Substring(2, 1);
                    }
                }
            }


            for (int i = 0; i < count; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    switch (ShowCourseInfo[i, j])
                    {
                        case "星期一": { GridViewCourse.Rows[int.Parse(ShowCoursetime[i, j]) - 1].Cells[1].Text += course[i].Name + "<br>" + classRoom[i].Number + "<br>"; } break;
                        case "星期二": { GridViewCourse.Rows[int.Parse(ShowCoursetime[i, j]) - 1].Cells[2].Text += course[i].Name + "<br>" + classRoom[i].Number + "<br>"; } break;
                        case "星期三": { GridViewCourse.Rows[int.Parse(ShowCoursetime[i, j]) - 1].Cells[3].Text += course[i].Name + "<br>" + classRoom[i].Number + "<br>"; } break;
                        case "星期四": { GridViewCourse.Rows[int.Parse(ShowCoursetime[i, j]) - 1].Cells[4].Text += course[i].Name + "<br>" + classRoom[i].Number + "<br>"; } break;
                        case "星期五": { GridViewCourse.Rows[int.Parse(ShowCoursetime[i, j]) - 1].Cells[5].Text += course[i].Name + "<br>" + classRoom[i].Number + "<br>"; } break;
                        default: break;




                    }
                }
            }
        }
        else
        {
            Response.Write(" <script language=javascript>alert('登录过期，请重新登陆');window.window.location.href='./../LoginTest.aspx';</script> ");
        }



    }


    protected void ButtonEsc_Click(object sender, EventArgs e)
    {
        Session["student"] = null;
        Response.Redirect("~/LoginTest.aspx", true);
        //Server.Transfer("~/LoginTest.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.showModelessDialog(~/StudentTest/UpdatePwd.aspx)</script>");
    }
}
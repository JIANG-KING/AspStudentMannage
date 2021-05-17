using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using test;

/// <summary>
/// dao 的摘要说明
/// </summary>
public class dao
{
    static IDataReader idr;

    //登录
    public static object Login(String id, String pwd, int type)
    {

        //学生
        if (type == 1)
        {
            string sql = string.Format(@"select * from Student where id='{0}'and password= '{1}'", id, pwd);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {
                Student s = new Student(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5), idr.GetString(6), idr.GetString(7), idr.GetString(8), idr.GetString(9), idr.GetString(10),idr.GetString(11));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return s;
            }

        }
        //老师
        else if (type == 2)
        {
            string sql = string.Format(@"select * from Teacher where id='{0}'and password= '{1}'", id, pwd);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {
                Teacher t = new Teacher(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5), idr.GetString(6), idr.GetString(7), idr.GetString(8), idr.GetString(9), idr.GetString(10), idr.GetString(11));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return t;
            }
        }
        //管理员
        else if (type == 3)
        {
            string sql = string.Format(@"select * from Admin where id='{0}'and password= '{1}'", id, pwd);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {
                Admin t = new Admin(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5), idr.GetString(6));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return t;
            }
        }

        //关连接
        if (!idr.IsClosed)
        {
            idr.Close();
        }

        return null;
    }

    //修改密码
    public static bool UpdatePwd(string id,string oldPwd,string newPwd,string type)
    {
        string sql = string.Format(@"select * from {0} where id='{1}'and password= '{2}'", type,id, oldPwd);


        idr = SqlTools.Read(sql);

        if (idr.Read())
        {
            string sql1= string.Format(@"update {0} set password='{1}' where id='{2}'", type, newPwd,id);
            int i=SqlTools.Excute(sql1);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {         //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true; }
        }
        //关连接
        if (!idr.IsClosed)
        {
            idr.Close();
        }

        return false;
    }
    public static bool UpdateWithoutPwd(string id, string newPwd, string type)
    {
        string sql = string.Format(@"select * from {0} where id='{1}'", type, id);


        idr = SqlTools.Read(sql);

        if (idr.Read())
        {
            string sql1 = string.Format(@"update {0} set password='{1}' where id='{2}'", type, newPwd, id);
            int i = SqlTools.Excute(sql1);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {         //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //关连接
        if (!idr.IsClosed)
        {
            idr.Close();
        }

        return false;
    }
    //通过id查询返回个体
    public static object getBody(String id, int type)
    {
        //学生
        if (type == 1)
        {
            string sql = string.Format(@"select * from Student where id='{0}'", id);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {
                Student s = new Student(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5), idr.GetString(6), idr.GetString(7), idr.GetString(8), idr.GetString(9), idr.GetString(10), idr.GetString(11));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return s;
            }

        }
        //老师
        else if (type == 2)
        {
            string sql = string.Format(@"select * from Teacher where id='{0}'", id);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {
                Teacher t = new Teacher(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5), idr.GetString(6), idr.GetString(7), idr.GetString(8), idr.GetString(9), idr.GetString(10), idr.GetString(11));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return t;
            }
        }
        //管理员
        else if (type == 3)
        {
            string sql = string.Format(@"select * from Admin where id='{0}'", id);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {
                Admin t = new Admin(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5), idr.GetString(6));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return t;
            }
        }
        //返回课程
        else if (type == 4)
        {
            string sql = string.Format(@"select * from course where id='{0}'", id);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {
                Course t = new Course(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5), idr.GetString(6), idr.GetString(7));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return t;
            }
        } 
        //返回成绩
        else if (type == 5)
        {
            string sql = string.Format(@"select * from score where id='{0}'", id);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {
                
                Score sc = new Score(idr.GetInt32(0)+"", idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return sc;
            }
        }
        //返回教室
        else if (type == 6)
        {
            string sql = string.Format(@"select * from Classroom where id='{0}'", id);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {

                ClassRoom sc = new ClassRoom(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return sc;
            }
        }
        //返回考试
        else if (type == 7)
        {
            string sql = string.Format(@"select * from exam where id='{0}'", id);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {

                Exam ex = new Exam(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3), idr.GetString(4), idr.GetString(5));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return ex;
            }
        }
        //返回系别
        else if (type == 8)
        {
            string sql = string.Format(@"select * from dept where id='{0}'", id);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {

                Dept de = new Dept(idr.GetString(0), idr.GetString(1), idr.GetString(2));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return de;
            }
        }
        else if (type == 9)
        {
            string sql = string.Format(@"select * from Classinfo where id='{0}'", id);

            idr = SqlTools.Read(sql);

            if (idr.Read())
            {

                ClassInfo classInfo = new ClassInfo(idr.GetString(0), idr.GetString(1), idr.GetString(2), idr.GetString(3));
                //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return classInfo;
            }
        }
        //关连接
        if (!idr.IsClosed)
        {
            idr.Close();
        }
        return null;
    }

    //修改个体信息
    public static bool UpdateBody(object o,int type)
    {
        //学生
        if (type == 1)
        {
            Student s = (Student)o;
            string sql= string.Format(@"update {0} set  password='{1}' ,name='{2}' ,sex='{3}' ,class='{4}' ,dept='{5}' ,state='{6}' ,birth='{7}' ,address='{8}' ,photo='{9}' ,email='{10}' ,telephone='{11}' where id='{12}'", "student",s.Password1,s.Name1,s.Sex1,s.Class1,s.Dept1,s.State1,s.Birth1,s.Address1,s.Photo1,s.Email1,s.Telephone1, s.ID1);
            int i = SqlTools.Excute(sql);
            if (i != 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
        }
        //教师
        else if (type == 2)
        {
            Teacher t = (Teacher)o;
            //查询出学院所对应的部门号
            string num="";
            string sql1 = string.Format("select id from dept where name='{0}'", t.Department1);
            idr = SqlTools.Read(sql1);
            if (idr.Read())
            {
                num = idr.GetString(0);
            }
            else
            {         //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false; }

            string sql = string.Format(@"update {0} set  password='{1}' ,name='{2}',state='{3}' ,sex='{4}' ,birthday='{5}',arrivedate='{6}',telephone='{7}',address='{8}'  ,email='{9}',department='{10}'  where id='{11}'","teacher",t.Password1,t.Name1,t.State1,t.Sex1,t.Birthday1,t.ArriveDate1,t.Telephone1,t.Address1,t.Email1,num,t.ID1);
            int i = SqlTools.Excute(sql);
            if (i != 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
        }
        //管理员
        else if (type == 3)
        {

        }
        //课程
        else if (type == 4)
        {
            Course c = (Course)o;

            //查询出该课程的老师
            string selectteacherId = string.Format("select id from teacher where name='{0}'", c.Teacher);
            string teacherId = "";
            idr = SqlTools.Read(selectteacherId);
            if (idr.Read())
            {
                teacherId = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }



            string sql = string.Format(@"update {0} set  name='{1}' ,teacher='{2}',date='{3}' ,time='{4}' ,week='{5}',place='{6}',score='{7}'where id='{8}'", "course",c.Name, teacherId, c.Date,c.Time,c.Week,c.Place,c.Score,c.ID);
            int i = SqlTools.Excute(sql);
            if (i != 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
        }
        //成绩
        else if (type == 5)
        {
            Score sc = (Score)o;

            string sql = string.Format(@"update {0} set  score='{1}' ,submittime='{2}' where id={3}", "score",sc.Scores1,sc.Submittime,sc.ID1);
            int i = SqlTools.Excute(sql);
            if (i != 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
        }
        //教室
        else if (type == 6)
        {
        }
        //考试
        else if (type == 7)
        {
            Exam ex = (Exam)o;

            //课程名查课程号
            string selectcourseId = string.Format("select id from course where name='{0}'", ex.Course);
            idr = SqlTools.Read(selectcourseId);
            string courseId = "";
            if (idr.Read())
            {
                courseId = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }

            //班级名查班级号
            string selectclassId = string.Format("select id from classinfo where name='{0}'", ex.ClassInfo);
            idr = SqlTools.Read(selectclassId);
            string classid = "";
            if (idr.Read())
            {
                classid = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }


            //判断是否同科目同班级
            string sql3 = string.Format("select * from exam where course='{0}' classinfo class='{1}'", courseId, classid);
            idr = SqlTools.Read(sql3);
            if (idr.Read())
            {
                {        //关连接
                    if (!idr.IsClosed)
                    {
                        idr.Close();
                    }
                    return false;
                }
            }


            string sql = string.Format(@"update {0} set course='{1}',date='{2}',time='{3}',place='{4}',classinfo='{5}' where id='{6}'", "exam",courseId,ex.Date,ex.Time,ex.Place,classid ,ex.ID);
            int i = SqlTools.Excute(sql);
            if (i != 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
        }
        //系别
        if (type == 8)
        {
            Dept de = (Dept)o;

            //name select id
            string selectteacherId = string.Format("select id from teacher where name='{0}'", de.Leader);
            string teacherId = "";
            idr = SqlTools.Read(selectteacherId);
            if (idr.Read())
            {
                teacherId = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }

            string sql = string.Format(@"update {0} set  name='{1}' ,leader='{2}'where id='{3}'", "dept",de.Name,teacherId,de.ID);
            int i = SqlTools.Excute(sql);
            if (i != 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
        }
        {        //关连接
            if (!idr.IsClosed)
            {
                idr.Close();
            }
            return false;
        }
    }

    //删除个体
    public static bool DeleteBody(string id,int type)
    {
        //学生
        if (type == 1)
        {
            string sql = string.Format(@"delete from student where id='{0}'", id);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //老师
        if (type == 2)
        {
            string sql = string.Format(@"delete from teacher where id='{0}'", id);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //管理员
        if (type == 3)
        {
        }
        //课程
        if (type == 4)
        {
            string sql = string.Format(@"delete from course where id='{0}'", id);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //成绩
        if (type == 5)
        {
            string sql = string.Format(@"delete from score where id='{0}'", id);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //教室
        if (type == 6)
        {
        }
        //考试
        if (type == 7)
        {
            string sql = string.Format(@"delete from exam where id='{0}'", id);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //院系
        if (type == 8)
        {
            string sql = string.Format(@"delete from dept where id='{0}'", id);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        {        //关连接
            if (!idr.IsClosed)
            {
                idr.Close();
            }
            return false;
        }
    }

    //添加个体
    public static bool AddBody(object o,int type)
    {
        //学生
        if (type == 1)
        {
            Student s = (Student)o;

            //判断是否已存在该学号
            string sql1 = string.Format("select * from student where id='{0}'",s.ID1);
            idr = SqlTools.Read(sql1);
            if (idr.Read())
            {
                {        //关连接
                    if (!idr.IsClosed)
                    {
                        idr.Close();
                    }
                    return false;
                }
            }

            //查询出班级名对应的班级号
            string classid = "";
            string sql2 = string.Format("select id from classinfo where name='{0}'", s.Class1);
            idr = SqlTools.Read(sql2);
            if (idr.Read())
            {
                classid = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }


            string sql = string.Format(@"insert into student values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", s.ID1,s.Password1,s.Name1,s.Sex1,classid,s.Dept1,s.State1,s.Birth1,s.Address1, "https://z3.ax1x.com/2021/05/15/g6hH39.gif", s.Email1,s.Telephone1);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //老师
        else if (type == 2)
        {
            Teacher t = (Teacher)o;

            //判断是否已存在该工号
            string sql1 = string.Format("select * from teacher where id='{0}'", t.ID1);
            idr = SqlTools.Read(sql1);
            if (idr.Read())
            {
                {        //关连接
                    if (!idr.IsClosed)
                    {
                        idr.Close();
                    }
                    return false;
                }
            }

            //查询出学院所对应的部门号
            string num = "";
            string sql2 = string.Format("select id from dept where name='{0}'",t.Department1);
            idr = SqlTools.Read(sql2);
            if (idr.Read())
            {
                num = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }


            string sql = string.Format(@"insert into teacher(id,password,name,state,sex,birthday,arrivedate,telephone,address,email,department) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", t.ID1, t.Password1, t.Name1, t.State1,t.Sex1, t.Birthday1, t.ArriveDate1,t.Telephone1,t.Address1,t.Email1,num);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //管理员
        else if (type == 3)
        {

        }
        //课程
        else if (type == 4)
        {
            Course c = (Course)o;

            //判断是否已存在该课程号
            string sql1 = string.Format("select * from course where id='{0}'", c.ID);
            idr = SqlTools.Read(sql1);
            if (idr.Read())
            {
                {        //关连接
                    if (!idr.IsClosed)
                    {
                        idr.Close();
                    }
                    return false;
                }
            }
            //查询出该课程的老师
            string teacherId = "";
            string sql3= string.Format("select id from teacher where name='{0}'", c.Teacher);
            idr = SqlTools.Read(sql3);
            if (idr.Read())
            {
                teacherId = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }


            string sql = string.Format(@"insert into course values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", c.ID,c.Name,teacherId,c.Date,c.Time,c.Week,c.Place,c.Score);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //成绩
        else if (type == 5)
        {
            Score sc = (Score)o;

            //查询学生名对应的学号
            string studentId = "";
            string sql3 = string.Format("select id from student where name='{0}'", sc.Student1);
            idr = SqlTools.Read(sql3);
            if (idr.Read())
            {
                studentId = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }

            //判断是否存在相同的课程号和学生名
            string sql1 = string.Format("select * from score where student='{0}' and course='{1}'",studentId,sc.Course1);
            idr = SqlTools.Read(sql1);
            if (idr.Read())
            {
                {        //关连接
                    if (!idr.IsClosed)
                    {
                        idr.Close();
                    }
                    return false;
                }
            }

            string sql = string.Format(@"insert into score values('{0}','{1}','{2}','{3}','{4}')", studentId,sc.Course1,sc.Scores1,sc.Submittime,sc.Submittime);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //教室
        else if (type == 6)
        {

        }
        //考试
        else if (type == 7)
        {
            Exam ex = (Exam)o;

            //判断是否已存在
            string sql1 = string.Format("select * from exam where id='{0}'", ex.ID);
            idr = SqlTools.Read(sql1);
            if (idr.Read())
            {
                {        //关连接
                    if (!idr.IsClosed)
                    {
                        idr.Close();
                    }
                    return false;
                }
            }

            //课程名查课程号
            string selectcourseId = string.Format("select id from course where name='{0}'", ex.Course);
            idr = SqlTools.Read(selectcourseId);
            string courseId = "";
            if (idr.Read())
            {
                courseId = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }

            //班级名查班级号
            string selectclassId = string.Format("select id from classinfo where name='{0}'", ex.ClassInfo);
            idr = SqlTools.Read(selectclassId);
            string classid = "";
            if (idr.Read())
            {
                classid = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }

            //判断是否同科目同班级
            string sql3 = string.Format("select * from exam where course='{0}' classinfo class='{1}'", courseId,classid);
            idr = SqlTools.Read(sql3);
            if (idr.Read())
            {
                {        //关连接
                    if (!idr.IsClosed)
                    {
                        idr.Close();
                    }
                    return false;
                }
            }


            string sql = string.Format(@"insert into exam values('{0}','{1}','{2}','{3}','{4}','{5}')", ex.ID, courseId,ex.Date, ex.Time, ex.Place,classid);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //院系
        if (type == 8)
        {
            Dept de = (Dept)o;

            //判断是否已存在该院系号
            string sql1 = string.Format("select * from dept where id='{0}'", de.ID);
            idr = SqlTools.Read(sql1);
            if (idr.Read())
            {
                {        //关连接
                    if (!idr.IsClosed)
                    {
                        idr.Close();
                    }
                    return false;
                }
            }

            //name select id
            string selectteacherId = string.Format("select id from teacher where name='{0}'", de.Leader);
            string teacherId = "";
            idr = SqlTools.Read(selectteacherId);
            if (idr.Read())
            {
                teacherId = idr.GetString(0);
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }

            string sql = string.Format(@"insert into dept values('{0}','{1}','{2}')",de.ID,de.Name,teacherId);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }
        }
        //消息
        if (type == 9)
        {
            Message m = (Message)o;


            String RegexStr = @"\d+";
            //如果发送者中含有数字说明发送者为个体，需要判断该个体是否存在
            if (Regex.IsMatch(m.Receiver, RegexStr)||(!m.Receiver.Equals("全部")&& !m.Receiver.Equals("全体老师")&& !m.Receiver.Equals("全体学生")))
            {
                string sql1 = string.Format("select * from student,teacher where student.id='{0}' or teacher.id='{1}'", m.Receiver,m.Receiver);
                idr = SqlTools.Read(sql1);
                //若存在则添加
                if (idr.Read())
                {

                    string sql5 = string.Format(@"insert into publicinformation(submitperson,news,receiver,title) values('{0}','{1}','{2}','{3}')", m.Submitperson, m.News, m.Receiver, m.Title);
                    int i5 = SqlTools.Excute(sql5);
                    if (i5 == 0)
                    {        //关连接
                        if (!idr.IsClosed)
                        {
                            idr.Close();
                        }
                        return false;
                    }
                    else
                    {        //关连接
                        if (!idr.IsClosed)
                        {
                            idr.Close();
                        }
                        return true;
                    }
                }

                //没查询到存在则返回false
                {        //关连接
                    if (!idr.IsClosed)
                    {
                        idr.Close();
                    }
                    return false;
                }

            }

            string sql = string.Format(@"insert into publicinformation(submitperson,news,receiver,title) values('{0}','{1}','{2}','{3}')", m.Submitperson, m.News, m.Receiver, m.Title);
            int i = SqlTools.Excute(sql);
            if (i == 0)
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }
            else
            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return true;
            }





            {        //关连接
                if (!idr.IsClosed)
                {
                    idr.Close();
                }
                return false;
            }


        }




        {        //关连接
            if (!idr.IsClosed)
            {
                idr.Close();
            }
            return false;
        }
    }
}
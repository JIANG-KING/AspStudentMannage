using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Course 的摘要说明
/// </summary>
public class Course
{
    #region field
    private String _ID;//课程id
    private String _Name;//课程名
    private String _Teacher;//任课老师
    private String _Date;//开课日期
    private String _Time;//上课时间
    private String _Week;//上课周次
    private String _Place;//上课地点
    private String _Score;//课程学分
    #endregion
    public Course()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Course(string ID, string Name, string Teacher, string Date, string Time, string Week, string Place, string Score)
    {
        _ID = ID;
        _Name = Name;
        _Teacher = Teacher;
        _Date = Date;
        _Time = Time;
        _Week = Week;
        _Place = Place;
        _Score = Score;
    }

    public string ID
    {
        get
        {
            return _ID;
        }

        set
        {
            _ID = value;
        }
    }

    public string Name
    {
        get
        {
            return _Name;
        }

        set
        {
            _Name = value;
        }
    }

    public string Teacher
    {
        get
        {
            return _Teacher;
        }

        set
        {
            _Teacher = value;
        }
    }

    public string Date
    {
        get
        {
            return _Date;
        }

        set
        {
            _Date = value;
        }
    }

    public string Time
    {
        get
        {
            return _Time;
        }

        set
        {
            _Time = value;
        }
    }

    public string Week
    {
        get
        {
            return _Week;
        }

        set
        {
            _Week = value;
        }
    }

    public string Place
    {
        get
        {
            return _Place;
        }

        set
        {
            _Place = value;
        }
    }

    public string Score
    {
        get
        {
            return _Score;
        }

        set
        {
            _Score = value;
        }
    }
}
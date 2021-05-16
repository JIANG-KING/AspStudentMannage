using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Exam 的摘要说明
/// </summary>
public class Exam
{
    private String _ID;
    private String _Course;
    private String _Date;
    private String _Time;
    private String _Place;
    private String _ClassInfo;

    public Exam()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Exam(string ID, string Course, string Date, string Time, string Place, string ClassInfo)
    {
        _ID = ID;
        _Course = Course;
        _Date = Date;
        _Time = Time;
        _Place = Place;
        _ClassInfo = ClassInfo;
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

    public string Course
    {
        get
        {
            return _Course;
        }

        set
        {
            _Course = value;
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

    public string ClassInfo
    {
        get
        {
            return _ClassInfo;
        }

        set
        {
            _ClassInfo = value;
        }
    }
}
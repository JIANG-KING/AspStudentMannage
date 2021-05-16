using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ClassInfo 的摘要说明
/// </summary>
public class ClassInfo
{
    private String _ID;//班级编码
    private String _Name;//班级名称
    private String _Dept;//所属学院
    private String _Teacher;//班级导员
    public ClassInfo()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public ClassInfo(string iD, string name, string dept, string teacher)
    {
        _ID = iD;
        _Name = name;
        _Dept = dept;
        _Teacher = teacher;
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

    public string Dept
    {
        get
        {
            return _Dept;
        }

        set
        {
            _Dept = value;
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
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Class1 的摘要说明
/// </summary>
public class Dept
{
    private String _ID;//院系或者部门id
    private String _Name;//名称
    private String _Leader;//领导人
    public Dept()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Dept(string ID, string Name, string Leader)
    {
        _ID = ID;
        _Name = Name;
        _Leader = Leader;
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

    public string Leader
    {
        get
        {
            return _Leader;
        }

        set
        {
            _Leader = value;
        }
    }
}
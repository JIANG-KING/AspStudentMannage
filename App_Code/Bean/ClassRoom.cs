using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ClassRoom 的摘要说明
/// </summary>
public class ClassRoom
{
    private String _ID;//教室编码
    private String _Type;//教室类型，机房，实验室教室，报告厅
    private String _Place;//教室地点，一教，二教，三教

    private String _Floor;//教室楼层,1,2,3,4,5,6
    private String _Number;//教室牌号,由教学地点和楼层决定
    private String _Dept;//教室归属院系
    public ClassRoom()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public ClassRoom(string iD, string type, string place, string floor, string number, string dept)
    {
        _ID = iD;
        _Type = type;
        _Place = place;
        _Floor = floor;
        _Number = number;
        _Dept = dept;
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

    public string Type
    {
        get
        {
            return _Type;
        }

        set
        {
            _Type = value;
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

    public string Floor
    {
        get
        {
            return _Floor;
        }

        set
        {
            _Floor = value;
        }
    }

    public string Number
    {
        get
        {
            return _Number;
        }

        set
        {
            _Number = value;
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
}
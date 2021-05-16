using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// AlterString 的摘要说明
/// </summary>
public static class AlterString
{
    public static string outString(string InputString)
    {
        string ShowCourseInfo = "";
        //第一个字符为1说明是星期一
        if (InputString.Substring(0, 1).Equals("1"))
        {
            ShowCourseInfo = "星期一"+"第"+ InputString.Substring(2, 1)+"节课";
        }
        else if (InputString.Substring(0, 1).Equals("2"))
        {
            ShowCourseInfo = "星期二" + "第" + InputString.Substring(2, 1) + "节课";
        }
        else if (InputString.Substring(0, 1).Equals("3"))
        {
            ShowCourseInfo = "星期三" + "第" + InputString.Substring(2, 1) + "节课";
        }
        else if (InputString.Substring(0, 1).Equals("4"))
        {
            ShowCourseInfo = "星期四" + "第" + InputString.Substring(2, 1) + "节课";
        }
        else if (InputString.Substring(0, 1).Equals("5"))
        {
            ShowCourseInfo = "星期五" + "第" + InputString.Substring(2, 1) + "节课";
        }
        return ShowCourseInfo;
    }
}
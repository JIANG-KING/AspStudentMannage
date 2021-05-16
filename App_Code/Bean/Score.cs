using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Score 的摘要说明
/// </summary>
public class Score
{

    private string ID;
    private string Student;
    private string Course;
    private string Scores;
    private string submittime;
    private string submitperson;

    public Score()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Score(string iD, string student, string course, string scores, string submittime, string submitperson)
    {
        ID = iD;
        Student = student;
        Course = course;
        Scores = scores;
        this.submittime = submittime;
        this.submitperson = submitperson;
    }

    public string ID1
    {
        get
        {
            return ID;
        }

        set
        {
            ID = value;
        }
    }

    public string Student1
    {
        get
        {
            return Student;
        }

        set
        {
            Student = value;
        }
    }

    public string Course1
    {
        get
        {
            return Course;
        }

        set
        {
            Course = value;
        }
    }

    public string Scores1
    {
        get
        {
            return Scores;
        }

        set
        {
            Scores = value;
        }
    }

    public string Submittime
    {
        get
        {
            return submittime;
        }

        set
        {
            submittime = value;
        }
    }

    public string Submitperson
    {
        get
        {
            return submitperson;
        }

        set
        {
            submitperson = value;
        }
    }
}
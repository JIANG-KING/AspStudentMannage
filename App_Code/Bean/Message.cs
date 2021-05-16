using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Message 的摘要说明
/// </summary>
public class Message
{
    private string ID;
    private string submitperson;
    private string news;
    private string receiver;
    private string title;
    private string date;

    public Message()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Message(string iD, string submitperson, string news, string receiver, string title, string date)
    {
        ID = iD;
        this.submitperson = submitperson;
        this.news = news;
        this.receiver = receiver;
        this.title = title;
        this.date = date;
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

    public string News
    {
        get
        {
            return news;
        }

        set
        {
            news = value;
        }
    }

    public string Receiver
    {
        get
        {
            return receiver;
        }

        set
        {
            receiver = value;
        }
    }

    public string Title
    {
        get
        {
            return title;
        }

        set
        {
            title = value;
        }
    }

    public string Date
    {
        get
        {
            return date;
        }

        set
        {
            date = value;
        }
    }
}
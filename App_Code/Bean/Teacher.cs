using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Teacher 的摘要说明
/// </summary>
public class Teacher
{
    private String ID;
    private String Password;
    private String Name;
    private String Email;
    private String Telephone;
    private String State;
    private String Sex;
    private String Birthday;
    private String ArriveDate;

    private String Photo;
    private String Address;

    private String Department;

    public Teacher()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Teacher(string iD, string password, string name, string email, string telephone)
    {
        ID = iD;
        Password = password;
        Name = name;
        Email = email;
        Telephone = telephone;
    }

    public Teacher(string iD, string password, string name, string state, string sex, string birthday, string arriveDate, string telephone, string photo, string address, string email, string department)
    {
        ID = iD;
        Password = password;
        Name = name;
        State = state;
        Sex = sex;
        Birthday = birthday;
        ArriveDate = arriveDate;
        Telephone = telephone;
        Photo = photo;
        Address = address;
        Email = email;
        Department = department;
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

    public string Password1
    {
        get
        {
            return Password;
        }

        set
        {
            Password = value;
        }
    }

    public string Name1
    {
        get
        {
            return Name;
        }

        set
        {
            Name = value;
        }
    }

    public string State1
    {
        get
        {
            return State;
        }

        set
        {
            State = value;
        }
    }

    public string Sex1
    {
        get
        {
            return Sex;
        }

        set
        {
            Sex = value;
        }
    }

    public string Birthday1
    {
        get
        {
            return Birthday;
        }

        set
        {
            Birthday = value;
        }
    }

    public string ArriveDate1
    {
        get
        {
            return ArriveDate;
        }

        set
        {
            ArriveDate = value;
        }
    }

    public string Telephone1
    {
        get
        {
            return Telephone;
        }

        set
        {
            Telephone = value;
        }
    }

    public string Photo1
    {
        get
        {
            return Photo;
        }

        set
        {
            Photo = value;
        }
    }

    public string Address1
    {
        get
        {
            return Address;
        }

        set
        {
            Address = value;
        }
    }

    public string Email1
    {
        get
        {
            return Email;
        }

        set
        {
            Email = value;
        }
    }

    public string Department1
    {
        get
        {
            return Department;
        }

        set
        {
            Department = value;
        }
    }

    public override bool Equals(object obj)
    {
        Teacher teacher = obj as Teacher;
        return teacher != null &&
               ID == teacher.ID &&
               Name == teacher.Name &&
               Email == teacher.Email &&
               Telephone == teacher.Telephone;
    }

    public override int GetHashCode()
    {
        int hashCode = 1928104788;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telephone);
        return hashCode;
    }
}
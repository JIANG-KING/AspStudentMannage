using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Student 的摘要说明
/// </summary>
public class Student
{
    private String ID;
    private String Password;
    private String Name;
    private String Email;
    private String Telephone;
    private String Sex;
    private String Class;
    private String Dept;
    private String State;
    private String Birth;
    private String Address;
    private String Photo;


    

    public Student()
    {

    }

    public Student(string iD, string password, string name, string email, string telephone)
    {
        ID = iD;
        Password = password;
        Name = name;
        Email = email;
        Telephone = telephone;
    }

    public Student(string iD, string password, string name, string sex, string @class, string dept, string state, string birth, string address, string photo, string email, string telephone)
    {
        ID = iD;
        Password = password;
        Name = name;
        Sex = sex;
        Class = @class;
        Dept = dept;
        State = state;
        Birth = birth;
        Address = address;
        Photo = photo;
        Email = email;
        Telephone = telephone;

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

    public string Class1
    {
        get
        {
            return Class;
        }

        set
        {
            Class = value;
        }
    }

    public string Dept1
    {
        get
        {
            return Dept;
        }

        set
        {
            Dept = value;
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

    public string Birth1
    {
        get
        {
            return Birth;
        }

        set
        {
            Birth = value;
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

    public override bool Equals(object obj)
    {
        Student student = obj as Student;
        return student != null &&
               ID == student.ID &&
               Name == student.Name &&
               Email == student.Email &&
               Telephone == student.Telephone;
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
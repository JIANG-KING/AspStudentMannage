using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Admin 的摘要说明
/// </summary>
public class Admin
{
    private String ID;
    private String Password;
    private String Name;
    private String Telephone;
    private String AccountLevel;
    private String Email;
    private String Address;


    public Admin()
    {
        
    }

    public Admin(string iD, string password, string name, string telephone, String email)
    {
        ID = iD;
        Password = password;
        Name = name;
        Telephone = telephone;
        Email = email;
    }

    public Admin(string iD, string password, string name, string accountLevel, string email, string address, string telephone)
    {
        ID = iD;
        Password = password;
        Name = name;
        AccountLevel = accountLevel;
        Email = email;
        Address = address;
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

    public string AccountLevel1
    {
        get
        {
            return AccountLevel;
        }

        set
        {
            AccountLevel = value;
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

    public override bool Equals(object obj)
    {
        Admin admin = obj as Admin;
        return admin != null &&
               ID == admin.ID &&
               Name == admin.Name &&
               Telephone == admin.Telephone &&
               Email == admin.Email;
    }

    public override int GetHashCode()
    {
        int hashCode = 1260534484;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telephone);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
        return hashCode;
    }
}
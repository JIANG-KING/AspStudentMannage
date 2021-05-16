using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminTest_SendMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (DropDownListReceive.SelectedValue.Equals("个体")) TextBoxReceiver.Enabled = true;
        else TextBoxReceiver.Enabled = false;
    }

    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        Admin a = (Admin)Session["admin"];
        string receiver = DropDownListReceive.SelectedValue;
        if (receiver.Equals("个体")) receiver = TextBoxReceiver.Text;

        Message m= new Message("","管理员"+a.Name1,TextBoxMessage.Text,receiver,TextBoxTitle.Text,"");
        bool success = dao.AddBody(m, 9);
        if (success) Response.Write("<script>alert('添加成功！')</script>");
        else Response.Write("<script>alert('修改失败！没有此id的用户')</script>");
    }

    protected void DropDownListReceive_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DropDownListReceive.SelectedValue.Equals("个体")) TextBoxReceiver.Enabled = true;
        else TextBoxReceiver.Enabled = false;
    }
}
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatePwd.aspx.cs" Inherits="StudentTest_UpdatePwd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .auto-style1 {
            height: 64px;
        }
        .auto-style2 {
            width: 166px;
            height: 64px;
        }
        .auto-style3 {
            width: 442px;
            height: 321px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" class="auto-style3" >
            <tr>
                <td colspan="2" style="font-family: 微软雅黑; font-size: 10px;">
                    <strong><span style="color: #000000; font-family: 微软雅黑; font-size: large;">修改我的密码</span></strong></td>
                <td colspan="1" style="font-family: 微软雅黑; font-size: 10px;">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: right">
                    <span style="font-size: 10pt; color: #0000ff"><strong style="font-size: small; font-family: 微软雅黑; color: #000000;">原密码</strong></span></td>
                <td style="font-size: 12pt; width: 143px">
                    <asp:TextBox ID="TextBoxOldPwd" runat="server" TextMode="Password" Width="118px"></asp:TextBox></td>
                <td style="font-size: 12pt; width: 166px">
                    <asp:RequiredFieldValidator ID="RFVpwd" runat="server" ControlToValidate="TextBoxConfirmPwd"
                        ErrorMessage="不能为空" Font-Bold="True" Font-Size="10pt"></asp:RequiredFieldValidator></td>
            </tr>
            <tr style="font-size: 12pt; color: #0000ff">
                <td style="width: 100px; text-align: right">
                    <span style="font-size: 10pt"><strong style="font-size: small; color: #000000; font-family: 微软雅黑;">新密码</strong></span></td>
                <td style="width: 143px; color: #000000">
                    <asp:TextBox ID="TextBoxNewPwd" runat="server" TextMode="Password" Width="117px"></asp:TextBox></td>
                <td style="width: 166px; color: #000000">
                    <asp:RequiredFieldValidator ID="RFVNewPwd" runat="server" ControlToValidate="TextBoxNewPwd"
                        ErrorMessage="不能为空" Font-Bold="True" Font-Size="10pt"></asp:RequiredFieldValidator></td>
            </tr>
            <tr style="font-size: 12pt; color: #000000">
                <td style="width: 100px; text-align: right">
                    <span style="font-size: 10pt; color: #000000; font-family: 微软雅黑;"><strong>重复一次</strong></span></td>
                <td style="width: 143px">
                    <asp:TextBox ID="TextBoxConfirmPwd" runat="server" TextMode="Password" Width="116px"></asp:TextBox></td>
                <td style="width: 166px">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxNewPwd"
                        ControlToValidate="TextBoxConfirmPwd" ErrorMessage="两次新密码输入不相同" Font-Bold="True" Font-Size="10pt"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style1">
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="提交" />
                    &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
                    </td>
                <td colspan="1" class="auto-style2">
                    <input id="ButtonReset" runat="server" text="重置" type="reset" value="重置" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

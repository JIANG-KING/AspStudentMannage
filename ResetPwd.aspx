<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ResetPwd.aspx.cs" Inherits="ResetPwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>修改密码</title>
    <style type="text/css">
        .auto-style1 {
            width: 60%;
            height: 368px;
        }
        .auto-style2 {
            height: 27px;
        }
        .auto-style3 {
            width: 100px;
        }
        .auto-style4 {
            height: 27px;
            width: 100px;
        }
        .auto-style5 {
            width: 255px;
        }
        .auto-style6 {
            height: 27px;
            width: 255px;
        }
        </style>
</head>
<body style="height: 479px">
    <form id="form1" runat="server">
        <div>
        </div>
    <table class="auto-style1"align="center">
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">账号：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVID" runat="server" ControlToValidate="TextBoxID" Display="Dynamic" ErrorMessage="请输入账号！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">账号类型:</td>
            <td class="auto-style5" colspan="2">
                <asp:RadioButton ID="RadioButtonAdmin" runat="server" Checked="True" GroupName="Level" Text="管理员" />
                <asp:RadioButton ID="RadioButtonStudent" runat="server" GroupName="Level" Text="学生" />
                <asp:RadioButton ID="RadioButtonTeacher" runat="server" GroupName="Level" Text="老师" />
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">姓名：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVName" runat="server" ControlToValidate="TextBoxName" ErrorMessage="请输入姓名！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" style="font-family: 微软雅黑; color: #3366FF">邮箱：</td>
            <td class="auto-style6" colspan="2">
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2" style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVEmail" runat="server" ControlToValidate="TextBoxEmail" Display="Dynamic" ErrorMessage="请输入邮箱！"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REVEmail" runat="server" ControlToValidate="TextBoxEmail" Display="Dynamic" ErrorMessage="邮箱格式不正确！" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style4" style="font-family: 微软雅黑; color: #3366FF">电话：</td>
            <td class="auto-style6" colspan="2">
                <asp:TextBox ID="TextBoxPhone" runat="server" TextMode="Phone"></asp:TextBox>
            </td>
            <td class="auto-style2" style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVTel" runat="server" ControlToValidate="TextBoxPhone" Display="Dynamic" ErrorMessage="请输入电话！"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REVPhone" runat="server" ControlToValidate="TextBoxPhone" Display="Dynamic" ErrorMessage="电话号码格式不正确！" ValidationExpression="^1(3[0-9]|5[0-3,5-9]|7[1-3,5-8]|8[0-9])\d{8}$"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">新密码</td>
            <td class="auto-style6" colspan="2">
                <asp:TextBox ID="TextBoxPwdNew" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RFVPwdNNew" runat="server" ControlToValidate="TextBoxPwdNew" ErrorMessage="请输入新密码！" Font-Names="微软雅黑"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">确认密码</td>
            <td class="auto-style6" colspan="2">
                <asp:TextBox ID="TextBoxPwdCon" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RFVPwdCon" runat="server" ControlToValidate="TextBoxPwdCon" Display="Dynamic" ErrorMessage="请输入确认密码！" Font-Names="微软雅黑"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CVCon" runat="server" ControlToCompare="TextBoxPwdNew" ControlToValidate="TextBoxPwdCon" Display="Dynamic" ErrorMessage="两次密码不一致" Font-Names="微软雅黑"></asp:CompareValidator>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6" colspan="2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="ButtonSubmit" runat="server" Text="提 交" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#3366FF" align="right" OnClick="ButtonSubmit_Click"/>
            </td>
            <td class="auto-style2">
                <asp:Button ID="ButtonReset" runat="server" Text="重置" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#3366FF" align="right" CausesValidation="False" OnClick="ButtonReset_Click"/>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>

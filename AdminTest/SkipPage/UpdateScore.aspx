<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateScore.aspx.cs" Inherits="AdminTest_SkipPage_UpdateScore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
        .auto-style7 {
            height: 87px;
            width: 100px;
        }
        .auto-style8 {
            height: 87px;
        }
    </style>
</head>
<body style="height: 479px">
    <form id="form1" runat="server">
        <div>
        </div>
    <table class="auto-style1"align="center">
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">课程号：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxCourseID" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">课程名称：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">选择学生：</td>
            <td class="auto-style5" colspan="2">
                <asp:DropDownList ID="DropDownListStudent" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">学生分数：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxScore" runat="server"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVScore" runat="server" ControlToValidate="TextBoxScore" Display="Dynamic" ErrorMessage="请输入分数！"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REVScore" runat="server" ControlToValidate="TextBoxScore" Display="Dynamic" ErrorMessage="分数格式不正确！" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="font-family: 微软雅黑; color: #3366FF">时间：</td>
            <td class="auto-style8" colspan="2">
                <asp:TextBox ID="TextBoxTime" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td class="auto-style8" style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVTime" runat="server" ControlToValidate="TextBoxTime" ErrorMessage="请选择时间！"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="ButtonSubmit" runat="server" Text="提 交" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#3366FF" align="right" OnClick="ButtonSubmit_Click"/>
            </td>
            <td class="auto-style2">
                <asp:Button ID="ButtonExit" runat="server" Text="退 出" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#3366FF" align="right" OnClick="ButtonExit_Click" CausesValidation="False"/>
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


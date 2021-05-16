<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateDept.aspx.cs" Inherits="AdminTest_SkipPage_UpdateDept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 60%;
            height: 287px;
        }
        .auto-style2 {
            height: 27px;
        }
        .auto-style4 {
            height: 27px;
            width: 100px;
        }
        .auto-style6 {
            height: 10px;
            width: 255px;
        }
        .auto-style7 {
            width: 100px;
            height: 50px;
        }
        .auto-style8 {
            width: 255px;
            height: 50px;
        }
        .auto-style9 {
            height: 50px;
        }
        .auto-style10 {
            height: 10px;
            width: 100px;
        }
        .auto-style11 {
            height: 10px;
        }
    </style>
</head>
<body style="height: 479px">
    <form id="form1" runat="server">
        <div>
        </div>
    <table class="auto-style1"align="center">
        <tr>
            <td class="auto-style7" style="font-family: 微软雅黑; color: #3366FF">院系号：</td>
            <td class="auto-style8" colspan="2">
                <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style9" style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVID" runat="server" ControlToValidate="TextBoxID" Display="Dynamic" ErrorMessage="请输入院系号！"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style7" style="font-family: 微软雅黑; color: #3366FF">院系名称：</td>
            <td class="auto-style8" colspan="2">
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style9" style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVName" runat="server" ControlToValidate="TextBoxName" ErrorMessage="请输入专业名称！"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style7" style="font-family: 微软雅黑; color: #3366FF">领导人：</td>
            <td class="auto-style8" colspan="2">
                <asp:DropDownList ID="DropDownListTeacher" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style9">
                </td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style6" colspan="2"></td>
            <td class="auto-style11"></td>
            <td class="auto-style11"></td>
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
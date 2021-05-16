<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendMessage.aspx.cs" Inherits="AdminTest_SendMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 98%;
            height: 352px;
        }
        .auto-style5 {
            width: 255px;
        }
        .auto-style6 {
            height: 27px;
            width: 255px;
        }
        .auto-style2 {
            height: 27px;
        }
        .auto-style7 {
            margin-left: 0px;
        }
        .auto-style10 {
            width: 595px;
            height: 357px;
        }
        .auto-style11 {
            width: 197px;
        }
        .auto-style12 {
            height: 27px;
            width: 197px;
        }
    </style>
</head>
<body style="height: 363px; width: 600px;">
    <form id="form1" runat="server" class="auto-style10">
    <table class="auto-style1"align="left">
        <tr>
            <td class="auto-style11" style="font-family: 微软雅黑; color: #3366FF">请输入标题</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style11" style="font-family: 微软雅黑; color: #3366FF">请输入消息</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxMessage" runat="server" Height="122px" TextMode="MultiLine" Width="321px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12" style="font-family: 微软雅黑; color: #3366FF">接收人</td>
            <td class="auto-style6" colspan="2">
                <asp:DropDownList ID="DropDownListReceive" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListReceive_SelectedIndexChanged">
                    <asp:ListItem Value="全部">全部</asp:ListItem>
                    <asp:ListItem Value="全体老师">全体老师</asp:ListItem>
                    <asp:ListItem Value="全体学生">全体学生</asp:ListItem>
                    <asp:ListItem Value="个体">个体</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style12" style="font-family: 微软雅黑; color: #3366FF">接收人ID<br />
                (选中指定人员时填写)</td>
            <td class="auto-style6" colspan="2">
                <asp:TextBox ID="TextBoxReceiver" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">
                &nbsp;</td>
            <td class="auto-style2">
                <asp:Button ID="ButtonSubmit" runat="server" Text="提 交" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#3366FF" align="right" CssClass="auto-style7" OnClick="ButtonSubmit_Click"/>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>

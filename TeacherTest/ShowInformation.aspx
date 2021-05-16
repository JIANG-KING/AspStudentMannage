<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowInformation.aspx.cs" Inherits="StudentTest_ShowInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 62%;
            height: 481px;
        }
        .auto-style3 {
            width: 100px;
        }
        .auto-style5 {
            width: 255px;
        }
        .auto-style6 {
            width: 100px;
            height: 105px;
        }
        .auto-style7 {
            width: 255px;
            height: 105px;
        }
        .auto-style8 {
            height: 105px;
        }
    </style>
</head>
<body style="height: 479px">
    <form id="form1" runat="server">
        <div>
        </div>
    <table class="auto-style1"align="center">
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">标题：</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBoxTitle" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">内容：</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBoxText" runat="server" Height="153px" ReadOnly="True" TextMode="MultiLine" Width="213px"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">发送者：</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBoxSender" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6" style="font-family: 微软雅黑; color: #3366FF">发送时间：</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBoxTime" runat="server" ReadOnly="True" TextMode="DateTime"></asp:TextBox>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
        </tr>
        </table>
    </form>
    </body>
</html>

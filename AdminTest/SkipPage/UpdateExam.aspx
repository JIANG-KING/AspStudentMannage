<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateExam.aspx.cs" Inherits="AdminTest_SkipPage_UpdateExam" %>

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
        .auto-style6 {
            height: 27px;
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
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">考试号：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVID" runat="server" ControlToValidate="TextBoxID" Display="Dynamic" ErrorMessage="请输入考试号！"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REVId" runat="server" ControlToValidate="TextBoxID" Display="Dynamic" ErrorMessage="考试号格式错误！" ValidationExpression="^[A-Za-z0-9]+$"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">课程：</td>
            <td class="auto-style5" colspan="2">
                <asp:DropDownList ID="DropDownListCourse" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">考试日期：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxDate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVDate" runat="server" ControlToValidate="TextBoxDate" ErrorMessage="请选择考试时间！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="font-family: 微软雅黑; color: #3366FF">考试时间：</td>
            <td class="auto-style8" colspan="3">
                <asp:RadioButton ID="RadioButtonMonday" runat="server" Text="周一" GroupName="Exam" />
                <asp:DropDownList ID="DropDownListMonday" runat="server">
                    <asp:ListItem Value="1">1-2</asp:ListItem>
                    <asp:ListItem Value="2">3-4</asp:ListItem>
                    <asp:ListItem Value="3">5-6</asp:ListItem>
                    <asp:ListItem Value="4">7-8</asp:ListItem>
                    <asp:ListItem Value="5">9-10</asp:ListItem>
                </asp:DropDownList>
                <asp:RadioButton ID="RadioButtonTuesday" runat="server" Text="周二" GroupName="Exam" />
                <asp:DropDownList ID="DropDownListTuesday" runat="server">
                    <asp:ListItem Value="1">1-2</asp:ListItem>
                    <asp:ListItem Value="2">3-4</asp:ListItem>
                    <asp:ListItem Value="3">5-6</asp:ListItem>
                    <asp:ListItem Value="4">7-8</asp:ListItem>
                    <asp:ListItem Value="5">9-10</asp:ListItem>
                </asp:DropDownList>
                <asp:RadioButton ID="RadioButtonWed" runat="server" Text="周三" GroupName="Exam" />
                <asp:DropDownList ID="DropDownListWednesday" runat="server">
                    <asp:ListItem Value="1">1-2</asp:ListItem>
                    <asp:ListItem Value="2">3-4</asp:ListItem>
                    <asp:ListItem Value="3">5-6</asp:ListItem>
                    <asp:ListItem Value="4">7-8</asp:ListItem>
                    <asp:ListItem Value="5">9-10</asp:ListItem>
                </asp:DropDownList>
                <asp:RadioButton ID="RadioButtonThur" runat="server" Text="周四" GroupName="Exam" />
                <asp:DropDownList ID="DropDownListThursday" runat="server">
                    <asp:ListItem Value="1">1-2</asp:ListItem>
                    <asp:ListItem Value="2">3-4</asp:ListItem>
                    <asp:ListItem Value="3">5-6</asp:ListItem>
                    <asp:ListItem Value="4">7-8</asp:ListItem>
                    <asp:ListItem Value="5">9-10</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:RadioButton ID="RadioButtonFri" runat="server" Text="周五" GroupName="Exam" />
                <asp:DropDownList ID="DropDownListFriday" runat="server">
                    <asp:ListItem Value="1">1-2</asp:ListItem>
                    <asp:ListItem Value="2">3-4</asp:ListItem>
                    <asp:ListItem Value="3">5-6</asp:ListItem>
                    <asp:ListItem Value="4">7-8</asp:ListItem>
                    <asp:ListItem Value="5">9-10</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style4" style="font-family: 微软雅黑; color: #3366FF">地点：</td>
            <td class="auto-style6" colspan="2">
                <asp:DropDownList ID="DropDownListPlace" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" style="font-family: 微软雅黑; color: #3366FF">考试班级：</td>
            <td class="auto-style6" colspan="2">
                <asp:DropDownList ID="DropDownListClass" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
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
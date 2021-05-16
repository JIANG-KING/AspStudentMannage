<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddTeacher.aspx.cs" Inherits="AdminTest_SkipPage_AddTeacher" %>

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
        .auto-style9 {
            height: 27px;
            width: 180px;
        }
        .auto-style10 {
            height: 27px;
            width: 58px;
        }
    </style>
</head>
<body style="height: 479px">
    <form id="form1" runat="server">
        <div>
        </div>
    <table class="auto-style1"align="center">
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">教师号：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVID" runat="server" ControlToValidate="TextBoxID" Display="Dynamic" ErrorMessage="请输入教师号！"></asp:RequiredFieldValidator>
            </td>
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
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">密码：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVPwd" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="请输入密码！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">性别：</td>
            <td class="auto-style5" colspan="2">
                <asp:RadioButton ID="RadioButtonSexMale" runat="server" Checked="True" GroupName="Sex" Text="男" />
                <asp:RadioButton ID="RadioButtonSexFemale" runat="server" GroupName="Sex" Text="女" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">部门：</td>
            <td class="auto-style5" colspan="2">
                <asp:DropDownList ID="DropDownListDept" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">学历：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxState" runat="server"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVState" runat="server" ControlToValidate="TextBoxState" Display="Dynamic" ErrorMessage="请输入学历！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">出生年月：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxBirth" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVBirth" runat="server" ControlToValidate="TextBoxBirth" Display="Dynamic" ErrorMessage="请输入出生年月！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">入职时间：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxArriveDate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVTArriveDate" runat="server" ControlToValidate="TextBoxArriveDate" ErrorMessage="请输入入职时间！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">住址：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVAddress" runat="server" ControlToValidate="TextBoxAddress" Display="Dynamic" ErrorMessage="请输入住址！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" style="font-family: 微软雅黑; color: #3366FF">邮箱：</td>
            <td class="auto-style6" colspan="2">
                <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email"></asp:TextBox>
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
            <td class="auto-style4"></td>
            <td class="auto-style6" colspan="2"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="ButtonSubmit" runat="server" Text="提 交" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#3366FF" align="right" OnClick="ButtonSubmit_Click"/>
            </td>
            <td class="auto-style9">
                <asp:Button ID="ButtonExit" runat="server" Text="退 出" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#3366FF" align="right" OnClick="ButtonExit_Click" CausesValidation="False"/>
            </td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>

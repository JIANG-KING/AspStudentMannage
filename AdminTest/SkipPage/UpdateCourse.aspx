<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateCourse.aspx.cs" Inherits="AdminTest_SkipPage_UpdateClass" %>

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
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">课程号：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxID" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVID" runat="server" ControlToValidate="TextBoxID" Display="Dynamic" ErrorMessage="请输入课程号！"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REVId" runat="server" ControlToValidate="TextBoxID" Display="Dynamic" ErrorMessage="课程号格式错误！" ValidationExpression="^[A-Za-z0-9]+$"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">课程名称：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVName" runat="server" ControlToValidate="TextBoxName" ErrorMessage="请输入课程名称！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">教师：</td>
            <td class="auto-style5" colspan="2">
                <asp:DropDownList ID="DropDownListTeacher" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3" style="font-family: 微软雅黑; color: #3366FF">开课日期：</td>
            <td class="auto-style5" colspan="2">
                <asp:TextBox ID="TextBoxDate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVDate" runat="server" ControlToValidate="TextBoxDate" ErrorMessage="请选择开课时间！"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7" style="font-family: 微软雅黑; color: #3366FF">开课时间：</td>
            <td class="auto-style8" colspan="3">
                <asp:CheckBox ID="RadioButtonMonday" runat="server" Text="周一" />
                <asp:DropDownList ID="DropDownListMonday" runat="server">
                    <asp:ListItem Value="1">1-2</asp:ListItem>
                    <asp:ListItem Value="2">3-4</asp:ListItem>
                    <asp:ListItem Value="3">5-6</asp:ListItem>
                    <asp:ListItem Value="4">7-8</asp:ListItem>
                    <asp:ListItem Value="5">9-10</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBox ID="RadioButtonTuesday" runat="server" Text="周二" />
                <asp:DropDownList ID="DropDownListTuesday" runat="server">
                    <asp:ListItem Value="1">1-2</asp:ListItem>
                    <asp:ListItem Value="2">3-4</asp:ListItem>
                    <asp:ListItem Value="3">5-6</asp:ListItem>
                    <asp:ListItem Value="4">7-8</asp:ListItem>
                    <asp:ListItem Value="5">9-10</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBox ID="RadioButtonWed" runat="server" Text="周三" />
                <asp:DropDownList ID="DropDownListWednesday" runat="server">
                    <asp:ListItem Value="1">1-2</asp:ListItem>
                    <asp:ListItem Value="2">3-4</asp:ListItem>
                    <asp:ListItem Value="3">5-6</asp:ListItem>
                    <asp:ListItem Value="4">7-8</asp:ListItem>
                    <asp:ListItem Value="5">9-10</asp:ListItem>
                </asp:DropDownList>
                <asp:CheckBox ID="RadioButtonThur" runat="server" Text="周四" />
                <asp:DropDownList ID="DropDownListThursday" runat="server">
                    <asp:ListItem Value="1">1-2</asp:ListItem>
                    <asp:ListItem Value="2">3-4</asp:ListItem>
                    <asp:ListItem Value="3">5-6</asp:ListItem>
                    <asp:ListItem Value="4">7-8</asp:ListItem>
                    <asp:ListItem Value="5">9-10</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:CheckBox ID="RadioButtonFri" runat="server" Text="周五" />
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
            <td class="auto-style4" style="font-family: 微软雅黑; color: #3366FF">开课周次：</td>
            <td class="auto-style6" colspan="2">
                <asp:DropDownList ID="DropDownListStart" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                </asp:DropDownList>
                到<asp:DropDownList ID="DropDownListEnd" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                </asp:DropDownList>
                周</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
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
            <td class="auto-style4" style="font-family: 微软雅黑; color: #3366FF">学分：</td>
            <td class="auto-style6" colspan="2">
                <asp:TextBox ID="TextBoxScore" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style2" style="font-family: 微软雅黑; color: #FF0000">
                <asp:RequiredFieldValidator ID="RFVScore" runat="server" ControlToValidate="TextBoxScore" Display="Dynamic" ErrorMessage="请输入学分！"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="REVScore" runat="server" ControlToValidate="TextBoxScore" Display="Dynamic" ErrorMessage="学分格式不正确！" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="ButtonSubmit" runat="server" Text="提 交" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#3366FF" align="right" OnClick="ButtonSubmit_Click"/>
            </td>
            <td class="auto-style2">
                <asp:Button ID="ButtonExit" runat="server" Text="退 出" Font-Names="微软雅黑" Font-Size="Medium" ForeColor="#3366FF" align="right" CausesValidation="False" OnClick="ButtonExit_Click"/>
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


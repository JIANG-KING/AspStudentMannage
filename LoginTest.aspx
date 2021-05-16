<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginTest.aspx.cs" Inherits="LoginTest"   %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="style/css/BackGround.css" rel="stylesheet" />
    <style type="text/css">
        #TextArea4 {
            z-index: 1;
            left: 829px;
            top: 199px;
            position: absolute;
        }
        .auto-style12 {
            width: 1479px;
            height: 747px;
        }
        .auto-style14 {
            width: 128px;
            height: 63px;
        }
        .auto-style16 {
            width: 504px;
            height: 63px;
        }
        .auto-style17 {
            width: 80px;
            height: 63px;
        }
        .auto-style18 {
            height: 152px;
        }
        .auto-style20 {
            width: 80px;
            height: 152px;
        }
        .auto-style22 {
            width: 128px;
            height: 152px;
        }
        .auto-style23 {
            height: 6px;
        }
        .auto-style24 {
            width: 504px;
            height: 6px;
        }
        .auto-style25 {
            width: 80px;
            height: 6px;
        }
        .auto-style27 {
            width: 128px;
            height: 6px;
        }
        .auto-style28 {
            height: 22px;
        }
        .auto-style29 {
            width: 504px;
            height: 22px;
        }
        .auto-style30 {
            width: 80px;
            height: 22px;
        }
        .auto-style32 {
            width: 128px;
            height: 22px;
        }
        .auto-style37 {
            width: 186px;
            height: 63px;
        }
        .auto-style38 {
            width: 186px;
            height: 152px;
        }
        .auto-style39 {
            width: 186px;
            height: 6px;
        }
        .auto-style40 {
            width: 186px;
            height: 22px;
        }
        .auto-style41 {
            height: 20px;
        }
        .auto-style42 {
            width: 504px;
            height: 20px;
        }
        .auto-style43 {
            width: 80px;
            height: 20px;
        }
        input.ipt{width:400px;height:24px;border-radius:3px;}
        .auto-style45 {
            width: 128px;
            height: 20px;
        }
        .auto-style46 {
            height: 7px;
        }
        .auto-style47 {
            width: 504px;
            height: 7px;
        }
        .auto-style48 {
            width: 80px;
            height: 7px;
        }
        .auto-style49 {
            width: 186px;
            height: 7px;
        }
        .auto-style50 {
            width: 128px;
            height: 7px;
        }
        .auto-style54 {
            height: 24px;
        }
        .auto-style55 {
            width: 504px;
            height: 24px;
        }
        .auto-style56 {
            width: 128px;
            height: 24px;
        }
        .auto-style60 {
            width: 97px;
            height: 20px;
        }
        .auto-style63 {
            height: 36px;
        }
        .auto-style64 {
            width: 504px;
            height: 36px;
        }
        .auto-style65 {
            width: 128px;
            height: 36px;
        }
        .auto-style67 {
            height: 55px;
        }
        .auto-style68 {
            width: 80px;
            height: 55px;
        }
        .auto-style69 {
            width: 186px;
            height: 55px;
        }
        .auto-style70 {
            width: 128px;
            height: 55px;
        }
        .auto-style71 {
            width: 91px;
            height: 20px;
        }
        .auto-style72 {
            height: 63px;
        }
        .auto-style75 {
            height: 40px;
        }
        .auto-style76 {
            width: 128px;
            height: 40px;
        }
        </style>
</head>
<body style="height: 762px; width: 1494px"   >

    <form id="form1" runat="server">
        <table class="auto-style12" >
            <tr>
                <td class="auto-style46"></td>
                <td class="auto-style46"></td>
                <td class="auto-style47"></td>
                <td class="auto-style48"></td>
                <td class="auto-style49" colspan="2"></td>
                <td class="auto-style50"></td>
            </tr>
            <tr>
                <td class="auto-style18" colspan="3">
                    <asp:Image ID="ImageLogo" runat="server" Height="150px" ImageUrl="~/images/LoginLogo.png" />
                </td>
                <td class="auto-style20"></td>
                <td class="auto-style38" colspan="2"></td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                <td class="auto-style18" colspan="3">
                    &nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style38" colspan="2">&nbsp;</td>
                <td class="auto-style22">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style67" colspan="3">
                </td>
                <td class="auto-style68"></td>
                <td class="auto-style69" colspan="2"></td>
                <td class="auto-style70"></td>
            </tr>
            <tr>
                <td class="auto-style23"></td>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style24"></td>
                <td class="auto-style25">
                    <asp:Label ID="LabelAccount" runat="server" Font-Names="微软雅黑" Text="账号：" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style39" colspan="2">
                    <asp:TextBox ID="TextBoxAccount" runat="server" Height="30px" Width="200px" CssClass="ipt"></asp:TextBox>
                </td>
                <td class="auto-style27">
                    <asp:RequiredFieldValidator ID="RFVAccount" runat="server" ControlToValidate="TextBoxAccount" ErrorMessage="请输入账号" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style25">
                    &nbsp;</td>
                <td class="auto-style39" colspan="2">
                    &nbsp;</td>
                <td class="auto-style27">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style29"></td>
                <td class="auto-style30">
                    <asp:Label ID="Labelpwd" runat="server" Font-Names="微软雅黑" Text="密码：" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style40" colspan="2">
                    <asp:TextBox ID="TextBoxPassword" runat="server" Height="30px" Width="200px" CssClass="ipt" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style32">
                    <asp:RequiredFieldValidator ID="RFVPassword" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="请输入密码" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style30">
                    &nbsp;</td>
                <td class="auto-style40" colspan="2">
                    &nbsp;</td>
                <td class="auto-style32">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style41"></td>
                <td class="auto-style41"></td>
                <td class="auto-style42"></td>
                <td class="auto-style43">
                    <asp:Label ID="Labelcode" runat="server" Font-Names="微软雅黑" Text="验证码：" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style60">
                    <asp:TextBox ID="TextBoxCheckcode" runat="server" Height="30px" Width="100px" CssClass="ipt"></asp:TextBox>
                </td>
                <td class="auto-style71">
                    <img alt="" src="ImageChecked.aspx" style="border-radius:3px;" width="100px" height="40px" onclick="this.src=this.src+'?Math.random()';" /></td>
                <td class="auto-style45">
                    <asp:RequiredFieldValidator ID="RFV" runat="server" ControlToValidate="TextBoxCheckcode" ErrorMessage="请输入验证码" ForeColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style63"></td>
                <td class="auto-style63"></td>
                <td class="auto-style64"></td>
                <td class="auto-style63">
                </td>
                <td class="auto-style63" colspan="2">
                    <asp:Label ID="LabelTips" runat="server" Text="看不清？单击图片换一个" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style65"></td>
            </tr>
            <tr>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style55">&nbsp;</td>
                <td colspan="3" class="auto-style54">
                    <asp:RadioButton ID="RadioButtonStudent" runat="server" GroupName="Level" Text="学生" ForeColor="White" />
                    <asp:RadioButton ID="RadioButtonTeacher" runat="server" GroupName="Level" Text="教师" ForeColor="White" />
                    <asp:RadioButton ID="RadioButtonAdmin" runat="server" GroupName="Level" Text="管理员" ForeColor="White" />
                </td>
                <td class="auto-style56">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style54"></td>
                <td class="auto-style54"></td>
                <td class="auto-style55"></td>
                <td colspan="3" class="auto-style54">
                    <asp:Button ID="ButtonLogin" runat="server" ForeColor="White" Height="40px" Text="登 录" Width="290px" Font-Names="微软雅黑" Font-Size="Medium" BackColor="#009999" OnClick="ButtonLogin_Click" CssClass="ipt" />
                </td>
                <td class="auto-style56">
                    <script language="javascript"> 
<!-- 
    function openwin() {
        window.open("ResetPwd.aspx", "", "width=700,height=500")
    }
//-->
                    </script>

                    <input id="ButtonRestPwd" class="auto-style76" style="background-color: #009999; font-family: 微软雅黑; color: #FFFFFF;" type="button" value="重置密码" onclick="openwin()" /></td>
            </tr>
            <tr>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style54">&nbsp;</td>
                <td class="auto-style55">&nbsp;</td>
                <td colspan="3" class="auto-style54">
                    &nbsp;</td>
                <td class="auto-style56">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style72"></td>
                <td class="auto-style72"></td>
                <td class="auto-style16"></td>
                <td class="auto-style17"></td>
                <td class="auto-style37" colspan="2">
                    &nbsp;</td>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td class="auto-style75" colspan="7" align=center>
                    <asp:Label ID="LabelCopy" runat="server" Text="Copyright © 1999-2021 Yunking. All rights reserved." ></asp:Label>
                </td>
            </tr>
        </table>
    </form>
 
</body>
</html>




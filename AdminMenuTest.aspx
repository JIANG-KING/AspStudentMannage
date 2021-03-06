<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminMenuTest.aspx.cs" Inherits="AdminMenuTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 99%;
            height: 713px;
        }
        .auto-style2 {
            height: 44px;
        }
        .auto-style4 {
            height: 28px;
        }
        .auto-style11 {
            height: 28px;
            width: 300px;
        }
        .auto-style15 {
            height: 28px;
            width: 130px;
        }
        .auto-style94 {
            height: 20px;
            width: 300px;
        }
        .auto-style95 {
            height: 20px;
            width: 130px;
        }
        .auto-style98 {
            height: 20px;
        }
        .auto-style115 {
            height: 30px;
        }
        .auto-style116 {
            height: 30px;
            width: 300px;
        }
        .auto-style130 {
            height: 20px;
            width: 30px;
        }
        .auto-style131 {
            height: 28px;
            width: 30px;
        }
        .auto-style134 {
            height: 140px;
            width: 142px;
        }
        .auto-style145 {
            width: 70px;
        }
        .auto-style153 {
            width: 146px;
        }
        .auto-style154 {
            height: 20px;
            width: 146px;
        }
        .auto-style155 {
            height: 28px;
            width: 146px;
        }
        .auto-style205 {
            height: 46px;
            width: 300px;
        }
        .auto-style207 {
            width: 146px;
            height: 46px;
        }
        .auto-style208 {
            height: 46px;
            width: 30px;
        }
        .auto-style209 {
            height: 46px;
            width: 130px;
        }
        .auto-style210 {
            height: 46px;
        }
        .auto-style223 {
            height: 30px;
            width: 146px;
        }
        .auto-style224 {
            height: 30px;
            width: 30px;
        }
        .auto-style225 {
            height: 30px;
            width: 130px;
        }
        .auto-style226 {
            height: 70px;
        }
        .auto-style227 {
            width: 100px;
        }
        .auto-style228 {
            height: 140px;
            width: 96px;
        }
        .auto-style229 {
            height: 30px;
            width: 298px;
        }
        .auto-style231 {
            height: 28px;
            width: 298px;
        }
        .auto-style232 {
            height: 20px;
            width: 298px;
        }
        .auto-style233 {
            height: 46px;
            width: 298px;
        }
        .auto-style235 {
            height: 30px;
            width: 70px;
        }
        .auto-style236 {
            height: 46px;
            width: 70px;
        }
        .auto-style238 {
            width: 20px;
        }
        .auto-style239 {
            height: 28px;
            width: 20px;
        }
        .auto-style240 {
            height: 20px;
            width: 20px;
        }
        .auto-style241 {
            height: 30px;
            width: 20px;
        }
        .auto-style242 {
            height: 46px;
            width: 20px;
        }
        .auto-style244 {
            width: 636px;
        }
        .auto-style245 {
            height: 30px;
            width: 120px;
        }
        .auto-style246 {
            height: 28px;
            width: 120px;
        }
        .auto-style247 {
            height: 20px;
            width: 120px;
        }
        .auto-style248 {
            height: 46px;
            width: 120px;
        }
        .auto-style250 {
            height: 9px;
            width: 70px;
        }
        .auto-style251 {
            height: 9px;
            width: 120px;
        }
        .auto-style252 {
            height: 9px;
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style227" style="background-color: #3399FF">
                    <asp:Image ID="ImageLogo" runat="server" Height="49px" ImageUrl="~/images/LoginLogo.png" Width="176px" />
                </td>
                <td class="auto-style226" style="background-color: #3399FF" colspan="11" align="right">
                    <asp:Button ID="ButtonEsc" runat="server" BackColor="#3399FF" BorderColor="Black" BorderStyle="None" Font-Names="黑体" Font-Size="Large" ForeColor="White" Text="退出" Height="20px" Width="50px"  align="right" OnClick="ButtonEsc_Click"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style227" style="background-color: #3399FF" rowspan="11">
                    <asp:TreeView ID="TreeViewMain" runat="server" Font-Names="微软雅黑" Font-Size="Large" Height="290px" Width="182px" ForeColor="White"  Target="IframShow" >
                        <Nodes>
                            <asp:TreeNode Text="学生信息管理" Value="学生成绩管理" NavigateUrl="~/AdminTest/StudentInfo.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="课程信息管理" Value="课程信息管理" NavigateUrl="~/AdminTest/CourseInfo.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="学生成绩管理" Value="学生信息管理" NavigateUrl="~/AdminTest/ScoreInfo.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="教室信息管理" Value="教师信息管理" NavigateUrl="~/AdminTest/ClassroomInfo.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="教师信息管理" Value="管理员信息管理" NavigateUrl="~/AdminTest/TeacherInfo.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="考试信息管理" Value="专业信息管理" NavigateUrl="~/AdminTest/ExamInfo.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="专业信息管理" Value="公告信息管理" NavigateUrl="~/AdminTest/DeptInfo.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="公告信息管理" Value="公告信息管理"  NavigateUrl="~/AdminTest/SendMessage.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="~/AdminTest/UpdatePwd.aspx" Text="修改密码" Value="修改密码"></asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                </td>
                <td class="auto-style235">
                    &nbsp;</td>
                <td class="auto-style245">
                    &nbsp;</td>
                <td class="auto-style116" colspan="2"></td>
                <td class="auto-style229">
                    <asp:Label ID="LabelWelcome" runat="server" Text="欢迎登录！"></asp:Label>
                </td>
                <td class="auto-style153">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="auto-style238">
                    &nbsp;</td>
                <td class="auto-style115">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style228" colspan="2">
                    <asp:Image ID="ImagePhoto" runat="server" ImageUrl="https://z3.ax1x.com/2021/05/15/g6hH39.gif" />
                </td>
                <td class="auto-style134">
                    &nbsp;</td>
                <td colspan="6" rowspan="3" align="right">
                    <iframe id="IframShow" name="IframShow" src="displayinfo.aspx?info=欢迎使用本系统" height="300" class="auto-style244"></iframe>
                </td>
                <td rowspan="3" style="width:80px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style250">
                    &nbsp;</td>
                <td class="auto-style251">
                    <asp:Label ID="LabelIevel" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="Level："></asp:Label>
                </td>
                <td class="auto-style252" colspan="2">
                    <asp:Label ID="ShowLevel" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="Level："></asp:Label>
                    </td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style246">
                    <asp:Label ID="LabelId" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="ID："></asp:Label>
                </td>
                <td class="auto-style11" colspan="2">
                    <asp:Label ID="ShowID" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="ID："></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style246">
                    <asp:Label ID="LabelEmail" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="邮箱："></asp:Label>
                </td>
                <td class="auto-style11" colspan="2">
                    <asp:Label ID="ShowEmail" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="邮箱："></asp:Label>
                </td>
                <td class="auto-style231">&nbsp;</td>
                <td class="auto-style153">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="auto-style238">
                    &nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style246">
                    <asp:Label ID="LabelPhone" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="电话:"></asp:Label>
                </td>
                <td class="auto-style11" colspan="2">
                    <asp:Label ID="ShowPhone" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="电话:"></asp:Label>
                </td>
                <td class="auto-style231"></td>
                <td class="auto-style155">
                    &nbsp;</td>
                <td class="auto-style131"></td>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style131"></td>
                <td class="auto-style239">
                    &nbsp;</td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style246">
                    &nbsp;</td>
                <td class="auto-style11" colspan="2">
                    &nbsp;</td>
                <td class="auto-style231"></td>
                <td class="auto-style155"></td>
                <td class="auto-style131"></td>
                <td class="auto-style15"></td>
                <td class="auto-style131"></td>
                <td class="auto-style239"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style247"></td>
                <td class="auto-style94" colspan="2"></td>
                <td class="auto-style232">&nbsp;</td>
                <td class="auto-style154">
                    &nbsp;</td>
                <td class="auto-style130"></td>
                <td class="auto-style95">
                    &nbsp;</td>
                <td class="auto-style130"></td>
                <td class="auto-style240">
                    &nbsp;</td>
                <td class="auto-style98"></td>
            </tr>
            <tr>
                <td class="auto-style235"></td>
                <td class="auto-style245"></td>
                <td class="auto-style116" colspan="2"></td>
                <td class="auto-style229"></td>
                <td class="auto-style223" style="border-color: #0099FF; background-image: none; table-layout: auto;">
                    &nbsp;</td>
                <td class="auto-style224"></td>
                <td class="auto-style225"></td>
                <td class="auto-style224"></td>
                <td class="auto-style241"></td>
                <td class="auto-style115"></td>
            </tr>
            <tr>
                <td class="auto-style236"></td>
                <td class="auto-style248"></td>
                <td class="auto-style205" colspan="2"></td>
                <td class="auto-style233"></td>
                <td class="auto-style207"></td>
                <td class="auto-style208"></td>
                <td class="auto-style209"></td>
                <td class="auto-style208"></td>
                <td class="auto-style242"></td>
                <td class="auto-style210"></td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="11" align="middle">
                    <asp:Label ID="LabelCopy" runat="server" Text="Copyright © 1999-2021 Yunking. All rights reserved." ></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Studentmain.aspx.cs" Inherits="StudentTest_Studentmain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 99%;
            height: 781px;
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
        .auto-style12 {
            height: 44px;
            width: 300px;
        }
        .auto-style94 {
            height: 37px;
            width: 300px;
        }
        .auto-style98 {
            height: 37px;
        }
        .auto-style134 {
            height: 201px;
            width: 142px;
        }
        .auto-style145 {
            width: 70px;
        }
        .auto-style153 {
            width: 146px;
        }
        .auto-style226 {
            height: 68px;
        }
        .auto-style227 {
            width: 100px;
        }
        .auto-style228 {
            height: 201px;
            width: 96px;
        }
        .auto-style229 {
            height: 28px;
            width: 298px;
        }
        .auto-style237 {
            height: 44px;
            width: 70px;
        }
        .auto-style238 {
            width: 20px;
        }
        .auto-style244 {
            width: 636px;
            height: 337px;
        }
        .auto-style246 {
            height: 28px;
            width: 120px;
        }
        .auto-style247 {
            height: 37px;
            width: 120px;
        }
        .auto-style249 {
            height: 44px;
            width: 120px;
        }
        .auto-style250 {
            height: 45px;
            width: 70px;
        }
        .auto-style251 {
            height: 45px;
            width: 120px;
        }
        .auto-style252 {
            height: 45px;
            width: 300px;
        }
        .auto-style253 {
            width: 70px;
            height: 28px;
        }
        .auto-style254 {
            width: 70px;
            height: 50px;
        }
        .auto-style255 {
            height: 50px;
            width: 120px;
        }
        .auto-style256 {
            height: 50px;
            width: 300px;
        }
        .auto-style257 {
            height: 50px;
        }
        .auto-style258 {
            width: 70px;
            height: 49px;
        }
        .auto-style259 {
            height: 49px;
            width: 120px;
        }
        .auto-style260 {
            height: 49px;
            width: 300px;
        }
        .auto-style261 {
            height: 49px;
        }
        .auto-style262 {
            height: 48px;
            width: 120px;
        }
        .auto-style263 {
            height: 48px;
            width: 300px;
        }
        .auto-style264 {
            height: 48px;
        }
        .auto-style265 {
            height: 42px;
            width: 70px;
        }
        .auto-style266 {
            height: 42px;
            width: 120px;
        }
        .auto-style267 {
            height: 42px;
            width: 300px;
        }
        .auto-style268 {
            height: 42px;
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
                <td class="auto-style227" style="background-color: #3399FF" rowspan="10">
                    <asp:TreeView ID="TreeViewMain" runat="server" Font-Names="微软雅黑" Font-Size="Large" Height="290px" Width="182px" ForeColor="White" Target="IframeShow" >
                        <Nodes>
                            <asp:TreeNode Text="选课信息" Value="课程信息管理">
                                <asp:TreeNode Text="选课" Value="选课" NavigateUrl="~/StudentTest/SelectCourse.aspx"></asp:TreeNode>
                                <asp:TreeNode Text="查询选课结果" Value="查询选课结果" NavigateUrl="~/StudentTest/ShowSelectCourse.aspx"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="成绩信息" Value="成绩信息" NavigateUrl="~/StudentTest/ShowScore.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="考试信息" Value="考试信息" NavigateUrl="~/StudentTest/ShowExam.aspx"></asp:TreeNode>
                            <asp:TreeNode></asp:TreeNode>
                            <asp:TreeNode Text="个人信息" Value="个人信息">
                                <asp:TreeNode Text="修改密码" Value="修改密码" NavigateUrl="~/StudentTest/UpdatePwd.aspx"></asp:TreeNode>
                                <asp:TreeNode Text="查看公告" Value="查看公告" NavigateUrl="~/StudentTest/ShowPublicInformation.aspx"></asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                </td>
                <td class="auto-style253">
                    <asp:Button ID="ButtonRefresh" runat="server" Height="27px" OnClick="Page_Load" Text="刷新" Width="50px" BorderStyle="None" Font-Names="微软雅黑" ForeColor="#0066FF" />
                    </td>
                <td class="auto-style246">
                    &nbsp;</td>
                <td class="auto-style11" colspan="2">&nbsp;</td>
                <td class="auto-style229">
                    <asp:Label ID="LabelShowWelcome" runat="server" Text="欢迎登录！"></asp:Label>
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
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style228" colspan="2">
                    <asp:Image ID="ImageHead" runat="server" Width="107px" />
                </td>
                <td class="auto-style134">
                    &nbsp;</td>
                <td colspan="6" rowspan="4" align="right">
                    <iframe id="IframeShow" name="IframeShow" src="../displayinfo.aspx?info=欢迎使用本系统" class="auto-style244"></iframe>
                </td>
                <td rowspan="3" style="width:80px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style250">
                    </td>
                <td class="auto-style251">
                    <asp:Label ID="LabelName" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="姓名："></asp:Label>
                </td>
                <td class="auto-style252" colspan="2">
                    <asp:Label ID="LabelShowName" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="姓名"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style251">
                    <asp:Label ID="LabelClass" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="班级："></asp:Label>
                </td>
                <td class="auto-style252" colspan="2">
                    <asp:Label ID="LabelShowClass" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="班级"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style237">
                    </td>
                <td class="auto-style249">
                    <asp:Label ID="LabelDept" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="院系："></asp:Label>
                </td>
                <td class="auto-style12" colspan="2">
                    <asp:Label ID="LabelShowDept" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Text="院系"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style254">
                    </td>
                <td class="auto-style255">
                    &nbsp;</td>
                <td class="auto-style256" colspan="2">
                    &nbsp;</td>
                <td colspan="6" rowspan="6" align="right">
                    <asp:GridView ID="GridViewCourse" runat="server" AutoGenerateColumns="False" Height="196px" Width="655px" Font-Names="微软雅黑" Font-Size="Smaller">
                        <Columns>
                            <asp:BoundField HeaderText="周/节次">
                            <HeaderStyle Height="20px" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="星期一" />
                            <asp:BoundField HeaderText="星期二" />
                            <asp:BoundField HeaderText="星期三" />
                            <asp:BoundField HeaderText="星期四" />
                            <asp:BoundField HeaderText="星期五" />
                        </Columns>
                        <HeaderStyle BackColor="#3366FF" />
                    </asp:GridView>
                </td>
                <td class="auto-style257"></td>
            </tr>
            <tr>
                <td class="auto-style258">
                    &nbsp;</td>
                <td class="auto-style259">
                    &nbsp;</td>
                <td class="auto-style260" colspan="2">
                    &nbsp;</td>
                <td class="auto-style261">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style262">
                    &nbsp;</td>
                <td class="auto-style263" colspan="2">
                    &nbsp;</td>
                <td class="auto-style264"></td>
            </tr>
            <tr>
                <td class="auto-style145">
                    &nbsp;</td>
                <td class="auto-style247"></td>
                <td class="auto-style94" colspan="2"></td>
                <td class="auto-style98"></td>
            </tr>
            <tr>
                <td class="auto-style265"></td>
                <td class="auto-style266"></td>
                <td class="auto-style267" colspan="2"></td>
                <td class="auto-style268"></td>
            </tr>
            <tr>
                <td class="auto-style227" style="background-color: #3399FF" rowspan="2">
                    &nbsp;</td>
                <td class="auto-style265"></td>
                <td class="auto-style266"></td>
                <td class="auto-style267" colspan="2"></td>
                <td class="auto-style268"></td>
            </tr>
            <tr>
                <td class="auto-style268" colspan="11" align="middle">
                    <asp:Label ID="LabelCopy" runat="server" Text="Copyright © 1999-2021 Yunking. All rights reserved." ></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

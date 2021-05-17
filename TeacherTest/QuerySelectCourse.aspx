<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QuerySelectCourse.aspx.cs" Inherits="TeacherTest_QuerySelectCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <table class="auto-style1">
            <tr>
                <td class="auto-style10">
                    <asp:GridView ID="GridViewQuerySelectCourse" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="301px" Width="759px">
                        <Columns>
                            <asp:BoundField HeaderText="课程号" DataField="CourseID" />
                            <asp:BoundField HeaderText="课程名称" DataField="Coursename" />
                            <asp:BoundField HeaderText="选择学生" DataField="studentname" />
                            <asp:BoundField HeaderText="学生学号" DataField="studentID" />
                            <asp:BoundField HeaderText="课程学分" DataField="coursescore" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle ForeColor="#000066" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#007DBB" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#00547E" />
                    </asp:GridView>
                </td>
            </tr>
            </table>
    </form>
</body>
</html>

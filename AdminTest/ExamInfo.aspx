<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExamInfo.aspx.cs" Inherits="AdminTest_ExamInfo" %>

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
                    <asp:GridView ID="GridViewExamInfo" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="301px" Width="759px" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" Font-Size="Smaller">
                        <Columns>
                            <asp:BoundField HeaderText="考试号 " DataField="id" />
                            <asp:BoundField HeaderText="课程" DataField="name" />
                            <asp:BoundField HeaderText="考试日期" DataField="date" />
                            <asp:BoundField HeaderText="考试时间" DataField="time" />
                            <asp:BoundField HeaderText="地点" DataField="place" />
                            <asp:BoundField HeaderText="考试班级" DataField="classname" />
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:CommandField ShowEditButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
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
                    <asp:Button ID="Button1" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Height="30px" Text="管 理" Width="100px" OnClick="Button1_Click" />
                </td>
            </tr>
            </table>
    </form>
</body>
</html>

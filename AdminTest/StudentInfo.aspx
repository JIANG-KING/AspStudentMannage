<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentInfo.aspx.cs" Inherits="AdminTest_StudentInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 61%;
            height: 285px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:GridView ID="GridViewStudent" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="301px" Width="759px" OnRowEditing="GridView1_RowEditing" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting" Font-Size="Smaller">
                        <Columns>
                            <asp:BoundField HeaderText="学号" DataField="id" />
                            <asp:BoundField HeaderText="姓名" DataField="name" />
                            <asp:BoundField HeaderText="密码" DataField="password" />
                            <asp:BoundField HeaderText="性别" DataField="sex" />
                            <asp:BoundField HeaderText="班级" DataField="class" />
                            <asp:BoundField HeaderText="专业" DataField="dept" />
                            <asp:BoundField HeaderText="学历" DataField="state" />
                            <asp:BoundField HeaderText="出生年月" DataField="birth" />
                            <asp:BoundField HeaderText="住址" DataField="address" />
                            <asp:BoundField HeaderText="邮箱" DataField="email" />
                            <asp:BoundField HeaderText="电话" DataField="telephone" />
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
                    <asp:Button ID="Button1" runat="server" Font-Names="微软雅黑" Font-Size="Large" ForeColor="#3366FF" Height="30px" Text="添加" Width="100px" OnClick="Button1_Click" />
                </td>
            </tr>
            </table>
    </form>
</body>
</html>

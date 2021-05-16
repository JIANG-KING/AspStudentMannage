<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowExam.aspx.cs" Inherits="StudentTest_ShowExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 816px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <table class="auto-style1">
            <tr>
                <td class="auto-style10">
                    <asp:GridView ID="GridViewShowExam" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="0" Height="301px" Width="784px" Font-Size="Smaller">
                        <Columns>
                            <asp:BoundField HeaderText="考试号" DataField="ID" />
                            <asp:BoundField HeaderText="课程号" DataField="Course" />
                            <asp:BoundField HeaderText="课程名" />
                            <asp:BoundField HeaderText="考试日期" DataField="Date" />
                            <asp:BoundField HeaderText="考试时间" DataField="Time" />
                            <asp:BoundField HeaderText="考试地点" DataField="Place" />
                            <asp:BoundField DataField="ClassInfo" HeaderText="考试班级" />
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
    <p>
&nbsp;</p>
</body>
</html>

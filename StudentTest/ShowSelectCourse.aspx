<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowSelectCourse.aspx.cs" Inherits="StudentTest_ShowSelectCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 816px;
        }
        .auto-style2 {
            width: 86px;
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
                    <asp:GridView ID="GridViewShowSelectCourse" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="0" Height="301px" Width="784px" Font-Size="Smaller" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField HeaderText="课程号" />
                            <asp:BoundField HeaderText="课程名" />
                            <asp:BoundField HeaderText="讲师" />
                            <asp:BoundField HeaderText="开课日期" />
                            <asp:BoundField HeaderText="节次" />
                            <asp:BoundField HeaderText="周次" />
                            <asp:BoundField HeaderText="上课地点" />
                            <asp:BoundField HeaderText="学分" />
                            <asp:TemplateField HeaderText="取消" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="取消"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
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

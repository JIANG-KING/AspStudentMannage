<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowPublicInformation.aspx.cs" Inherits="StudentTest_ShowPublicInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 672px;
            height: 306px;
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
                    <asp:GridView ID="GridViewInformation" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="301px" Width="664px" Font-Size="Smaller" OnSelectedIndexChanged="GridViewInformation_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField HeaderText="序号" />
                            <asp:BoundField HeaderText="标题" DataField="Title" />
                            <asp:BoundField HeaderText="发送人" DataField="SubmitPerson" />
                            <asp:BoundField HeaderText="发送时间" DataField="Time" />
                            <asp:TemplateField HeaderText="查看">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="选择"></asp:LinkButton>
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

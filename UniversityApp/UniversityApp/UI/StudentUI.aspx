<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentUI.aspx.cs" Inherits="UniversityApp.UI.StudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 26px;
            width: 282px;
            text-align: right;
        }
        .auto-style3 {
            width: 282px;
            text-align: right;
        }
        .auto-style4 {
            height: 26px;
            width: 434px;
        }
        .auto-style5 {
            width: 434px;
        }
        .auto-style6 {
            width: 282px;
            text-align: right;
            height: 33px;
        }
        .auto-style7 {
            width: 434px;
            height: 33px;
        }
        .auto-style8 {
            height: 33px;
        }
        .auto-style9 {
            margin-left: 0px;
        }
        .auto-style10 {
            margin-left: 95px;
            margin-right: 242px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Student Name :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="nameTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style3">Student ID :</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="idTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Student Email :</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="emailTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Department :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="deptTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Phone :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="phoneTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Registration No :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="regnoTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Student Gender :</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="genderTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Blood Group :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="bgTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Student ID :Student Hall Name :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="hallTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Address :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="addressTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Student University Name :</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="universityTextBox" runat="server" Width="430px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="submitButton" runat="server" CssClass="auto-style9" OnClick="submitButton_Click" Text="Submit Data" Width="160px" />
                        &nbsp;</td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="messageLabel" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="studentGridView" runat="server" CellPadding="4" CssClass="auto-style10" ForeColor="#333333" GridLines="None" Height="188px" Width="825px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEdit.aspx.cs" Inherits="UniversityApp.UI.StudentEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 368px;
            text-align: right;
        }
        .auto-style2 {
            width: 368px;
            height: 26px;
            text-align: right;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            margin-left: 73px;
        }
        .auto-style5 {
            text-align: right;
            width: 1118px;
            height: 17px;
        }
        .auto-style6 {
            margin-left: 143px;
        }
        .auto-style7 {
            width: 368px;
            height: 27px;
        }
        .auto-style9 {
            width: 501px;
        }
        .auto-style10 {
            height: 26px;
            width: 501px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Student Registration No :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="regnoTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style10">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="searchButton" runat="server" CssClass="auto-style6" Text="Search" Width="143px" OnClick="searchButton_Click" />
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style1">Student Name :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="nameTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Student ID :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="idTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Student Email :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="emailTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Student Department :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="deptTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Student Phone :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="phoneTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Student Registration No :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="updateregnoTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Student Gender :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="genderTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Student Blood Group :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="bgTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Student Hall Name :</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="hallTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Student Address :</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="addressTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Student University :&nbsp; </td>
                    <td class="auto-style10">
                        <asp:TextBox ID="universityTextBox" runat="server" Width="525px"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style10">
                        <asp:Button ID="deleteButton" runat="server" CssClass="auto-style4" Text="Delete" Width="137px" OnClick="deleteButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="updateButton" runat="server" CssClass="auto-style4" Text="Update Data" Width="130px" OnClick="updateButton_Click" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="messageLabel" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                </tr>
            </table>
        </div>
        <p class="auto-style5">
            &nbsp;</p>
    </form>
</body>
</html>

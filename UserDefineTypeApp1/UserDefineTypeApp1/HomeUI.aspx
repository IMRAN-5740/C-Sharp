<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="UserDefineTypeApp1.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 379px;
            text-align: right;
        }
        .auto-style2 {
            width: 379px;
            height: 26px;
            text-align: right;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 523px;
        }
        .auto-style5 {
            width: 523px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">First Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="firstNameTextBox" runat="server" Width="376px"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style1">Middle Name</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="middleNameTextBox" runat="server" Width="378px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Last Name</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="lastnameTextBox" runat="server" Width="379px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit Data" Width="143px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="showAllButton" runat="server" OnClick="showAllButton_Click" Text="Show All Data" Width="160px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">See the Name List:</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:ListBox ID="nameListBox" runat="server" Height="256px" Width="380px"></asp:ListBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

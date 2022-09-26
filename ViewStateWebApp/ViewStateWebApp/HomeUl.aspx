<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUl.aspx.cs" Inherits="ViewStateWebApp.HomeUl" %>

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
            width: 107px;
            text-align: center;
        }
        .auto-style3 {
            width: 107px;
        }
        .auto-style4 {
            height: 26px;
            width: 467px;
        }
        .auto-style5 {
            width: 467px;
        }
        .auto-style7 {
            width: 107px;
            height: 27px;
            text-align: center;
        }
        .auto-style8 {
            width: 467px;
            height: 27px;
        }
        .auto-style9 {
            height: 27px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Input Name"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="nameTextBox" runat="server" Width="450px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5">

                        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit Data" Width="156px" />
                        

                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show Data" Width="150px" />
                        

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label2" runat="server" Text="Output Name"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="outputTextBox" runat="server" Width="453px" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style9"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

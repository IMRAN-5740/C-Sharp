<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEnrollUI.aspx.cs" Inherits="UniversityApp.UI.StudentEnrollUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 409px;
            text-align: right;
        }
        .auto-style2 {
            width: 409px;
            text-align: right;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Student Name :</td>
                    <td>
                        <asp:DropDownList ID="studentNameDropDownList" runat="server" Height="17px" Width="179px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Course Name :</td>
                    <td>
                        <asp:DropDownList ID="courseNameDropDownList" runat="server" Height="17px" Width="179px">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="enrollButton" runat="server" OnClick="enrollButton_Click" Text="Enroll Data" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;&nbsp; </td>
                    <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="messageLabel" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HelloWorldWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
        <br /> 
            <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
           
        
            <asp:TextBox ID="nameTextBox" runat="server" Width="314px"></asp:TextBox>
           <%-- <input name="nameTextBox" type="text" runat="server" value="" id="nameTextBox" style="width:314px;">--%>
           
        
            <br /> <br />
            <asp:Button ID="showButton" runat="server" Text="Show Data" OnClick="showButton_Click" />
            <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

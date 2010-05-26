<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UntestedApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    
    
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="orderform" runat="server">   
        <h1>New Order</h1>
        First Name:
        <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
        <br />
        Last Name:<asp:TextBox ID="LastName" runat="server"></asp:TextBox>
        <br />
        Address 1:<asp:TextBox ID="addr1" runat="server"></asp:TextBox>
        <br />
        Address 2:<asp:TextBox ID="addr2" runat="server"></asp:TextBox>
        <br />
        City
        <asp:TextBox ID="City" runat="server"></asp:TextBox>
        State
        <asp:TextBox ID="state" runat="server" Width="38px"></asp:TextBox>
        Zip<asp:TextBox ID="zip" runat="server" Width="54px"></asp:TextBox>
       
    </div>
    <p>
        Products:</p>
    <p>
        <asp:CheckBoxList ID="widgets" runat="server">
            <asp:ListItem Value="1">Widget 1</asp:ListItem>
            <asp:ListItem Value="2">Widget 2</asp:ListItem>
            <asp:ListItem Value="3">Widget 3</asp:ListItem>
            <asp:ListItem Value="4">Widget 4</asp:ListItem>
            <asp:ListItem Value="5">Widget 5</asp:ListItem>
        </asp:CheckBoxList>
    </p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </asp:Panel>
    <asp:Panel ID="thankyou" Visible="false" runat="server">
        <h1>Thank you!</h1>
    </asp:Panel>
    </form>
</body>
</html>

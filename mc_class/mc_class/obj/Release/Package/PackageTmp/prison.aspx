﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prison.aspx.cs" Inherits="mc_class.prison" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prison</title>
    <link href="Styles/StyleSheet.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="PRISON ENROLLMENT"></asp:Label>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox_lastname" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox_firstname" runat="server"></asp:TextBox>
            <br /><br />
            <asp:CheckBox ID="CheckBox_male" Text="Male" AutoPostBack="true" runat="server" OnCheckedChanged="CheckBox_male_CheckedChanged" />
             <br /><br />
             <asp:Label ID="Label4" runat="server" Text="Prison"></asp:Label>
             <br />
            <asp:DropDownList ID="DropDownList_prisons" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>

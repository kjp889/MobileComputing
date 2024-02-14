﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modules.aspx.cs" Inherits="mc_class.modules" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Module Info"></asp:Label>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Student"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList_Student" AutoPostBack="true" DataTextField="student" DataValueField="student num" runat="server" OnSelectedIndexChanged="DropDownList_Student_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:Label ID="Label_student_name" ForeColor="Brown" runat="server" Text=" "></asp:Label>
            <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Module"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList_Modules" AutoPostBack="true" DataTextField="module code" DataValueField="module num" runat="server" OnSelectedIndexChanged="DropDownList_Modules_SelectedIndexChanged"></asp:DropDownList>
            <br /><br />
            <asp:Label ID="Label4" runat="server" Text="Lecturer"></asp:Label>
            <br />
            <asp:Label ID="Label_lecturer" ForeColor="Brown" runat="server" Text="label"></asp:Label>
            <br />
            <asp:Label ID="Label_email" ForeColor="Brown" runat="server" Text="label"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Faculty/College to which module belongs"></asp:Label>
            <br />
            <asp:Label ID="Label_faculty_owner" ForeColor="Brown" runat="server" Text="label"></asp:Label>
            <br /><br />
            <asp:Label ID="Label5" runat="server" Text="Students Doing Module"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList_Students_Doing_Module" DataTextField="student_name" DataValueField="student num" runat="server"></asp:DropDownList>
            <br /><br />
        </div>
    </form>
</body>
</html>

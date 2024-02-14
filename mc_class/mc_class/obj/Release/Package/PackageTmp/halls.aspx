<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="halls.aspx.cs" Inherits="mc_class.halls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Halls</title>
    <link href="Styles/StyleSheet.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Utech Residential Hall Applications"></asp:Label>
            <br /><br />
            <asp:CheckBox ID="CheckBox_student" runat="server" AutoPostBack="true" Text="Student" OnCheckedChanged="CheckBox_student_CheckedChanged" />
            <br />
            <asp:CheckBox ID="CheckBox_is_an_athlete" Enabled="false" AutoPostBack="true" OnCheckedChanged="CheckBox_is_an_athlete_CheckedChanged" runat="server" Text="Is an Athlete" />
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Hall"></asp:Label><br />
            <asp:DropDownList ID="DropDownList_halls" runat="server" Enabled="false"></asp:DropDownList>
            <br /><br />
            <asp:Button ID="Button_reset" runat="server" Text="Reset" OnClick="Button_reset_Click" /><br />
        </div>
    </form>
</body>
</html>

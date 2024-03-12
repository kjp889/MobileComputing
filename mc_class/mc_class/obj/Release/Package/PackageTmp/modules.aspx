<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modules.aspx.cs" Inherits="mc_class.modules" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/StyleSheet_module.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="formModules" runat="server">
        <div id="divMain" class="div" runat="server">
            <asp:Button CssClass="button" ID="Button_Main_Student_Maintenance" runat="server" Text="Student Maintenance" OnClick="Button_Main_Student_Maintenance_Click" />
            <asp:Button CssClass="button" ID="Button_Main_Module_Maintenance" runat="server" Text="Module Maintenance" />
            <asp:Button CssClass="button" ID="Button_Main_Module_Info" runat="server" Text="Module Info" OnClick="Button_Main_Module_Info_Click" />
        </div>

        <div id="divModuleInfo" runat="server">
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
            <asp:Button CssClass="button" ID="Button_go_back1" runat="server" Text="Go Back" OnClick="Button_go_back1_Click" />
        </div>

        <div id="divStudentMain" runat="server">
            <br />
            <asp:Label CssClass="label" runat="server" Text="Student"></asp:Label><br />
            <asp:DropDownList CssClass="droplist" ID="DropDownList_studentMain_students" AutoPostBack="true" DataTextField="student" DataValueField="student num" runat="server" OnSelectedIndexChanged="DropDownList_studentMain_students_SelectedIndexChanged"></asp:DropDownList><br />
            <asp:Button CssClass="button" ID="Button_studentMain_edit" runat="server" Text="Edit" OnClick="Button_studentMain_edit_Click" />
            <br /><br />
            <asp:Label CssClass="label" runat="server" Text="First Name"></asp:Label><br />
            <asp:TextBox CssClass="textbox" ID="TextBox_studentMain_firstName" MaxLength="17" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label CssClass="label" runat="server" Text="Last Name"></asp:Label><br />
            <asp:TextBox CssClass="textbox" ID="TextBox_studentMain_lastName" MaxLength="17" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label CssClass="label" ID="Label_studentMain_feedback" runat="server" Text="Label"></asp:Label><br />
            <asp:Button CssClass="button" ID="Button_studentMain_new" runat="server" Text="New" OnClick="Button_studentMain_new_Click" /><br />
            <asp:Button CssClass="button" ID="Button_studentMain_add" runat="server" Text="Add" OnClick="Button_studentMain_add_Click" /><br />
            <asp:Button CssClass="button" ID="Button_studentMain_update" runat="server" Text="Update" OnClick="Button_studentMain_update_Click" /><br />
            <asp:Button CssClass="button" ID="Button_go_back2" runat="server" Text="Go Back" OnClick="Button_go_back1_Click" /><br />
        </div>     
    </form>
</body>
</html>

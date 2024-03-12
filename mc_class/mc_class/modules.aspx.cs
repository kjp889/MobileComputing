using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace mc_class
{
    public partial class modules : System.Web.UI.Page
    {
        DataAccessModules dbAccess = new DataAccessModules();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                startUp();
            }
        }

        void startUp()
        {
            DropDownList_Student.DataSource = dbAccess.getAllStudents();
            DropDownList_Student.DataBind();
            refreshModules();
            divsOff();

            divMain.Visible = true;
        }

        void divsOff()
        {
            divMain.Visible =
                divModuleInfo.Visible =
                divStudentMain.Visible = false;
        }

        void refreshModules()
        {
            DropDownList_Modules.DataSource = dbAccess.getModules(int.Parse(DropDownList_Student.SelectedValue));
            DropDownList_Modules.DataBind();
            showModuleInfo();
            //getSudentsDoing_Module();
        }

        protected void DropDownList_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshModules();
            showStudent();
            getSudentsDoing_Module();
        }

        protected void DropDownList_Modules_SelectedIndexChanged(object sender, EventArgs e)
        {
            showModuleInfo();
            getSudentsDoing_Module();
        }

        void getSudentsDoing_Module()
        {
            DropDownList_Students_Doing_Module.Items.Clear();

            if (DropDownList_Modules.Items.Count == 0)
            {
                return;
            }

            DropDownList_Students_Doing_Module.DataSource = dbAccess.getStudentsDoingModule(int.Parse(DropDownList_Modules.SelectedValue));
            DropDownList_Students_Doing_Module.DataBind();
        }

        void showModuleInfo()
        {
            Label_faculty_owner.Text = Label_lecturer.Text = Label_email.Text = string.Empty;

            if (DropDownList_Modules.Items.Count == 0)
            {
                return;
            }

            DataTable db = dbAccess.getModule(int.Parse(DropDownList_Modules.SelectedValue));

            Label_faculty_owner.Text = db.Rows[0]["fc name"].ToString();
            Label_lecturer.Text = db.Rows[0]["lecturer"].ToString();
            Label_email.Text = db.Rows[0]["email"].ToString();
        }

        void showStudent()
        {
            Label_student_name.Text = string.Empty;

            if (DropDownList_Student.Items.Count == 0)
            {
                return;
            }

            DataTable db = dbAccess.getStudent(int.Parse(DropDownList_Student.SelectedValue));

            Label_student_name.Text = db.Rows[0]["stud"].ToString();
        }

        protected void DropDownList_Students_Doing_Module_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button_go_back1_Click(object sender, EventArgs e)
        {
            divsOff();
            divMain.Visible = true;
        }

        protected void Button_Main_Module_Info_Click(object sender, EventArgs e)
        {
            divsOff();
            divModuleInfo.Visible = true;
        }

        protected void Button_Main_Student_Maintenance_Click(object sender, EventArgs e)
        {
            divsOff();
            divStudentMain.Visible = true;
            clearMessages();
            refreshStudentMain_students();
        }

        string Empty() { return string.Empty; }

        void clearMessages()
        {
            Label_studentMain_feedback.Text = Empty();
        }

        void formsStudentMaintenanceOff()
        {
            TextBox_studentMain_firstName.Enabled =
                TextBox_studentMain_lastName.Enabled =
                Button_studentMain_add.Enabled =
                Button_studentMain_update.Enabled = false;

            TextBox_studentMain_firstName.BackColor =
               TextBox_studentMain_lastName.BackColor =
               Button_studentMain_add.BackColor =
               Button_studentMain_update.BackColor = System.Drawing.Color.LightGray;
        }

        void formsOff()
        {
            formsStudentMaintenanceOff();
        }

        void refreshStudentMain_students()
        {
            formsOff();
            DropDownList_studentMain_students.DataSource = dbAccess.getAllStudents();
            DropDownList_studentMain_students.DataBind();
            showStudentMain();
        }

        void showStudentMain()
        {
            DataTable db = dbAccess.getStudentSingle(int.Parse(DropDownList_studentMain_students.SelectedValue));

            TextBox_studentMain_firstName.Text = db.Rows[0]["first name"].ToString();
            TextBox_studentMain_lastName.Text = db.Rows[0]["last name"].ToString();
        }

        protected void DropDownList_studentMain_students_SelectedIndexChanged(object sender, EventArgs e)
        {
            showStudentMain();
        }

        protected void Button_studentMain_edit_Click(object sender, EventArgs e)
        {
            formsOff();
            clearMessages();

            TextBox_studentMain_firstName.Enabled =
                TextBox_studentMain_lastName.Enabled =
                Button_studentMain_update.Enabled = true;

            TextBox_studentMain_firstName.BackColor =
                TextBox_studentMain_lastName.BackColor = System.Drawing.Color.LightYellow;
             
            Button_studentMain_update.BackColor = System.Drawing.Color.PaleVioletRed;
        }

        protected void Button_studentMain_update_Click(object sender, EventArgs e)
        {
            clearMessages();

            if(TextBox_studentMain_firstName.Text == Empty())
            {
                Label_studentMain_feedback.Text = "<font color='red'>A first name is still required...</font><br />";
                return;
            }
            if (TextBox_studentMain_lastName.Text == Empty())
            {
                Label_studentMain_feedback.Text = "<font color='red'>A last name is still required...</font><br />";
                return;
            }

            dbAccess.updateStudent(int.Parse(DropDownList_studentMain_students.SelectedValue), TextBox_studentMain_firstName.Text, TextBox_studentMain_lastName.Text);
            refreshStudentMain_students();
            Label_studentMain_feedback.Text = "<font color='blue'>DONE...</font><br />";
        }

        protected void Button_studentMain_add_Click(object sender, EventArgs e)
        {
            clearMessages();

            if (TextBox_studentMain_firstName.Text == Empty())
            {
                Label_studentMain_feedback.Text = "<font color='red'>A first name is still required...</font><br />";
                return;
            }
            if (TextBox_studentMain_lastName.Text == Empty())
            {
                Label_studentMain_feedback.Text = "<font color='red'>A last name is still required...</font><br />";
                return;
            }

            dbAccess.addStudent(TextBox_studentMain_firstName.Text, TextBox_studentMain_lastName.Text);
            refreshStudentMain_students();
            Label_studentMain_feedback.Text = "<font color='blue'>DONE...</font><br />";
        }

        protected void Button_studentMain_new_Click(object sender, EventArgs e)
        {
            formsOff();
            clearMessages();

            TextBox_studentMain_firstName.Enabled =
                TextBox_studentMain_lastName.Enabled =
                Button_studentMain_add.Enabled = true;

            TextBox_studentMain_firstName.BackColor =
                TextBox_studentMain_lastName.BackColor = System.Drawing.Color.LightYellow;

            Button_studentMain_add.BackColor = System.Drawing.Color.PaleVioletRed;

            TextBox_studentMain_firstName.Text =
                TextBox_studentMain_lastName.Text = Empty();
        }
    }
}
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
            divMain.Visible = divModuleInfo.Visible = false;
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
    }
}
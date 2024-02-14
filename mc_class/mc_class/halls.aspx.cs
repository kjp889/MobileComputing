using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mc_class
{
    public partial class halls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshHallNames();
            toggleElemets();
        }

        protected void CheckBox_student_CheckedChanged(object sender, EventArgs e)
        {
            toggleElemets();
        }

        protected void CheckBox_is_an_athlete_CheckedChanged(object sender, EventArgs e)
        {
            refreshHallNames();
        }

        protected void Button_reset_Click(object sender, EventArgs e)
        {
            resetElements();
            toggleElemets();
        }

        void toggleElemets()
        {
            if (CheckBox_student.Checked)
            {
                DropDownList_halls.Enabled = true;
                CheckBox_is_an_athlete.Enabled = true;
            }
            else
            {
                DropDownList_halls.Enabled = false;
                CheckBox_is_an_athlete.Enabled = false;
            }
        }

        void refreshHallNames()
        {
            DropDownList_halls.Items.Clear();
            if (CheckBox_is_an_athlete.Checked)
            {
                DropDownList_halls.Items.Add("Jaban Hall");
                DropDownList_halls.Items.Add("Manning Hall");
            }
            else
            {
                DropDownList_halls.Items.Add("Peter's Hall");
                DropDownList_halls.Items.Add("Alfred Sangster Hall");
            }
        }

        void resetElements()
        {
            CheckBox_student.Checked = false;
            CheckBox_is_an_athlete.Checked = false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_UserDetailForm
{
    public partial class WebForm_UserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lstLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write(txtName.Text +"</br>");
            Response.Write(lstLocation.SelectedItem.Text +"</br>");
            var gender = "";
            if (rdbtnFemale.Checked)
            {
                gender = "Female";
            }
            else if (rdbtnMale.Checked)
            {
                // lblGender.Text = rdbtnMale.Text;
                gender = "Male";
            }
            else
            {
               // lblGender.Text = rdbtnOther.Text;
                gender = "Others";
            }

           
            Response.Write(gender + "</br>");

            var courses = "";
            if (chkJava.Checked)
            {
                courses = chkJava.Text + " ";
            }
            if (chkCs.Checked)
            {
                courses += chkCs.Text + " ";
            }
            if (chkReact.Checked)
            {
                courses += chkReact.Text;
            }
            if (chkPython.Checked)
            {
                courses += chkPython.Text;
            }
           
            lblCourse.Text = courses;
            Response.Write(courses + "</br>");


            lblName.Visible = false;
            txtName.Visible = false;
            lblLocation.Visible = false;
            lstLocation.Visible = false;
            lblGender.Visible= false;
            rdbtnFemale.Visible = false;
            rdbtnFemale.Checked=false;
            rdbtnMale.Visible = false;
            rdbtnMale.Checked=false;
            rdbtnOther.Visible = false;
            rdbtnOther.Checked=false;
            lblCourse.Visible=false;
            chkJava.Visible = false;
            chkJava.Checked=false;
            chkCs.Visible = false;
            chkCs.Checked = false;
            chkReact.Visible = false;
            chkReact.Checked = false;
            chkPython.Checked = false;
            chkPython.Visible = false;
            btnSubmit.Visible = false;
            

        }
    }
}
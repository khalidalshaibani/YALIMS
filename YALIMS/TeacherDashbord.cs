using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YALIMS
{
    public partial class TeacherDashbord : Form
    {
        public TeacherDashbord()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            pnl_studentsmenu.Visible = false;
            pnl_marksmenu.Visible = false;
        }

        private void hidemenu()
        {
            if (pnl_studentsmenu.Visible == true)
                pnl_studentsmenu.Visible = false;
            if (pnl_marksmenu.Visible == true)
                pnl_studentsmenu.Visible = false;
        }

        private void showmenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hidemenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btn_students_Click(object sender, EventArgs e)
        {
            showmenu(pnl_studentsmenu);

        }
        #region studentsmenu

        private void btn_newstudent_Click(object sender, EventArgs e)
        {
            openChildForm(new Newstudent());
            //...
            //..Your code
            //...

            hidemenu();
        }
        private void btn_managestudents_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_students());
            //...
            //..Your code
            //...

            hidemenu();
        }


        #endregion

        private void btn_marks_Click(object sender, EventArgs e)
        {
            showmenu(pnl_marksmenu);
        }

        #region marksmenu

        private void btn_addmark_Click(object sender, EventArgs e)
        {
            openChildForm(new Add_marks());
            //...
            //..Your code
            //...

            hidemenu();
        }

        private void btn_managemarks_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_marks());
            //...
            //..Your code
            //...

            hidemenu();
        }

        #endregion

        //to show register form in mainform
        //private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            //iveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
    }
}

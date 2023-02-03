using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YALIMS.Model;

namespace YALIMS
{
    public partial class LoginStudent : Form
    {
        public LoginStudent()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Username = txt_usrname.Text;
            student.Password = txt_password.Text;

            DataTable userdata = student.Find(student.Username);
            if (userdata != null)
            {
                if (userdata.Rows[0].Field<string>("password") == student.Password)
                {
                    StudentDashbord stdDash = new StudentDashbord();
                    this.Hide();
                    stdDash.ShowDialog();
                    this.Close();
                } else
                {

                    MessageBox.Show("Password or username are wrong!", "Warning!");
                }
            } else
            {
                MessageBox.Show("password or Username are wrong!", "Warning!");
            }
        }
    }
}

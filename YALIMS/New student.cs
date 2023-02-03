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
    public partial class Newstudent : Form
    {
       // Studentclass student = new Studentclass();

        public Newstudent()
        {
            InitializeComponent();
        }

        private void Newstudent_Load(object sender, EventArgs e)
        {
           // showTable();
        }





        // To show student list in DatagridView
        /*
        public void showTable()
        {
            DataGridView_students.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_students.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        */
    }
}

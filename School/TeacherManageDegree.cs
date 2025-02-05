using Microsoft.EntityFrameworkCore;
using School.Modules;
using School.VM;
using SchoolDAL.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class TeacherManageDegree : Form
    {

        TeacherDashBoard form;
        Teacher teacher;
        SchoolDbContext context;
        List<Class> classes;


        public TeacherManageDegree(TeacherDashBoard f)
        {
            form = f;
            teacher = form.teacher;
            context = f.context;
            InitializeComponent();
        }

        private void TeacherManageDegree_Load(object sender, EventArgs e)
        {
            DateTime specificDate = new DateTime(2023, 1, 1);
            classes = context.EnrolllmentTeacherClassSubject.Where(x => x.TeacherId == teacher.TeacherID).Select(t => t.classs).Distinct().ToList();
            comboBox1.DataSource = classes;
            comboBox1.ValueMember = "ClassID";
            comboBox1.DisplayMember = "ClassName";


        }
       //close  btn
        private void button1_Click(object sender, EventArgs e)
        {
            form.closeforms();
            this.Close();
        }

        //choose class and date to update data grid view
        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            var stuinclass = context.Degrees.Include(d => d.Student).Where(s => s.Student.classId == (int)comboBox1.SelectedValue)
                 .Join(context.StudentsAttendance.Where(d => d.day == datepickerfrom.Value), d => d.StudentId, a => a.StudentId, (d, a) => new { a.StudentId, a.day, StudentName = $"{d.Student.FirstName}{d.Student.LastName}", TotalMarks = d.mark, a.status }).ToList();
            dgv_degrees.DataSource = stuinclass;
            dgv_degrees.Columns["StudentId"].Visible = false;


        }
        int id = 0;
        //select updated row
        private void dgv_degrees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id = Convert.ToInt32(dgv_degrees.Rows[rowIndex].Cells[0].Value);
            stname.Text = (dgv_degrees.Rows[rowIndex].Cells[2].Value).ToString();
            stdegree.Text = (dgv_degrees.Rows[rowIndex].Cells[3].Value).ToString();

        }
        //update student degree
        private void button2_Click(object sender, EventArgs e)
        {
            Degree s = context.Degrees.Where(s => s.StudentId == id).FirstOrDefault();
            decimal? addeddegree = string.IsNullOrEmpty(degreeadded.Text) ? (decimal?)0 : Convert.ToDecimal(degreeadded.Text);
            s.mark = s.mark + addeddegree;
            context.Degrees.Update(s);
            context.SaveChanges();
            stname.Text = stdegree.Text = degreeadded.Text = "";
            var stuinclass = context.Degrees.Include(d => d.Student).Where(s => s.Student.classId == (int)comboBox1.SelectedValue)
                .Join(context.StudentsAttendance.Where(d => d.day == datepickerfrom.Value), d => d.StudentId, a => a.StudentId, (d, a) => new { a.StudentId, a.day, StudentName = $"{d.Student.FirstName}{d.Student.LastName}", TotalMarks = d.mark, a.status }).ToList();
            dgv_degrees.DataSource = stuinclass;
            dgv_degrees.Columns["StudentId"].Visible = false;

        }
        //handle numeric values in degree text
        private void degreeadded_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //signout
        private void btnsignout_Click(object sender, EventArgs e)
        {
            form.loginForm.Show();
            form.Close();
            this.Close();
        }
    }
}

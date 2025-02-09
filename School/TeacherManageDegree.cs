using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        List<DegreeViewModel> AllStudentInClass;
        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            List<Student> students = context.students.Where(s => s.classId == (int)comboBox1.SelectedValue).ToList();

            List<int?> existingStudentIds = context.Degrees.Where(d => d.SubId == teacher.SubjectId && d.Student.classId == (int)comboBox1.SelectedValue).Select(d => d.StudentId).ToList();
            List<Student> studentsToAdd = students
            .Where(s => !existingStudentIds.Contains(s.StudentID))
                .ToList();


            foreach (var student in studentsToAdd)
            {
                context.Degrees.Add(new Degree
                {
                    StudentId = student.StudentID,
                    SubId = teacher.SubjectId,
                    mark = 0
                });
            }


            context.SaveChanges();

            AllStudentInClass = context.Degrees.Include(d => d.Student).Where(d => d.SubId == teacher.SubjectId && d.Student.classId == (int)comboBox1.SelectedValue).Select(s => new DegreeViewModel
            {
                DegreeId = s.DegreeId,
                SubId = s.SubId,
                studentname = s.Student.FirstName + s.Student.LastName,
                StudentId = s.StudentId,
                mark = s.mark
            }).ToList();

            dgv_degrees.DataSource = AllStudentInClass;
            dgv_degrees.Columns["StudentId"].Visible = false;
            dgv_degrees.Columns["SubId"].Visible = false;
            dgv_degrees.Columns["DegreeId"].Visible = false;




        }
        int id = 0;
        //select updated row
        private void dgv_degrees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            id = Convert.ToInt32(dgv_degrees.Rows[rowIndex].Cells["DegreeId"].Value);
            stname.Text = (dgv_degrees.Rows[rowIndex].Cells["studentname"].Value).ToString();
            stdegree.Text = (dgv_degrees.Rows[rowIndex].Cells["mark"].Value).ToString();

        }
        //update student degree
        private void button2_Click(object sender, EventArgs e)
        {
            Degree s = context.Degrees.Where(d => d.DegreeId == id).FirstOrDefault();
            decimal? addeddegree = string.IsNullOrEmpty(degreeadded.Text) ? (decimal?)0 : Convert.ToDecimal(degreeadded.Text);
            s.mark = s.mark + addeddegree;
            context.Degrees.Update(s);
            context.SaveChanges();
            stname.Text = stdegree.Text = degreeadded.Text = "";
            AllStudentInClass = context.Degrees.Include(d => d.Student).Where(d => d.SubId == teacher.SubjectId && d.Student.classId == (int)comboBox1.SelectedValue).Select(s => new DegreeViewModel
            {
                DegreeId = s.DegreeId,
                SubId = s.SubId,
                studentname = s.Student.FirstName + s.Student.LastName,
                StudentId = s.StudentId,
                mark = s.mark
            }).ToList();
            dgv_degrees.DataSource = AllStudentInClass;
            dgv_degrees.Columns["StudentId"].Visible = false;
            dgv_degrees.Columns["SubId"].Visible = false;
            dgv_degrees.Columns["DegreeId"].Visible = false;

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

        private void button3_Click(object sender, EventArgs e)
        {
            form.Show();

            this.Close();
        }

        private void dgv_degrees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_degrees.CurrentCell != null)
            {
                dgv_degrees.CurrentCell.Selected = true; 
            }
        }
    }
}

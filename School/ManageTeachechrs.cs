using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Engines;
using School.Modules;
using School.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace School
{
    public partial class ManageTeachechrs : Form
    {
        AdminDashBoard dashboard;
        SchoolDbContext context;
        user user;
        Teacher teacher;
        string sql;
        List<teachervm> teacherList;
        List<Subject> subjects;
        SqlConnection con;
        List<LessonDetail> lessonsforteacher;
        List<Class> classes;
        List<string> lessonslist = new List<string> { "Lesson 1", "Lesson 2", "Lesson 3", "Lesson 4", "Lesson 5", "Lesson 6", "Lesson 7", "Lesson 8" };
        bool flag;
        public ManageTeachechrs(AdminDashBoard f)
        {
            dashboard = f;
            context = dashboard.context;
            InitializeComponent();
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            dashboard.Loginf.Show();
            this.Close();
            dashboard.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            dashboard.closeforms();
            this.Close();
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {
            if (errorfname.Visible = true) { errorfname.Visible = false; }
        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            if (errorlname.Visible = true) { errorlname.Visible = false; }
        }

        private void ManageTeachechrs_LoadAsync(object sender, EventArgs e)
        {
            //teacherList = context.Teachers.Include(t => t.Subject).Select(t => new teachervm { 
            //   TeacherID = t.TeacherID,
            //   FirstName = t.FirstName,
            //   LastName = t.LastName,
            //   BirthDate = t.BirthDate,
            //   Gender = t.Gender,
            //   Phone = t.Phone,
            //   Email = t.Email,
            //   HireDate = t.HireDate,
            //   SubjectID = t.SubjectId,
            //   SubjectName = t.Subject.SubjectName }).ToList();
            btnadd.Visible = true;
            btnupdate.Visible = false;
            btndelete.Visible = false;

            con = new SqlConnection("Server=DESKTOP-BE6MD1V;Database=SchoolDb;Trusted_Connection=True;Trust Server Certificate=True");
            sql = "SELECT t.TeacherID, t.FirstName, t.LastName, t.BirthDate, t.Gender, t.Phone, t.Email, t.HireDate, t.SubjectId, s.SubjectName FROM Teachers t LEFT JOIN Subjects s ON t.SubjectId = s.SubjectID";
            string sql02 = "select *from Subjects";
            subjects = con.Query<Subject>(sql02).ToList();
            teacherList = con.Query<teachervm>(sql).ToList();



            dgv_teachers.DataSource = teacherList;
            dgv_teachers.Columns["SubjectId"].Visible = false;
            dgv_teachers.Columns["TeacherID"].Visible = false;
            comboBox1.DataSource = subjects;
            comboBox1.DisplayMember = "SubjectName";
            comboBox1.ValueMember = "SubjectID";
            classes = context.Classes.ToList();
            comboboxclasses.DataSource = classes;
            comboboxclasses.ValueMember = "ClassID";
            comboboxclasses.DisplayMember = "ClassName";

            comboboxlessons.DataSource = lessonslist;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchedvalue = searchtextbox.Text.ToLower();
            if (searchtextbox.Text != "")
            {
                var searchedteachers = teacherList.Where(t => t.FirstName.ToLower().Contains(searchtextbox.Text)).ToList();
                if (searchedteachers != null)
                {
                    dgv_teachers.DataSource = searchedteachers;
                    dgv_teachers.Columns["SubjectId"].Visible = false;
                    dgv_teachers.Columns["TeacherID"].Visible = false;
                    searchtextbox.Text = "";
                }
            }
            else
            {
                dgv_teachers.DataSource = teacherList;
                dgv_teachers.Columns["SubjectId"].Visible = false;
                dgv_teachers.Columns["TeacherID"].Visible = false;
            }
        }


        static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        static bool IsValidPhoneNumber(string phoneNumber)
        {

            string pattern = @"^01\d{9}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        private bool Validate()
        {
            bool flag = true;
            if (txt_fname.Text.Length < 3) { flag &= false; errorfname.Visible = true; }
            if (txt_lastname.Text.Length < 3) { flag &= false; errorlname.Visible = true; }
            if (!IsValidPhoneNumber(txt_phone.Text)) { flag &= false; errorphone.Visible = true; }
            if (!IsValidEmail(txt_mail.Text)) { flag &= false; errormail.Visible = true; }
            if (radioButton1.Checked == false && radioButton2.Checked == false) { flag &= false; errorgender.Visible = true; }
            if (comboBox1.SelectedIndex == -1) { flag &= false; errorsubject.Visible = true; }


            return flag;
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            errormail.Visible = false;
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            errorphone.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            errorgender.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            errorgender.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorsubject.Visible = false;
        }
        int id;
        private void dgv_teachers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            flag = true;
            flag = Validate();
            if (flag)
            {
                string gender;
                if (radioButton2.Checked) { gender = "Male"; } else { gender = "Female"; }
                teacher = new Teacher()
                {
                    FirstName = txt_fname.Text,
                    LastName = txt_lastname.Text,
                    BirthDate = datepickerbirthdate.Value,
                    Gender = gender,
                    Phone = txt_phone.Text,
                    Email = txt_mail.Text,
                    HireDate = datepickerhiredate.Value,
                    SubjectId = (int)comboBox1.SelectedValue
                };
                try
                {
                    context.Add(teacher);
                    context.SaveChanges();
                    dgv_teachers.DataSource = teacherList;
                    dgv_teachers.Columns["SubjectId"].Visible = false;
                    dgv_teachers.Columns["TeacherID"].Visible = false;
                    txt_fname.Text = txt_lastname.Text = txt_phone.Text = txt_mail.Text = "";
                    datepickerbirthdate.Value = datepickerbirthdate.MaxDate;
                    datepickerhiredate.Value = datepickerhiredate.MaxDate;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cann't add this teacher ");
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            flag = true;


            if (teacher != null)
            {
                if (txt_fname.Text != teacher.FirstName) { flag &= false; errorfname.Visible = true; }
                if (txt_lastname.Text != teacher.LastName) { flag &= false; errorlname.Visible = true; }
                if (txt_mail.Text != teacher.Email) { flag &= false; errormail.Visible = true; }
                if (txt_phone.Text != teacher.Phone) { flag &= false; errorphone.Visible = true; }
                if (teacher.Gender == "Male" && radioButton1.Checked == true) { flag &= false; errorgender.Visible = true; }
                if (teacher.Gender == "Female" && radioButton2.Checked == true) { flag &= false; errorgender.Visible = true; }
                if (datepickerbirthdate.Value != teacher.BirthDate) { flag &= false; }
                if (datepickerhiredate.Value != teacher.HireDate) { flag &= false; }
                if ((int)comboBox1.SelectedValue != teacher.SubjectId) { flag &= false; }



                if (flag)
                {
                    if (user != null)
                    {

                        DialogResult result = MessageBox.Show("Do you want to continue this action will delete this teacher and it's user ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            context.users.Remove(user);
                        }
                    }
                    DialogResult result02 = MessageBox.Show("Do you want to continue this action will update all classes under manage this teacher to have no manager and delete this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result02 == DialogResult.Yes)
                    {
                        if (teacher.Classes != null)
                        {
                            foreach (var classObj in teacher.Classes)
                            {
                                classObj.ManagerId = null;
                                classObj.Manager = null;
                            }
                            context.SaveChanges();


                        }
                        context.Teachers.Remove(teacher);
                        context.SaveChanges();

                        btnadd.Visible = true;
                        btnupdate.Visible = false;
                        btndelete.Visible = false;
                        teacherList = con.Query<teachervm>(sql).ToList();
                        dgv_teachers.DataSource = teacherList;
                        dgv_teachers.Columns["SubjectId"].Visible = false;
                        dgv_teachers.Columns["TeacherID"].Visible = false;
                        txt_fname.Text = txt_lastname.Text = txt_phone.Text = txt_mail.Text = "";
                        datepickerbirthdate.Value = datepickerbirthdate.MaxDate;
                        datepickerhiredate.Value = datepickerhiredate.MaxDate;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                    }


                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            flag = true;
            flag = Validate();
            teacher = context.Teachers.Include(t => t.Subject).FirstOrDefault(t => t.TeacherID == id);
            if (teacher != null)
            {
                teacher.FirstName = txt_fname.Text;
                teacher.LastName = txt_lastname.Text;
                teacher.Email = txt_mail.Text;
                teacher.Phone = txt_phone.Text;
                if (radioButton2.Checked)
                {
                    teacher.Gender = "Male";

                }
                else
                {
                    teacher.Gender = "Female";
                }
                teacher.BirthDate = datepickerbirthdate.Value;
                teacher.HireDate = datepickerhiredate.Value;
                teacher.Subject.SubjectID = (int)comboBox1.SelectedValue;

            }
            if (user != null)
            {
                user.FirstName = txt_fname.Text;
                user.LastName = txt_lastname.Text;
                user.Email = txt_mail.Text;
                user.Phone = txt_phone.Text;
                if (radioButton2.Checked)
                {
                    user.Gender = "Male";

                }
                else
                {
                    user.Gender = "Female";
                }
                context.Update(user);
            }
            context.Update(teacher);
            context.SaveChanges();
            btnadd.Visible = true;
            btnupdate.Visible = false;
            btndelete.Visible = false;
            teacherList = con.Query<teachervm>(sql).ToList();
            dgv_teachers.DataSource = teacherList;
            dgv_teachers.Columns["SubjectId"].Visible = false;
            dgv_teachers.Columns["TeacherID"].Visible = false;
            txt_fname.Text = txt_lastname.Text = txt_phone.Text = txt_mail.Text = "";
            datepickerbirthdate.Value = datepickerbirthdate.MaxDate;
            datepickerhiredate.Value = datepickerhiredate.MaxDate;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }



        private void dgv_teachers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {




            int rowIndex = e.RowIndex;
            id = Convert.ToInt32(dgv_teachers.Rows[rowIndex].Cells[0].Value);
            teacher = context.Teachers.Include(t => t.Subject).FirstOrDefault(t => t.TeacherID == id);
            user = context.users.FirstOrDefault(u => u.Email == teacher.Email);
            if (teacher != null)
            {
                txt_fname.Text = teacher.FirstName;
                txt_lastname.Text = teacher.LastName;
                txt_mail.Text = teacher.Email;
                txt_phone.Text = teacher.Phone;
                if (teacher.Gender == "Male")
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;

                }
                else
                {
                    radioButton2.Checked = false;

                    radioButton1.Checked = true;
                }
                datepickerbirthdate.Value = teacher.BirthDate;
                datepickerhiredate.Value = teacher.HireDate;
                comboBox1.SelectedValue = teacher.Subject.SubjectID;

            }
            lessonsforteacher = context.EnrolllmentTeacherClassSubject.Where(t => t.TeacherId == teacher.TeacherID).Include(e => e.classs).Select(t => new LessonDetail { Date = t.date, ClassName = t.classs.ClassName, Lesson = t.Lesson, classid = t.classs.ClassID, subjectid = t.SubjectId }).ToList();
            dgv_scheduleteacher.DataSource = lessonsforteacher;
            dgv_scheduleteacher.Columns["classid"].Visible = false;
            dgv_scheduleteacher.Columns["subjectid"].Visible = false;
            btnadd.Visible = false;
            btnupdate.Visible = true;
            btndelete.Visible = true;


        }

        private void btnaddseesion_Click(object sender, EventArgs e)
        {
            TeacherClassSubject addedlessonforteacher = new TeacherClassSubject();
            addedlessonforteacher.date = datapickerlessondate.Value;
            addedlessonforteacher.Lesson = (string)comboboxlessons.SelectedValue;
            addedlessonforteacher.TeacherId = teacher.TeacherID;
            addedlessonforteacher.classId = (int)comboboxclasses.SelectedValue;
            addedlessonforteacher.SubjectId = (int)teacher.SubjectId;
            try
            {
                context.EnrolllmentTeacherClassSubject.Add(addedlessonforteacher);
                context.SaveChanges();
                lessonsforteacher = context.EnrolllmentTeacherClassSubject.Where(t => t.TeacherId == teacher.TeacherID).Include(e => e.classs).Select(t => new LessonDetail { Date = t.date, ClassName = t.classs.ClassName, Lesson = t.Lesson, classid = t.classs.ClassID, subjectid = t.SubjectId }).ToList();
                dgv_scheduleteacher.DataSource = lessonsforteacher;
                dgv_scheduleteacher.Columns["classid"].Visible = false;
                dgv_scheduleteacher.Columns["subjectid"].Visible = false;
                comboboxlessons.SelectedIndex = -1;
                datapickerlessondate.Value = DateTime.Now;
                comboboxclasses.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("cannot add this lesson ");
            }
        }
        TeacherClassSubject deletedlesson;
        private void dgv_scheduleteacher_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex02 = e.RowIndex;
            DateTime Selecteddate = Convert.ToDateTime(dgv_scheduleteacher.Rows[rowIndex02].Cells["date"].Value);
            string SelectedLesson = Convert.ToString(dgv_scheduleteacher.Rows[rowIndex02].Cells["Lesson"].Value);

            deletedlesson = context.EnrolllmentTeacherClassSubject.FirstOrDefault(en => en.date == Selecteddate && en.Lesson == SelectedLesson);

        }

        private void btndeletelesson_Click(object sender, EventArgs e)
        {
            if (deletedlesson != null)
            {
                try
                {
                    context.EnrolllmentTeacherClassSubject.Remove(deletedlesson);
                    context.SaveChanges();
                    lessonsforteacher = context.EnrolllmentTeacherClassSubject.Where(t => t.TeacherId == teacher.TeacherID).Include(e => e.classs).Select(t => new LessonDetail { Date = t.date, ClassName = t.classs.ClassName, Lesson = t.Lesson, classid = t.classs.ClassID, subjectid = t.SubjectId }).ToList();
                    dgv_scheduleteacher.DataSource = lessonsforteacher;
                    dgv_scheduleteacher.Columns["classid"].Visible = false;
                    dgv_scheduleteacher.Columns["subjectid"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("cann't deleted");

                }
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            btnadd.Visible = true;
            btnupdate.Visible = false;
            btndelete.Visible = false;
            teacherList = con.Query<teachervm>(sql).ToList();
            dgv_teachers.DataSource = teacherList;
            dgv_teachers.Columns["SubjectId"].Visible = false;
            dgv_teachers.Columns["TeacherID"].Visible = false;
            txt_fname.Text = txt_lastname.Text = txt_phone.Text = txt_mail.Text = "";
            datepickerbirthdate.Value = datepickerbirthdate.MaxDate;
            datepickerhiredate.Value = datepickerhiredate.MaxDate;
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            dgv_scheduleteacher.DataSource = new List<TeacherClassSubject> { };
        }
    }
}

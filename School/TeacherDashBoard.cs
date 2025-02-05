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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class TeacherDashBoard : Form
    {
      public  LoginForm loginForm;
       public SchoolDbContext context;
        bool flag = true;
        public Teacher teacher;
        //user _user;
      public  List<LessonDetail> lessonsforteacher;
        public TeacherDashBoard(LoginForm f)
        {
            loginForm = f;
            context = new SchoolDbContext();
            teacher = context.Teachers.Where(t => t.Email == loginForm.u.Email).FirstOrDefault();
            InitializeComponent();



        }


        public void closeforms()
        {
            loginForm.closeForms();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            closeforms();
           
        }
        #region Toggle Controls
        private void ToggleItems()
        {

            lblOldPassword.Visible = !lblOldPassword.Visible;
            lblNewPassword.Visible = !lblNewPassword.Visible;
            lblConfirmPassword.Visible = !lblConfirmPassword.Visible;
            txtOldpass.Visible = !txtOldpass.Visible;
            txtNewpass.Visible = !txtNewpass.Visible;
            txtConfirmpass.Visible = !txtConfirmpass.Visible;
            button2.Visible = !button2.Visible;
            btnsave.Visible = !btnsave.Visible;
            txt_mail.ReadOnly = !txt_mail.ReadOnly;
            txt_phone.ReadOnly = !txt_phone.ReadOnly;
        }
        #endregion

        #region Show Error Labels
        public void ShowErrorLabels()
        {
            if (IsValidEmail(txt_mail.Text) == false)
            {
                lblEmailError.Visible = true;
                flag = false;


            }
            if (IsValidPhoneNumber(txt_phone.Text) == false)
            {
                lblPhoneError.Visible = true;
                flag = false;


            }

            if (txtOldpass.Text != loginForm.u.Password)
            {
                label5.Visible = true;
                flag = false;


            }
            if (txtNewpass.Text.Length < 3)
            {
                lblPasswordError.Visible = true;
                flag = false;

            }
            else if (txtConfirmpass.Text != txtNewpass.Text)
            {
                lblConfirmPasswordError.Visible = true;
                flag = false;

            }
        }
        #endregion

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
        private void button2_Click(object sender, EventArgs e)
        {

            ToggleItems();
            txt_phone.Text = loginForm.u.Phone;
            txt_mail.Text = loginForm.u.Email;


        }

        private void TeacherDashBoard_Load(object sender, EventArgs e)
        {
            welcomee.Text = $"Welcome {loginForm.u.FirstName} {loginForm.u.LastName} ";
            txt_mail.PlaceholderText = loginForm.u.Email;
            txt_phone.PlaceholderText = loginForm.u.Phone;

            lessonsforteacher = context.EnrolllmentTeacherClassSubject.Where(t => t.TeacherId == teacher.TeacherID).Include(e => e.classs).Select(t => new LessonDetail { Date = t.date, ClassName = t.classs.ClassName, Lesson = t.Lesson,classid=t.classs.ClassID,subjectid=t.SubjectId }).ToList();
            dgv_schedule.DataSource = lessonsforteacher;
            dgv_schedule.Columns["classid"].Visible = false;
            dgv_schedule.Columns["subjectid"].Visible = false;


        }

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            DateTime startdate = datepickerfrom.Value;
            DateTime enddate = datepickerto.Value;
            var SpecificLessons = lessonsforteacher.Where(l => l.Date >= startdate && l.Date <= enddate).ToList();

            dgv_schedule.DataSource = SpecificLessons;

            dgv_schedule.Columns["classid"].Visible = false;
            dgv_schedule.Columns["subjectid"].Visible = false;

        }
        //save update
        private void btnsave_Click(object sender, EventArgs e)
        {

            flag = true;
            txt_phone.PlaceholderText = loginForm.u.Phone;
            txt_mail.PlaceholderText = loginForm.u.Email;
            ShowErrorLabels();


            if (flag)
            {
                try
                {

                    loginForm.u.Email = teacher.Email = txt_mail.Text;
                    loginForm.u.Phone = teacher.Phone = txt_phone.Text;
                    loginForm.u.Password = txtNewpass.Text;

                    context.users.Update(loginForm.u);
                    context.Teachers.Update(teacher);
                    context.SaveChanges();
                    welcomee.Text = $"Welcome {loginForm.u.FirstName} {loginForm.u.LastName} ";
                    txt_mail.PlaceholderText = loginForm.u.Email;
                    txt_phone.PlaceholderText = loginForm.u.Phone;
                    txt_mail.Text = txt_phone.Text = txtOldpass.Text = txtNewpass.Text = txtConfirmpass.Text = "";
                    ToggleItems();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot update with this data ");
                }

            }
        }
        // if user eneter old pass true auto complete another two fields of passwords(new , confirm new)
        private void txtOldpass_TextChanged(object sender, EventArgs e)
        {
            if (label5.Visible) { label5.Visible = false; }
            if (txtOldpass.Text == loginForm.u.Password)
            {
                txtNewpass.Text = txtConfirmpass.Text = txtOldpass.Text;
            }

        }

        #region hide error label 
        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            if (lblEmailError.Visible) { lblEmailError.Visible = false; }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (lblPhoneError.Visible) { lblPhoneError.Visible = false; }

        }

        private void txtNewpass_TextChanged(object sender, EventArgs e)
        {
            if (lblPasswordError.Visible) { lblPasswordError.Visible = false; }
        }

        private void txtConfirmpass_TextChanged(object sender, EventArgs e)
        {
            if (lblConfirmPasswordError.Visible) { lblConfirmPasswordError.Visible = false; }

        }
        #endregion

        private void btnAllLessons_Click(object sender, EventArgs e)
        {
            dgv_schedule.DataSource = lessonsforteacher;
            dgv_schedule.Columns["classid"].Visible = false;
            dgv_schedule.Columns["subjectid"].Visible = false;
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void btn_ManageDegrees_Click(object sender, EventArgs e)
        {
            TeacherManageDegree f = new TeacherManageDegree(this);
            f.Show();
            this.Hide();
        }
    }
}

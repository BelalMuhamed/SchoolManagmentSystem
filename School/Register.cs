using Dapper;
using Microsoft.Data.SqlClient;
using School.Modules;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School
{
    public partial class Register : Form
    {
        LoginForm loginForm;
        private Teacher _user;
        private user Addeduser;

        private SchoolDbContext _context;
        private bool flag;
        public Register(LoginForm f)
        {
            _context = new SchoolDbContext();

            loginForm = f;
            InitializeComponent();


        }
        public void closeforms()
        {
            loginForm.closeForms();
            this.Close();
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            closeforms();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var email = txt_email.Text;

            var con = new SqlConnection("Server=DESKTOP-BE6MD1V;Database=SchoolDb;Trusted_Connection=True;Trust Server Certificate=True");
            _user = con.QuerySingleOrDefault<Teacher>("select * from Teachers where Email = @Email ", new { Email = email });
            if (_user != null)
            {

                flag = ValidateForm(_user);
                if (flag)
                {
                    string insertQuery = @"
                        INSERT INTO Users (FirstName, LastName, Email, Phone, Password, Gender, Role)
                        VALUES (@FirstName, @LastName, @Email, @Phone, @Password, @Gender, @Role)";

                    int rowsAffected = con.Execute(insertQuery, new
                    {
                        FirstName = txt_fname.Text,
                        LastName = txt_lname.Text,
                        Email = txt_email.Text,
                        Phone = txt_phone.Text,
                        Password = txt_pass.Text,

                        Gender = _user.Gender,
                        Role = "teacher"
                    });

                    if (rowsAffected > 0)
                    {

                        loginForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert user.");
                    }
                }


            }
            else
            {

                ValidateForm(new Teacher());

            }

        }

        private bool validateTextData(string text, Control ctr, Label errorLabel)
        {
            if (ctr is System.Windows.Forms.TextBox)
            {
                if (ctr.Text != text || ctr.Text == "")
                {

                    errorLabel.Visible = true;

                }
            }
            return (ctr.Text == text);
        }
        private bool ValidateForm(Teacher _user)
        {
            flag = validateTextData(_user.FirstName, txt_fname, lblFirstNameError);
            flag &= validateTextData(_user.LastName, txt_lname, lblLastNameError);
            flag &= validateTextData(_user.Email, txt_email, lblEmailError);
            flag &= validateTextData(_user.Phone, txt_phone, lblPhoneError);
            if (txt_pass.Text == "") { lblPasswordError.Visible = true; }
            flag &= (txt_pass.Text != null);
            flag &= validateTextData(txt_pass.Text, txtconfirmpass, lblConfirmPasswordError);
            if (rb_male.Checked)
            {
                flag &= ("Male" == _user.Gender);
                if ("Male" != _user.Gender) { errorgender.Visible = true; }
            }
            else if (rb_female.Checked)
            {
                flag &= ("Female" == _user.Gender);
                if ("Female" != _user.Gender) { errorgender.Visible = true; }

            }
            else if (!rb_male.Checked && !rb_female.Checked)
            {
                errorgender.Visible = true;
            }
            return flag;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (errorgender.Visible)
                errorgender.Visible = false;
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {
            if (lblFirstNameError.Visible)
                lblFirstNameError.Visible = false;
        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {

            if (lblLastNameError.Visible)
                lblLastNameError.Visible = false;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

            if (lblEmailError.Visible)
                lblEmailError.Visible = false;
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

            if (lblPhoneError.Visible)
                lblPhoneError.Visible = false;
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

            if (lblPasswordError.Visible)
                lblPasswordError.Visible = false;
        }

        private void txtconfirmpass_TextChanged(object sender, EventArgs e)
        {
            if (lblConfirmPasswordError.Visible)
                lblConfirmPasswordError.Visible = false;
        }

        private void rb_male_CheckedChanged(object sender, EventArgs e)
        {
            if (errorgender.Visible)
                errorgender.Visible = false;
        }

        private void rb_female_CheckedChanged(object sender, EventArgs e)
        {
            if (errorgender.Visible)
                errorgender.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}

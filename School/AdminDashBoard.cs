using School.Modules;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace School
{
    public partial class AdminDashBoard : Form
    {
        public LoginForm Loginf;
        public user user;
        public SchoolDbContext context;
        bool flag = true;
        public AdminDashBoard(LoginForm f)
        {
            Loginf = f;
            user = Loginf.u;
            context = new SchoolDbContext();
            InitializeComponent();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            welcomee.Text = $"Welcome {user.FirstName} {user.LastName} ";


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

            if (txtOldpass.Text != user.Password)
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

        #region valid somedata
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
        #endregion

        #region editbtn
        private void button2_Click_1(object sender, EventArgs e)
        {
            ToggleItems();
            txt_phone.Text = user.Phone;
            txt_mail.Text = user.Email;
        }
        #endregion

        #region updatedate ofuser
        private void btnsave_Click_1(object sender, EventArgs e)
        {
            flag = true;
            txt_phone.PlaceholderText = user.Phone;
            txt_mail.PlaceholderText = user.Email;
            ShowErrorLabels();


            if (flag)
            {
                try
                {

                    user.Email = txt_mail.Text;
                    user.Phone = txt_phone.Text;
                    user.Password = txtNewpass.Text;

                    context.users.Update(user);

                    context.SaveChanges();
                    welcomee.Text = $"Welcome {user.FirstName} {user.LastName} ";
                    txt_mail.PlaceholderText = user.Email;
                    txt_phone.PlaceholderText = user.Phone;
                    txt_mail.Text = txt_phone.Text = txtOldpass.Text = txtNewpass.Text = txtConfirmpass.Text = "";
                    ToggleItems();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot update with this data ");
                }

            }
        }
        #endregion

        #region if user eneter old pass true auto complete another two fields of passwords(new , confirm new)
        private void txtOldpass_TextChanged_1(object sender, EventArgs e)
        {
            if (label5.Visible) { label5.Visible = false; }
            if (txtOldpass.Text == user.Password)
            {
                txtNewpass.Text = txtConfirmpass.Text = txtOldpass.Text;
            }
        }
        #endregion

        #region hide error label 
        private void txt_mail_TextChanged_1(object sender, EventArgs e)
        {
            if (lblEmailError.Visible) { lblEmailError.Visible = false; }
        }

        private void txt_phone_TextChanged_1(object sender, EventArgs e)
        {
            if (lblPhoneError.Visible) { lblPhoneError.Visible = false; }
        }

        private void txtNewpass_TextChanged_1(object sender, EventArgs e)
        {
            if (lblPasswordError.Visible) { lblPasswordError.Visible = false; }
        }

        private void txtConfirmpass_TextChanged_1(object sender, EventArgs e)
        {
            if (lblConfirmPasswordError.Visible) { lblConfirmPasswordError.Visible = false; }
        }
        #endregion

        public void closeforms()
        {
            Loginf.closeForms();
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            closeforms();
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            Loginf.Show();
            this.Close();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            ManageUsers form = new ManageUsers(this);
            form.Show();

            this.Hide();

        }

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            ManageTeachechrs form = new ManageTeachechrs(this);
            form.Show();

            this.Hide();
        }
    }
}

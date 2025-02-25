﻿using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using School.Modules;
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
    public partial class LoginForm : Form
    {
        LoadingForm _LoadingForm;
       public user u;
        public LoginForm(LoadingForm f) : base()
        {
            _LoadingForm = f;


            InitializeComponent();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            var email = txt_mail.Text;
            var password = txt_pass.Text;
            var con = new SqlConnection("Server=DESKTOP-BE6MD1V;Database=SchoolDb;Trusted_Connection=True;Trust Server Certificate=True");
             u = con.QueryFirstOrDefault<user>("select * from users where Email = @Email and Password=@password", new { Email = email, password = password });

            if (u != null)
            {
                if (u.Role == "admin")
                {
                    txt_mail.Text = "";
                    txt_pass.Text = "";
                    AdminDashBoard fadmin = new AdminDashBoard(this);
                    fadmin.Show();
                    this.Hide();
                }
                else if(u.Role == "teacher")
                {
                    txt_mail.Text = "";
                    txt_pass.Text = "";
                    TeacherDashBoard f = new TeacherDashBoard(this);
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                errorLbl.Visible = true;
            }

        }

        public void closeForms()
        {
            _LoadingForm.Close();
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            closeForms();
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            if (errorLbl.Visible) { errorLbl.Visible = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            register.Location = this.Location;
            register.Size= this.Size;
            this.Hide();

        }
    }
}

using Dapper;
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
        public LoginForm()
        {
            InitializeComponent();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            var email = txt_mail.Text;
            var password = txt_pass.Text;
            var con = new SqlConnection("Server=DESKTOP-BE6MD1V;Database=SchoolDb;Trusted_Connection=True;Trust Server Certificate=True");
            user u = con.QueryFirstOrDefault<user>("select * from users where Email = @Email and Password=@password", new { Email = email, password = password });
            
            if (u != null) 
            {
                if (u.Role == "admin")
                {

                }
                else
                {

                }
            }
            else
            {
                errorLbl.Visible = true;
            }

        }



        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            if (errorLbl.Visible) { errorLbl.Visible = false; }
        }
    }
}

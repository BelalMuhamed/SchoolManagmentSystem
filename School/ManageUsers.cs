using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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

namespace School
{
    public partial class ManageUsers : Form
    {
        AdminDashBoard dashboard;
        SchoolDbContext context;
        user user;
        Teacher teacher;
        string useroldstate;
        bool flag = true;
        public ManageUsers(AdminDashBoard f)
        {
            dashboard = f;
            context = dashboard.context;

            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            dashboard.closeforms();
            this.Close();
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

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = context.users.ToList();
            dgv_users.Columns[0].Visible = false;
            dgv_users.Columns["ConfirmPassword"].Visible = false;


        }
        private void togglebuttons()
        {
            btn_add.Visible = !btn_add.Visible;
            btn_update.Visible = !btn_update.Visible;
            btn_delete.Visible = !btn_delete.Visible;
        }
        int id = 0;
        private void dgv_users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            int rowIndex = e.RowIndex;
            id = Convert.ToInt32(dgv_users.Rows[rowIndex].Cells[0].Value);

            user = context.users.Where(u => u.UserId == id).FirstOrDefault();
            teacher = context.Teachers.FirstOrDefault(t => t.Email == user.Email);
            if (user != null)
            {
                useroldstate = user.Role;
                txt_phone.Text = (dgv_users.Rows[rowIndex].Cells["Phone"].Value).ToString();
                txt_mail.Text = (dgv_users.Rows[rowIndex].Cells["Email"].Value).ToString();
                txtpassword.Text = (dgv_users.Rows[rowIndex].Cells["Password"].Value).ToString();
                txt_fname.Text = (dgv_users.Rows[rowIndex].Cells["FirstName"].Value).ToString();
                txt_lastname.Text = (dgv_users.Rows[rowIndex].Cells["LastName"].Value).ToString();
                if (user.Gender == "Male")
                {
                    rmale.Checked = true;
                }
                else { rfemale.Checked = true; }
                if (user.Role == "admin")
                {
                    radmin.Checked = true;
                }
                else
                {
                    rteacher.Checked = true;
                    
                    
                }
            }


        }
        private void declareitems()
        {
            txt_phone.Text = txt_mail.Text = txtpassword.Text = txt_fname.Text = txt_lastname.Text = "";
            rmale.Checked = rfemale.Checked = radmin.Checked = rteacher.Checked = false;
        }
        private void validatedata()
        {
            if (txt_mail.Text == "") { flag = false; errormail.Visible = true; }
            if (txt_phone.Text == "") { flag = false; errorphone.Visible = true; }
            if (txt_fname.Text == "") { flag = false; errorfname.Visible = true; }
            if (txt_lastname.Text == "") { flag = false; errorlname.Visible = true; }
            if (txtpassword.Text == "") { flag = false; errorpass.Visible = true; }
            if (rmale.Checked == false && rfemale.Checked == false) { flag = false; errorgender.Visible = true; }
            if (radmin.Checked == false && rteacher.Checked == false) { flag = false; errorgender.Visible = true; }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            flag = true;
            validatedata();
            if (flag)
            {
                try
                {

                    if(useroldstate=="teacher"&& radmin.Checked == true)
                    {
                        Teacher t= context.Teachers.Include(t=>t.Classes).FirstOrDefault(t=>t.TeacherID==teacher.TeacherID);
                        DialogResult result = MessageBox.Show("Do you want to continue this action will update all classes under manage this teacher to have no manager and delete this teacher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if(t.Classes !=null)
                            {
                                foreach (var classObj in t.Classes)
                                {
                                    classObj.ManagerId = null;
                                    classObj.Manager = null;
                                }

                                
                                context.SaveChanges();
                            }
                            context.Teachers.Remove(t);
                            
                        }
                        if (result == DialogResult.No)
                        {
                            DialogResult result02 = MessageBox.Show("Are you want to update this theacher to admin with his responsiblities ??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result02 == DialogResult.Yes)
                            {
                                teacher.FirstName = txt_fname.Text;
                                teacher.LastName = txt_lastname.Text;

                                teacher.Email = txt_mail.Text;
                                teacher.Phone = txt_phone.Text;
                                if (rmale.Checked == true) teacher.Gender = "Male";
                                else { teacher.Gender = "Female"; }
                                context.Teachers.Update(teacher);
                                
                            }
                        }  

                    }
                    
                        user.FirstName = txt_fname.Text;
                        user.LastName = txt_lastname.Text;
                        user.Password = txtpassword.Text;
                        user.Email = txt_mail.Text;
                        user.Phone = txt_phone.Text;
                        if (radmin.Checked == true)
                        {

                            user.Role = "admin";
                        }
                        else
                        {
                            user.Role = "teacher";
                        if(teacher != null)
                        {
                            teacher.FirstName = txt_fname.Text;
                            teacher.LastName = txt_lastname.Text;

                            teacher.Email = txt_mail.Text;
                            teacher.Phone = txt_phone.Text;
                            if (rmale.Checked == true) teacher.Gender = "Male";
                            else { teacher.Gender = "Female"; }
                            context.Teachers.Update(teacher);
                        }
                            else
                        {
                            Teacher t = new Teacher();
                            t.FirstName = txt_fname.Text;
                            t.LastName = txt_lastname.Text;

                            t.Email = txt_mail.Text;
                            t.Phone = txt_phone.Text;
                            if (rmale.Checked == true) t.Gender = "Male";
                            else { t.Gender = "Female"; }
                            context.Teachers.Add(t);
                        }
                        }
                        if (rmale.Checked == true) user.Gender = "Male";
                        else { user.Gender = "Female"; }
                        context.users.Update(user);
                        context.SaveChanges();
                        dgv_users.DataSource = context.users.ToList();
                        dgv_users.Columns[0].Visible = false;
                        dgv_users.Columns["ConfirmPassword"].Visible = false;

                        declareitems();
                        togglebuttons();
                    }
                   
                
                catch (Exception ex)
                {
                    MessageBox.Show("cann't update this user");

                }


            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           
            flag = true;
            if (teacher != null)
            {
                flag &= (txt_mail.Text == teacher.Email);
                flag &= (txt_fname.Text == teacher.FirstName);
                flag &= (txt_lastname.Text == teacher.LastName);
                if (rmale.Checked) { flag &= (teacher.Gender == "Male"); }
                if (rfemale.Checked) { flag &= (teacher.Gender == "Female"); }
                if (flag)
                {
                    try
                    {
                       
                            context.Teachers.Remove(teacher);

                       

                    }
                    catch 
                    {
                        MessageBox.Show("cann't delete this user ");

                    }

                }

            }
            validatedata();
            if (flag) 
            {
                try
                {
                    
                    context.users.Remove(user);
                    context.SaveChanges();
                    dgv_users.DataSource = context.users.ToList();
                    dgv_users.Columns[0].Visible = false;
                    dgv_users.Columns["ConfirmPassword"].Visible = false;

                    declareitems();
                    togglebuttons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("cann't delete this user ");

                }
            }
            else
            {
                MessageBox.Show("cann't delete this user because you update fields ");

            }

        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            flag = true;
            user user = new user();
            Teacher teacher = new Teacher();
            validatedata();
            if (flag)
            {
                try
                {
                    user.FirstName = txt_fname.Text;
                    user.LastName = txt_lastname.Text;
                    user.Password = txtpassword.Text;
                    user.Email = txt_mail.Text;
                    user.Phone = txt_phone.Text;
                    if (radmin.Checked == true)
                    {

                        user.Role = "admin";
                    }
                    else
                    {
                        user.Role = "teacher";
                        teacher.FirstName = txt_fname.Text;
                        teacher.LastName = txt_lastname.Text;

                        teacher.Email = txt_mail.Text;
                        teacher.Phone = txt_phone.Text;
                        if (rmale.Checked == true) teacher.Gender = "Male";
                        else { teacher.Gender = "Female"; }
                        context.Teachers.Add(teacher);
                    }
                    if (rmale.Checked == true) user.Gender = "Male";
                    else { user.Gender = "Female"; }
                    context.users.Add(user);
                    context.SaveChanges();
                    dgv_users.DataSource = context.users.ToList();
                    dgv_users.Columns[0].Visible = false;
                    dgv_users.Columns["ConfirmPassword"].Visible = false;

                    declareitems();
                    togglebuttons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("cann't add this user");

                }


            }
        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {
            errorfname.Visible = false;
        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {
            errorlname.Visible = false;
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            errormail.Visible = false;
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            errorphone.Visible = false;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            errorpass.Visible = false;
        }

        private void rmale_CheckedChanged(object sender, EventArgs e)
        {
            errorgender.Visible = false;
        }

        private void rfemale_CheckedChanged(object sender, EventArgs e)
        {
            errorgender.Visible = false;

        }

        private void radmin_CheckedChanged(object sender, EventArgs e)
        {
            errorrole.Visible = false;
        }

        private void rteacher_CheckedChanged(object sender, EventArgs e)
        {
            errorrole.Visible = false;

        }
    }
}

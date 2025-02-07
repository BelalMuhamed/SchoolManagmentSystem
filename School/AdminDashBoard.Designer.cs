namespace School
{
    partial class AdminDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            btnsignout = new Button();
            welcomee = new Label();
            panel1 = new Panel();
            lblPhoneError = new Label();
            lblEmailError = new Label();
            label5 = new Label();
            lblConfirmPasswordError = new Label();
            lblPasswordError = new Label();
            btnsave = new Button();
            button2 = new Button();
            txtConfirmpass = new TextBox();
            txtNewpass = new TextBox();
            txtOldpass = new TextBox();
            txt_phone = new TextBox();
            txt_mail = new TextBox();
            lblConfirmPassword = new Label();
            label2 = new Label();
            lblNewPassword = new Label();
            label1 = new Label();
            lblOldPassword = new Label();
            panel2 = new Panel();
            btnusers = new Button();
            classes = new Button();
            btnstudent = new Button();
            btn_teachers = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.CornflowerBlue;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(1728, 13);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 34);
            btnClose.TabIndex = 16;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.BottomLeft;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnsignout
            // 
            btnsignout.Anchor = AnchorStyles.None;
            btnsignout.BackColor = Color.CornflowerBlue;
            btnsignout.Cursor = Cursors.Hand;
            btnsignout.FlatStyle = FlatStyle.Flat;
            btnsignout.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignout.ForeColor = Color.DarkRed;
            btnsignout.Location = new Point(1646, 55);
            btnsignout.Margin = new Padding(3, 4, 3, 4);
            btnsignout.Name = "btnsignout";
            btnsignout.Size = new Size(120, 34);
            btnsignout.TabIndex = 32;
            btnsignout.Text = "sign out ";
            btnsignout.UseVisualStyleBackColor = false;
            btnsignout.Click += btnsignout_Click;
            // 
            // welcomee
            // 
            welcomee.Anchor = AnchorStyles.None;
            welcomee.AutoSize = true;
            welcomee.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcomee.Location = new Point(36, 37);
            welcomee.Name = "welcomee";
            welcomee.Size = new Size(0, 50);
            welcomee.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblPhoneError);
            panel1.Controls.Add(lblEmailError);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblConfirmPasswordError);
            panel1.Controls.Add(lblPasswordError);
            panel1.Controls.Add(btnsave);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtConfirmpass);
            panel1.Controls.Add(txtNewpass);
            panel1.Controls.Add(txtOldpass);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_mail);
            panel1.Controls.Add(lblConfirmPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblNewPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblOldPassword);
            panel1.Location = new Point(110, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 408);
            panel1.TabIndex = 35;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(116, 243);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(154, 20);
            lblPhoneError.TabIndex = 61;
            lblPhoneError.Tag = "error";
            lblPhoneError.Text = "invalid phone number";
            lblPhoneError.Visible = false;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(126, 111);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(94, 20);
            lblEmailError.TabIndex = 60;
            lblEmailError.Tag = "error";
            lblEmailError.Text = "invalid email";
            lblEmailError.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(549, 111);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 59;
            label5.Tag = "error";
            label5.Text = "invalid value";
            label5.Visible = false;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.AutoSize = true;
            lblConfirmPasswordError.ForeColor = Color.Red;
            lblConfirmPasswordError.Location = new Point(452, 300);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(278, 20);
            lblConfirmPasswordError.TabIndex = 58;
            lblConfirmPasswordError.Tag = "error";
            lblConfirmPasswordError.Text = "confirm password must be like password";
            lblConfirmPasswordError.Visible = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(549, 206);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(92, 20);
            lblPasswordError.TabIndex = 57;
            lblPasswordError.Tag = "error";
            lblPasswordError.Text = "invalid value";
            lblPasswordError.Visible = false;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackColor = Color.CornflowerBlue;
            btnsave.Cursor = Cursors.Hand;
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.ForeColor = SystemColors.ButtonHighlight;
            btnsave.Location = new Point(202, 337);
            btnsave.Margin = new Padding(3, 4, 3, 4);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 33);
            btnsave.TabIndex = 56;
            btnsave.Text = "Save ";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Visible = false;
            btnsave.Click += btnsave_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.CornflowerBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(77, 337);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 55;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // txtConfirmpass
            // 
            txtConfirmpass.Anchor = AnchorStyles.None;
            txtConfirmpass.BackColor = SystemColors.InactiveCaptionText;
            txtConfirmpass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmpass.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txtConfirmpass.ForeColor = Color.AliceBlue;
            txtConfirmpass.Location = new Point(482, 256);
            txtConfirmpass.Margin = new Padding(3, 4, 3, 4);
            txtConfirmpass.Name = "txtConfirmpass";
            txtConfirmpass.PasswordChar = '*';
            txtConfirmpass.Size = new Size(229, 31);
            txtConfirmpass.TabIndex = 54;
            txtConfirmpass.Visible = false;
            txtConfirmpass.TextChanged += txtConfirmpass_TextChanged_1;
            // 
            // txtNewpass
            // 
            txtNewpass.Anchor = AnchorStyles.None;
            txtNewpass.BackColor = SystemColors.InactiveCaptionText;
            txtNewpass.BorderStyle = BorderStyle.FixedSingle;
            txtNewpass.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txtNewpass.ForeColor = Color.AliceBlue;
            txtNewpass.Location = new Point(482, 161);
            txtNewpass.Margin = new Padding(3, 4, 3, 4);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.PasswordChar = '*';
            txtNewpass.Size = new Size(229, 31);
            txtNewpass.TabIndex = 53;
            txtNewpass.Visible = false;
            txtNewpass.TextChanged += txtNewpass_TextChanged_1;
            // 
            // txtOldpass
            // 
            txtOldpass.Anchor = AnchorStyles.None;
            txtOldpass.BackColor = SystemColors.InactiveCaptionText;
            txtOldpass.BorderStyle = BorderStyle.FixedSingle;
            txtOldpass.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txtOldpass.ForeColor = Color.AliceBlue;
            txtOldpass.Location = new Point(482, 76);
            txtOldpass.Margin = new Padding(3, 4, 3, 4);
            txtOldpass.Name = "txtOldpass";
            txtOldpass.PasswordChar = '*';
            txtOldpass.Size = new Size(229, 31);
            txtOldpass.TabIndex = 51;
            txtOldpass.Visible = false;
            txtOldpass.TextChanged += txtOldpass_TextChanged_1;
            // 
            // txt_phone
            // 
            txt_phone.Anchor = AnchorStyles.None;
            txt_phone.BackColor = SystemColors.InactiveCaptionText;
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_phone.ForeColor = Color.AliceBlue;
            txt_phone.Location = new Point(77, 195);
            txt_phone.Margin = new Padding(3, 4, 3, 4);
            txt_phone.Name = "txt_phone";
            txt_phone.ReadOnly = true;
            txt_phone.Size = new Size(275, 31);
            txt_phone.TabIndex = 52;
            txt_phone.TextChanged += txt_phone_TextChanged_1;
            // 
            // txt_mail
            // 
            txt_mail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_mail.BackColor = SystemColors.InactiveCaptionText;
            txt_mail.BorderStyle = BorderStyle.FixedSingle;
            txt_mail.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_mail.ForeColor = Color.AliceBlue;
            txt_mail.Location = new Point(79, 76);
            txt_mail.Margin = new Padding(3, 4, 3, 4);
            txt_mail.Name = "txt_mail";
            txt_mail.ReadOnly = true;
            txt_mail.Size = new Size(271, 31);
            txt_mail.TabIndex = 50;
            txt_mail.TextChanged += txt_mail_TextChanged_1;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.None;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            lblConfirmPassword.Location = new Point(496, 226);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(215, 26);
            lblConfirmPassword.TabIndex = 49;
            lblConfirmPassword.Text = "Confirm Password";
            lblConfirmPassword.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label2.Location = new Point(148, 35);
            label2.Name = "label2";
            label2.Size = new Size(81, 26);
            label2.TabIndex = 45;
            label2.Text = "Email :";
            // 
            // lblNewPassword
            // 
            lblNewPassword.Anchor = AnchorStyles.None;
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            lblNewPassword.Location = new Point(524, 131);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(171, 26);
            lblNewPassword.TabIndex = 48;
            lblNewPassword.Text = "New Password";
            lblNewPassword.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label1.Location = new Point(135, 147);
            label1.Name = "label1";
            label1.Size = new Size(91, 26);
            label1.TabIndex = 46;
            label1.Text = "Phone :";
            // 
            // lblOldPassword
            // 
            lblOldPassword.Anchor = AnchorStyles.None;
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            lblOldPassword.Location = new Point(524, 35);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(167, 26);
            lblOldPassword.TabIndex = 47;
            lblOldPassword.Text = "old Password";
            lblOldPassword.Visible = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnusers);
            panel2.Controls.Add(classes);
            panel2.Controls.Add(btnstudent);
            panel2.Controls.Add(btn_teachers);
            panel2.Location = new Point(974, 279);
            panel2.Name = "panel2";
            panel2.Size = new Size(818, 408);
            panel2.TabIndex = 36;
            // 
            // btnusers
            // 
            btnusers.Anchor = AnchorStyles.None;
            btnusers.BackColor = Color.CornflowerBlue;
            btnusers.Cursor = Cursors.Hand;
            btnusers.FlatStyle = FlatStyle.Popup;
            btnusers.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnusers.ForeColor = SystemColors.ButtonHighlight;
            btnusers.Location = new Point(430, 226);
            btnusers.Margin = new Padding(3, 4, 3, 4);
            btnusers.Name = "btnusers";
            btnusers.Size = new Size(251, 138);
            btnusers.TabIndex = 33;
            btnusers.Text = "Users";
            btnusers.UseVisualStyleBackColor = false;
            btnusers.Click += btnusers_Click;
            // 
            // classes
            // 
            classes.Anchor = AnchorStyles.None;
            classes.BackColor = Color.CornflowerBlue;
            classes.Cursor = Cursors.Hand;
            classes.FlatStyle = FlatStyle.Popup;
            classes.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classes.ForeColor = SystemColors.ButtonHighlight;
            classes.Location = new Point(430, 35);
            classes.Margin = new Padding(3, 4, 3, 4);
            classes.Name = "classes";
            classes.Size = new Size(251, 138);
            classes.TabIndex = 32;
            classes.Text = "Classes";
            classes.UseVisualStyleBackColor = false;
            // 
            // btnstudent
            // 
            btnstudent.Anchor = AnchorStyles.None;
            btnstudent.BackColor = Color.CornflowerBlue;
            btnstudent.Cursor = Cursors.Hand;
            btnstudent.FlatStyle = FlatStyle.Popup;
            btnstudent.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnstudent.ForeColor = SystemColors.ButtonHighlight;
            btnstudent.Location = new Point(106, 226);
            btnstudent.Margin = new Padding(3, 4, 3, 4);
            btnstudent.Name = "btnstudent";
            btnstudent.Size = new Size(251, 138);
            btnstudent.TabIndex = 31;
            btnstudent.Text = "Students";
            btnstudent.UseVisualStyleBackColor = false;
            // 
            // btn_teachers
            // 
            btn_teachers.Anchor = AnchorStyles.None;
            btn_teachers.BackColor = Color.CornflowerBlue;
            btn_teachers.Cursor = Cursors.Hand;
            btn_teachers.FlatStyle = FlatStyle.Popup;
            btn_teachers.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_teachers.ForeColor = SystemColors.ButtonHighlight;
            btn_teachers.Location = new Point(106, 35);
            btn_teachers.Margin = new Padding(3, 4, 3, 4);
            btn_teachers.Name = "btn_teachers";
            btn_teachers.Size = new Size(251, 138);
            btn_teachers.TabIndex = 30;
            btn_teachers.Text = "Teachers";
            btn_teachers.UseVisualStyleBackColor = false;
            btn_teachers.Click += btn_teachers_Click;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1791, 885);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(welcomee);
            Controls.Add(btnsignout);
            Controls.Add(btnClose);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashBoard";
            Load += AdminDashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnsignout;
        private Label welcomee;
        private Panel panel1;
        private Label lblPhoneError;
        private Label lblEmailError;
        private Label label5;
        private Label lblConfirmPasswordError;
        private Label lblPasswordError;
        private Button btnsave;
        private Button button2;
        private TextBox txtConfirmpass;
        private TextBox txtNewpass;
        private TextBox txtOldpass;
        private TextBox txt_phone;
        private TextBox txt_mail;
        private Label lblConfirmPassword;
        private Label label2;
        private Label lblNewPassword;
        private Label label1;
        private Label lblOldPassword;
        private Panel panel2;
        private Button btnusers;
        private Button classes;
        private Button btnstudent;
        private Button btn_teachers;
    }
}
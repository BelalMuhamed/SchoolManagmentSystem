namespace School
{
    partial class TeacherDashBoard
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
            welcome = new Label();
            button1 = new Button();
            welcomee = new Label();
            label2 = new Label();
            label1 = new Label();
            lblOldPassword = new Label();
            lblNewPassword = new Label();
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
            panel2 = new Panel();
            datepickerto = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            btn_ManageDegrees = new Button();
            btn_Schedule = new Button();
            datepickerfrom = new DateTimePicker();
            dgv_schedule = new DataGridView();
            btnAllLessons = new Button();
            btnsignout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_schedule).BeginInit();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.Anchor = AnchorStyles.None;
            welcome.AutoSize = true;
            welcome.Location = new Point(54, 24);
            welcome.Name = "welcome";
            welcome.Size = new Size(0, 20);
            welcome.TabIndex = 16;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1744, 24);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(38, 34);
            button1.TabIndex = 15;
            button1.Text = "X";
            button1.TextAlign = ContentAlignment.BottomLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // welcomee
            // 
            welcomee.Anchor = AnchorStyles.None;
            welcomee.AutoSize = true;
            welcomee.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcomee.Location = new Point(54, 69);
            welcomee.Name = "welcomee";
            welcomee.Size = new Size(0, 50);
            welcomee.TabIndex = 17;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label2.Location = new Point(134, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 26);
            label2.TabIndex = 18;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label1.Location = new Point(103, 154);
            label1.Name = "label1";
            label1.Size = new Size(91, 26);
            label1.TabIndex = 19;
            label1.Text = "Phone :";
            // 
            // lblOldPassword
            // 
            lblOldPassword.Anchor = AnchorStyles.None;
            lblOldPassword.AutoSize = true;
            lblOldPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            lblOldPassword.Location = new Point(514, 38);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(167, 26);
            lblOldPassword.TabIndex = 20;
            lblOldPassword.Text = "old Password";
            lblOldPassword.Visible = false;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Anchor = AnchorStyles.None;
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            lblNewPassword.Location = new Point(510, 138);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(171, 26);
            lblNewPassword.TabIndex = 21;
            lblNewPassword.Text = "New Password";
            lblNewPassword.Visible = false;
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
            panel1.Location = new Point(194, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 377);
            panel1.TabIndex = 22;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(63, 237);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(154, 20);
            lblPhoneError.TabIndex = 44;
            lblPhoneError.Tag = "error";
            lblPhoneError.Text = "invalid phone number";
            lblPhoneError.Visible = false;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(123, 120);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(94, 20);
            lblEmailError.TabIndex = 43;
            lblEmailError.Tag = "error";
            lblEmailError.Text = "invalid email";
            lblEmailError.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(539, 117);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 42;
            label5.Tag = "error";
            label5.Text = "invalid value";
            label5.Visible = false;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.AutoSize = true;
            lblConfirmPasswordError.ForeColor = Color.Red;
            lblConfirmPasswordError.Location = new Point(471, 318);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(278, 20);
            lblConfirmPasswordError.TabIndex = 41;
            lblConfirmPasswordError.Tag = "error";
            lblConfirmPasswordError.Text = "confirm password must be like password";
            lblConfirmPasswordError.Visible = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(539, 207);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(92, 20);
            lblPasswordError.TabIndex = 40;
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
            btnsave.Location = new Point(223, 285);
            btnsave.Margin = new Padding(3, 4, 3, 4);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(94, 33);
            btnsave.TabIndex = 28;
            btnsave.Text = "Save ";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Visible = false;
            btnsave.Click += btnsave_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.CornflowerBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(68, 285);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 27;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtConfirmpass
            // 
            txtConfirmpass.Anchor = AnchorStyles.None;
            txtConfirmpass.BackColor = SystemColors.InactiveCaptionText;
            txtConfirmpass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmpass.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txtConfirmpass.ForeColor = Color.AliceBlue;
            txtConfirmpass.Location = new Point(489, 274);
            txtConfirmpass.Margin = new Padding(3, 4, 3, 4);
            txtConfirmpass.Name = "txtConfirmpass";
            txtConfirmpass.PasswordChar = '*';
            txtConfirmpass.Size = new Size(229, 31);
            txtConfirmpass.TabIndex = 26;
            txtConfirmpass.Visible = false;
            txtConfirmpass.TextChanged += txtConfirmpass_TextChanged;
            // 
            // txtNewpass
            // 
            txtNewpass.Anchor = AnchorStyles.None;
            txtNewpass.BackColor = SystemColors.InactiveCaptionText;
            txtNewpass.BorderStyle = BorderStyle.FixedSingle;
            txtNewpass.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txtNewpass.ForeColor = Color.AliceBlue;
            txtNewpass.Location = new Point(489, 168);
            txtNewpass.Margin = new Padding(3, 4, 3, 4);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.PasswordChar = '*';
            txtNewpass.Size = new Size(229, 31);
            txtNewpass.TabIndex = 25;
            txtNewpass.Visible = false;
            txtNewpass.TextChanged += txtNewpass_TextChanged;
            // 
            // txtOldpass
            // 
            txtOldpass.Anchor = AnchorStyles.None;
            txtOldpass.BackColor = SystemColors.InactiveCaptionText;
            txtOldpass.BorderStyle = BorderStyle.FixedSingle;
            txtOldpass.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txtOldpass.ForeColor = Color.AliceBlue;
            txtOldpass.Location = new Point(489, 80);
            txtOldpass.Margin = new Padding(3, 4, 3, 4);
            txtOldpass.Name = "txtOldpass";
            txtOldpass.PasswordChar = '*';
            txtOldpass.Size = new Size(229, 31);
            txtOldpass.TabIndex = 23;
            txtOldpass.Visible = false;
            txtOldpass.TextChanged += txtOldpass_TextChanged;
            // 
            // txt_phone
            // 
            txt_phone.Anchor = AnchorStyles.None;
            txt_phone.BackColor = SystemColors.InactiveCaptionText;
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_phone.ForeColor = Color.AliceBlue;
            txt_phone.Location = new Point(28, 194);
            txt_phone.Margin = new Padding(3, 4, 3, 4);
            txt_phone.Name = "txt_phone";
            txt_phone.ReadOnly = true;
            txt_phone.Size = new Size(289, 31);
            txt_phone.TabIndex = 24;
            txt_phone.TextChanged += txt_phone_TextChanged;
            // 
            // txt_mail
            // 
            txt_mail.Anchor = AnchorStyles.None;
            txt_mail.BackColor = SystemColors.InactiveCaptionText;
            txt_mail.BorderStyle = BorderStyle.FixedSingle;
            txt_mail.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_mail.ForeColor = Color.AliceBlue;
            txt_mail.Location = new Point(41, 80);
            txt_mail.Margin = new Padding(3, 4, 3, 4);
            txt_mail.Name = "txt_mail";
            txt_mail.ReadOnly = true;
            txt_mail.Size = new Size(276, 31);
            txt_mail.TabIndex = 23;
            txt_mail.TextChanged += txt_mail_TextChanged;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.None;
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            lblConfirmPassword.Location = new Point(489, 235);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(215, 26);
            lblConfirmPassword.TabIndex = 22;
            lblConfirmPassword.Text = "Confirm Password";
            lblConfirmPassword.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(datepickerto);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_ManageDegrees);
            panel2.Controls.Add(btn_Schedule);
            panel2.Controls.Add(datepickerfrom);
            panel2.Location = new Point(1216, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 377);
            panel2.TabIndex = 23;
            // 
            // datepickerto
            // 
            datepickerto.Anchor = AnchorStyles.None;
            datepickerto.CalendarForeColor = SystemColors.ButtonHighlight;
            datepickerto.CalendarMonthBackground = Color.CornflowerBlue;
            datepickerto.CalendarTitleBackColor = Color.CornflowerBlue;
            datepickerto.CalendarTrailingForeColor = SystemColors.ButtonHighlight;
            datepickerto.Location = new Point(190, 251);
            datepickerto.Name = "datepickerto";
            datepickerto.Size = new Size(250, 27);
            datepickerto.TabIndex = 31;
            datepickerto.Value = new DateTime(2025, 2, 4, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label4.Location = new Point(55, 252);
            label4.Name = "label4";
            label4.Size = new Size(51, 26);
            label4.TabIndex = 30;
            label4.Text = "To :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label3.Location = new Point(39, 174);
            label3.Name = "label3";
            label3.Size = new Size(84, 26);
            label3.TabIndex = 29;
            label3.Text = "From : ";
            // 
            // btn_ManageDegrees
            // 
            btn_ManageDegrees.Anchor = AnchorStyles.None;
            btn_ManageDegrees.BackColor = Color.CornflowerBlue;
            btn_ManageDegrees.Cursor = Cursors.Hand;
            btn_ManageDegrees.FlatStyle = FlatStyle.Popup;
            btn_ManageDegrees.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ManageDegrees.ForeColor = SystemColors.ButtonHighlight;
            btn_ManageDegrees.Location = new Point(39, 60);
            btn_ManageDegrees.Margin = new Padding(3, 4, 3, 4);
            btn_ManageDegrees.Name = "btn_ManageDegrees";
            btn_ManageDegrees.Size = new Size(401, 77);
            btn_ManageDegrees.TabIndex = 29;
            btn_ManageDegrees.Text = "Manage Degrees";
            btn_ManageDegrees.UseVisualStyleBackColor = false;
            btn_ManageDegrees.Click += btn_ManageDegrees_Click;
            // 
            // btn_Schedule
            // 
            btn_Schedule.Anchor = AnchorStyles.None;
            btn_Schedule.BackColor = Color.CornflowerBlue;
            btn_Schedule.Cursor = Cursors.Hand;
            btn_Schedule.FlatStyle = FlatStyle.Popup;
            btn_Schedule.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Schedule.ForeColor = SystemColors.ButtonHighlight;
            btn_Schedule.Location = new Point(39, 304);
            btn_Schedule.Margin = new Padding(3, 4, 3, 4);
            btn_Schedule.Name = "btn_Schedule";
            btn_Schedule.Size = new Size(401, 33);
            btn_Schedule.TabIndex = 29;
            btn_Schedule.Text = "Show Schedule";
            btn_Schedule.UseVisualStyleBackColor = false;
            btn_Schedule.Click += btn_Schedule_Click;
            // 
            // datepickerfrom
            // 
            datepickerfrom.Anchor = AnchorStyles.None;
            datepickerfrom.CalendarForeColor = SystemColors.ButtonHighlight;
            datepickerfrom.CalendarMonthBackground = Color.CornflowerBlue;
            datepickerfrom.CalendarTitleBackColor = Color.CornflowerBlue;
            datepickerfrom.CalendarTrailingForeColor = SystemColors.ButtonHighlight;
            datepickerfrom.Location = new Point(190, 173);
            datepickerfrom.Name = "datepickerfrom";
            datepickerfrom.Size = new Size(250, 27);
            datepickerfrom.TabIndex = 0;
            datepickerfrom.Value = new DateTime(2025, 2, 4, 0, 0, 0, 0);
            // 
            // dgv_schedule
            // 
            dgv_schedule.Anchor = AnchorStyles.None;
            dgv_schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_schedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_schedule.BackgroundColor = Color.CornflowerBlue;
            dgv_schedule.BorderStyle = BorderStyle.Fixed3D;
            dgv_schedule.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgv_schedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_schedule.GridColor = Color.CornflowerBlue;
            dgv_schedule.Location = new Point(419, 541);
            dgv_schedule.Name = "dgv_schedule";
            dgv_schedule.ReadOnly = true;
            dgv_schedule.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgv_schedule.RowHeadersWidth = 51;
            dgv_schedule.Size = new Size(968, 352);
            dgv_schedule.TabIndex = 24;
            // 
            // btnAllLessons
            // 
            btnAllLessons.Anchor = AnchorStyles.None;
            btnAllLessons.BackColor = Color.CornflowerBlue;
            btnAllLessons.Cursor = Cursors.Hand;
            btnAllLessons.FlatStyle = FlatStyle.Popup;
            btnAllLessons.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAllLessons.ForeColor = SystemColors.ButtonHighlight;
            btnAllLessons.Location = new Point(1407, 541);
            btnAllLessons.Margin = new Padding(3, 4, 3, 4);
            btnAllLessons.Name = "btnAllLessons";
            btnAllLessons.Size = new Size(278, 33);
            btnAllLessons.TabIndex = 30;
            btnAllLessons.Text = "All lesons";
            btnAllLessons.UseVisualStyleBackColor = false;
            btnAllLessons.Click += btnAllLessons_Click;
            // 
            // btnsignout
            // 
            btnsignout.Anchor = AnchorStyles.None;
            btnsignout.BackColor = Color.CornflowerBlue;
            btnsignout.Cursor = Cursors.Hand;
            btnsignout.FlatStyle = FlatStyle.Flat;
            btnsignout.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignout.ForeColor = Color.DarkRed;
            btnsignout.Location = new Point(1662, 69);
            btnsignout.Margin = new Padding(3, 4, 3, 4);
            btnsignout.Name = "btnsignout";
            btnsignout.Size = new Size(120, 34);
            btnsignout.TabIndex = 31;
            btnsignout.Text = "sign out ";
            btnsignout.UseVisualStyleBackColor = false;
            btnsignout.Click += btnsignout_Click;
            // 
            // TeacherDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1809, 932);
            Controls.Add(btnsignout);
            Controls.Add(btnAllLessons);
            Controls.Add(dgv_schedule);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(welcomee);
            Controls.Add(button1);
            Controls.Add(welcome);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherDashBoard";
            Load += TeacherDashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_schedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label welcome;
        private Button button1;
        private Label welcomee;
        private Label label2;
        private Label label1;
        private Label lblOldPassword;
        private Label lblNewPassword;
        private Panel panel1;
        private Label lblConfirmPassword;
        private TextBox txt_phone;
        private TextBox txt_mail;
        private TextBox txtConfirmpass;
        private TextBox txtNewpass;
        private TextBox txtOldpass;
        private Button btnsave;
        private Button button2;
        private Panel panel2;
        private Button btn_ManageDegrees;
        private Button btn_Schedule;
        private DateTimePicker datepickerfrom;
        private Label label4;
        private Label label3;
        private DataGridView dgv_schedule;
        private DateTimePicker datepickerto;
        private Label lblPasswordError;
        private Label label5;
        private Label lblConfirmPasswordError;
        private Label lblEmailError;
        private Label lblPhoneError;
        private Button btnAllLessons;
        private Button btnsignout;
    }
}
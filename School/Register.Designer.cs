namespace School
{
    partial class Register
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
            close_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            rb_female = new RadioButton();
            rb_male = new RadioButton();
            label10 = new Label();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_email = new TextBox();
            txt_phone = new TextBox();
            txt_pass = new TextBox();
            txtconfirmpass = new TextBox();
            button1 = new Button();
            lblFirstNameError = new Label();
            lblLastNameError = new Label();
            lblEmailError = new Label();
            errorgender = new Label();
            lblPhoneError = new Label();
            lblPasswordError = new Label();
            lblConfirmPasswordError = new Label();
            label5 = new Label();
            button2 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.None;
            close_btn.AutoSize = true;
            close_btn.BackColor = Color.CornflowerBlue;
            close_btn.Cursor = Cursors.Hand;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_btn.ForeColor = SystemColors.ActiveCaptionText;
            close_btn.Location = new Point(1344, 13);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(38, 34);
            close_btn.TabIndex = 12;
            close_btn.Text = "X";
            close_btn.TextAlign = ContentAlignment.BottomLeft;
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(640, 100);
            label1.Name = "label1";
            label1.Size = new Size(216, 50);
            label1.TabIndex = 13;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label2.Location = new Point(278, 222);
            label2.Name = "label2";
            label2.Size = new Size(124, 26);
            label2.TabIndex = 14;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label3.Location = new Point(278, 294);
            label3.Name = "label3";
            label3.Size = new Size(115, 26);
            label3.TabIndex = 15;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label4.Location = new Point(278, 369);
            label4.Name = "label4";
            label4.Size = new Size(78, 26);
            label4.TabIndex = 16;
            label4.Text = "E-Mail";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label7.Location = new Point(817, 227);
            label7.Name = "label7";
            label7.Size = new Size(80, 26);
            label7.TabIndex = 19;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label8.Location = new Point(808, 295);
            label8.Name = "label8";
            label8.Size = new Size(122, 26);
            label8.TabIndex = 20;
            label8.Text = "Password";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label9.Location = new Point(729, 373);
            label9.Name = "label9";
            label9.Size = new Size(219, 26);
            label9.TabIndex = 21;
            label9.Text = "Confirm-password";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(rb_female);
            panel2.Controls.Add(rb_male);
            panel2.Location = new Point(430, 439);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 39);
            panel2.TabIndex = 25;
            // 
            // rb_female
            // 
            rb_female.Anchor = AnchorStyles.None;
            rb_female.AutoSize = true;
            rb_female.Font = new Font("Showcard Gothic", 10.2F);
            rb_female.Location = new Point(130, 3);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(92, 25);
            rb_female.TabIndex = 1;
            rb_female.TabStop = true;
            rb_female.Text = "Female";
            rb_female.UseVisualStyleBackColor = true;
            rb_female.CheckedChanged += rb_female_CheckedChanged;
            // 
            // rb_male
            // 
            rb_male.Anchor = AnchorStyles.None;
            rb_male.AutoSize = true;
            rb_male.Font = new Font("Showcard Gothic", 10.2F);
            rb_male.Location = new Point(0, 3);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(74, 25);
            rb_male.TabIndex = 0;
            rb_male.TabStop = true;
            rb_male.Text = "Male";
            rb_male.UseVisualStyleBackColor = true;
            rb_male.CheckedChanged += rb_male_CheckedChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label10.Location = new Point(266, 439);
            label10.Name = "label10";
            label10.Size = new Size(90, 26);
            label10.TabIndex = 24;
            label10.Text = "Gender";
            // 
            // txt_fname
            // 
            txt_fname.Anchor = AnchorStyles.None;
            txt_fname.BackColor = SystemColors.InactiveCaptionText;
            txt_fname.BorderStyle = BorderStyle.FixedSingle;
            txt_fname.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_fname.ForeColor = Color.CornflowerBlue;
            txt_fname.Location = new Point(436, 219);
            txt_fname.Margin = new Padding(3, 4, 3, 4);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(275, 31);
            txt_fname.TabIndex = 26;
            txt_fname.Tag = "lblFirstNameError";
            txt_fname.TextChanged += txt_fname_TextChanged;
            // 
            // txt_lname
            // 
            txt_lname.Anchor = AnchorStyles.None;
            txt_lname.BackColor = SystemColors.InactiveCaptionText;
            txt_lname.BorderStyle = BorderStyle.FixedSingle;
            txt_lname.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_lname.ForeColor = Color.CornflowerBlue;
            txt_lname.Location = new Point(436, 295);
            txt_lname.Margin = new Padding(3, 4, 3, 4);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(275, 31);
            txt_lname.TabIndex = 27;
            txt_lname.Tag = "lblLastNameError";
            txt_lname.TextChanged += txt_lname_TextChanged;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.BackColor = SystemColors.InactiveCaptionText;
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_email.ForeColor = Color.CornflowerBlue;
            txt_email.Location = new Point(433, 370);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(275, 31);
            txt_email.TabIndex = 28;
            txt_email.Tag = "lblEmailError";
            txt_email.TextChanged += txt_email_TextChanged;
            // 
            // txt_phone
            // 
            txt_phone.Anchor = AnchorStyles.None;
            txt_phone.BackColor = SystemColors.InactiveCaptionText;
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_phone.ForeColor = Color.CornflowerBlue;
            txt_phone.Location = new Point(971, 222);
            txt_phone.Margin = new Padding(3, 4, 3, 4);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(275, 31);
            txt_phone.TabIndex = 29;
            txt_phone.Tag = "lblPhoneError";
            txt_phone.TextChanged += txt_phone_TextChanged;
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.BackColor = SystemColors.InactiveCaptionText;
            txt_pass.BorderStyle = BorderStyle.FixedSingle;
            txt_pass.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_pass.ForeColor = Color.CornflowerBlue;
            txt_pass.Location = new Point(971, 296);
            txt_pass.Margin = new Padding(3, 4, 3, 4);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(275, 31);
            txt_pass.TabIndex = 30;
            txt_pass.Tag = "lblPasswordError";
            txt_pass.TextChanged += txt_pass_TextChanged;
            // 
            // txtconfirmpass
            // 
            txtconfirmpass.Anchor = AnchorStyles.None;
            txtconfirmpass.BackColor = SystemColors.InactiveCaptionText;
            txtconfirmpass.BorderStyle = BorderStyle.FixedSingle;
            txtconfirmpass.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txtconfirmpass.ForeColor = Color.CornflowerBlue;
            txtconfirmpass.Location = new Point(972, 370);
            txtconfirmpass.Margin = new Padding(3, 4, 3, 4);
            txtconfirmpass.Name = "txtconfirmpass";
            txtconfirmpass.PasswordChar = '*';
            txtconfirmpass.Size = new Size(275, 31);
            txtconfirmpass.TabIndex = 31;
            txtconfirmpass.Tag = "lblConfirmPasswordError";
            txtconfirmpass.TextChanged += txtconfirmpass_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(686, 564);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 32;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.AutoSize = true;
            lblFirstNameError.ForeColor = Color.Red;
            lblFirstNameError.Location = new Point(446, 261);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(123, 20);
            lblFirstNameError.TabIndex = 33;
            lblFirstNameError.Tag = "error";
            lblFirstNameError.Text = "invalid first name";
            lblFirstNameError.Visible = false;
            // 
            // lblLastNameError
            // 
            lblLastNameError.AutoSize = true;
            lblLastNameError.ForeColor = Color.Red;
            lblLastNameError.Location = new Point(446, 337);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(121, 20);
            lblLastNameError.TabIndex = 34;
            lblLastNameError.Tag = "error";
            lblLastNameError.Text = "invalid last name";
            lblLastNameError.Visible = false;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(446, 412);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(94, 20);
            lblEmailError.TabIndex = 35;
            lblEmailError.Tag = "error";
            lblEmailError.Text = "invalid email";
            lblEmailError.Visible = false;
            // 
            // errorgender
            // 
            errorgender.AutoSize = true;
            errorgender.ForeColor = Color.Red;
            errorgender.Location = new Point(446, 492);
            errorgender.Name = "errorgender";
            errorgender.Size = new Size(206, 20);
            errorgender.TabIndex = 37;
            errorgender.Tag = "error";
            errorgender.Text = "you must choose right gender";
            errorgender.Visible = false;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(972, 261);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(154, 20);
            lblPhoneError.TabIndex = 38;
            lblPhoneError.Tag = "error";
            lblPhoneError.Text = "invalid phone number";
            lblPhoneError.Visible = false;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(971, 338);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(92, 20);
            lblPasswordError.TabIndex = 39;
            lblPasswordError.Tag = "error";
            lblPasswordError.Text = "invalid value";
            lblPasswordError.Visible = false;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.AutoSize = true;
            lblConfirmPasswordError.ForeColor = Color.Red;
            lblConfirmPasswordError.Location = new Point(972, 405);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(278, 20);
            lblConfirmPasswordError.TabIndex = 40;
            lblConfirmPasswordError.Tag = "error";
            lblConfirmPasswordError.Text = "confirm password must be like password";
            lblConfirmPasswordError.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Rage Italic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(616, 653);
            label5.Name = "label5";
            label5.Size = new Size(195, 25);
            label5.TabIndex = 41;
            label5.Text = "If you  have account ..";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.ControlText;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(803, 649);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 42;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1394, 779);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(lblConfirmPasswordError);
            Controls.Add(lblPasswordError);
            Controls.Add(lblPhoneError);
            Controls.Add(errorgender);
            Controls.Add(lblEmailError);
            Controls.Add(lblLastNameError);
            Controls.Add(lblFirstNameError);
            Controls.Add(button1);
            Controls.Add(txtconfirmpass);
            Controls.Add(txt_pass);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close_btn);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel2;
        private RadioButton rb_female;
        private RadioButton rb_male;
        private Label label10;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_email;
        private TextBox txt_phone;
        private TextBox txt_pass;
        private TextBox txtconfirmpass;
        private Button button1;
        private Label lblFirstNameError;
        private Label lblLastNameError;
        private Label lblEmailError;
        private Label errorgender;
        private Label lblPhoneError;
        private Label lblPasswordError;
        private Label lblConfirmPasswordError;
        private Label label5;
        private Button button2;
    }
}
namespace School
{
    partial class ManageUsers
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
            btnsignout = new Button();
            btndash = new Button();
            dgv_users = new DataGridView();
            txt_fname = new TextBox();
            txt_lastname = new TextBox();
            txt_mail = new TextBox();
            txt_phone = new TextBox();
            txtpassword = new TextBox();
            panel2 = new Panel();
            rfemale = new RadioButton();
            rmale = new RadioButton();
            rb_female = new RadioButton();
            rb_male = new RadioButton();
            label10 = new Label();
            panel1 = new Panel();
            radmin = new RadioButton();
            rteacher = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label1 = new Label();
            fname = new Label();
            lname = new Label();
            mail = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            errorfname = new Label();
            errorlname = new Label();
            errormail = new Label();
            errorphone = new Label();
            errorpass = new Label();
            errorgender = new Label();
            errorrole = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            close_btn.Location = new Point(1728, 13);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(38, 34);
            close_btn.TabIndex = 12;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // btnsignout
            // 
            btnsignout.Anchor = AnchorStyles.None;
            btnsignout.BackColor = Color.CornflowerBlue;
            btnsignout.Cursor = Cursors.Hand;
            btnsignout.FlatStyle = FlatStyle.Flat;
            btnsignout.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignout.ForeColor = Color.DarkRed;
            btnsignout.Location = new Point(1646, 67);
            btnsignout.Margin = new Padding(3, 4, 3, 4);
            btnsignout.Name = "btnsignout";
            btnsignout.Size = new Size(120, 34);
            btnsignout.TabIndex = 32;
            btnsignout.Text = "sign out ";
            btnsignout.UseVisualStyleBackColor = false;
            btnsignout.Click += btnsignout_Click;
            // 
            // btndash
            // 
            btndash.Anchor = AnchorStyles.None;
            btndash.BackColor = Color.CornflowerBlue;
            btndash.Cursor = Cursors.Hand;
            btndash.FlatStyle = FlatStyle.Popup;
            btndash.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndash.ForeColor = SystemColors.ButtonHighlight;
            btndash.Location = new Point(21, 29);
            btndash.Margin = new Padding(3, 4, 3, 4);
            btndash.Name = "btndash";
            btndash.Size = new Size(163, 33);
            btndash.TabIndex = 44;
            btndash.Text = "Dash Board";
            btndash.UseVisualStyleBackColor = false;
            btndash.Click += btndash_Click;
            // 
            // dgv_users
            // 
            dgv_users.Anchor = AnchorStyles.None;
            dgv_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_users.BackgroundColor = Color.CornflowerBlue;
            dgv_users.BorderStyle = BorderStyle.Fixed3D;
            dgv_users.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.GridColor = Color.CornflowerBlue;
            dgv_users.Location = new Point(729, 494);
            dgv_users.Name = "dgv_users";
            dgv_users.ReadOnly = true;
            dgv_users.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgv_users.RowHeadersWidth = 51;
            dgv_users.Size = new Size(968, 352);
            dgv_users.TabIndex = 45;
            dgv_users.RowHeaderMouseClick += dgv_users_RowHeaderMouseClick;
            // 
            // txt_fname
            // 
            txt_fname.Anchor = AnchorStyles.None;
            txt_fname.BackColor = SystemColors.InactiveCaptionText;
            txt_fname.BorderStyle = BorderStyle.FixedSingle;
            txt_fname.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_fname.ForeColor = Color.CornflowerBlue;
            txt_fname.Location = new Point(213, 143);
            txt_fname.Margin = new Padding(3, 4, 3, 4);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(214, 31);
            txt_fname.TabIndex = 46;
            txt_fname.TextChanged += txt_fname_TextChanged;
            // 
            // txt_lastname
            // 
            txt_lastname.Anchor = AnchorStyles.None;
            txt_lastname.BackColor = SystemColors.InactiveCaptionText;
            txt_lastname.BorderStyle = BorderStyle.FixedSingle;
            txt_lastname.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_lastname.ForeColor = Color.CornflowerBlue;
            txt_lastname.Location = new Point(213, 250);
            txt_lastname.Margin = new Padding(3, 4, 3, 4);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(214, 31);
            txt_lastname.TabIndex = 47;
            txt_lastname.TextChanged += txt_lastname_TextChanged;
            // 
            // txt_mail
            // 
            txt_mail.Anchor = AnchorStyles.None;
            txt_mail.BackColor = SystemColors.InactiveCaptionText;
            txt_mail.BorderStyle = BorderStyle.FixedSingle;
            txt_mail.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_mail.ForeColor = Color.CornflowerBlue;
            txt_mail.Location = new Point(213, 370);
            txt_mail.Margin = new Padding(3, 4, 3, 4);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(214, 31);
            txt_mail.TabIndex = 48;
            txt_mail.TextChanged += txt_mail_TextChanged;
            // 
            // txt_phone
            // 
            txt_phone.Anchor = AnchorStyles.None;
            txt_phone.BackColor = SystemColors.InactiveCaptionText;
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_phone.ForeColor = Color.CornflowerBlue;
            txt_phone.Location = new Point(689, 143);
            txt_phone.Margin = new Padding(3, 4, 3, 4);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(214, 31);
            txt_phone.TabIndex = 49;
            txt_phone.TextChanged += txt_phone_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.None;
            txtpassword.BackColor = SystemColors.InactiveCaptionText;
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txtpassword.ForeColor = Color.CornflowerBlue;
            txtpassword.Location = new Point(689, 228);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(214, 31);
            txtpassword.TabIndex = 50;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(rfemale);
            panel2.Controls.Add(rmale);
            panel2.Controls.Add(rb_female);
            panel2.Controls.Add(rb_male);
            panel2.Location = new Point(689, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 39);
            panel2.TabIndex = 52;
            // 
            // rfemale
            // 
            rfemale.Anchor = AnchorStyles.None;
            rfemale.AutoSize = true;
            rfemale.Font = new Font("Showcard Gothic", 10.2F);
            rfemale.Location = new Point(156, 7);
            rfemale.Name = "rfemale";
            rfemale.Size = new Size(92, 25);
            rfemale.TabIndex = 3;
            rfemale.TabStop = true;
            rfemale.Text = "Female";
            rfemale.UseVisualStyleBackColor = true;
            rfemale.CheckedChanged += rfemale_CheckedChanged;
            // 
            // rmale
            // 
            rmale.Anchor = AnchorStyles.None;
            rmale.AutoSize = true;
            rmale.Font = new Font("Showcard Gothic", 10.2F);
            rmale.Location = new Point(26, 7);
            rmale.Name = "rmale";
            rmale.Size = new Size(74, 25);
            rmale.TabIndex = 2;
            rmale.TabStop = true;
            rmale.Text = "Male";
            rmale.UseVisualStyleBackColor = true;
            rmale.CheckedChanged += rmale_CheckedChanged;
            // 
            // rb_female
            // 
            rb_female.Anchor = AnchorStyles.None;
            rb_female.AutoSize = true;
            rb_female.Font = new Font("Showcard Gothic", 10.2F);
            rb_female.Location = new Point(167, -28);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(92, 25);
            rb_female.TabIndex = 1;
            rb_female.TabStop = true;
            rb_female.Text = "Female";
            rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            rb_male.Anchor = AnchorStyles.None;
            rb_male.AutoSize = true;
            rb_male.Font = new Font("Showcard Gothic", 10.2F);
            rb_male.Location = new Point(37, -28);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(74, 25);
            rb_male.TabIndex = 0;
            rb_male.TabStop = true;
            rb_male.Text = "Male";
            rb_male.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label10.Location = new Point(558, 313);
            label10.Name = "label10";
            label10.Size = new Size(90, 26);
            label10.TabIndex = 51;
            label10.Text = "Gender";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(radmin);
            panel1.Controls.Add(rteacher);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton6);
            panel1.Location = new Point(689, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 39);
            panel1.TabIndex = 54;
            // 
            // radmin
            // 
            radmin.Anchor = AnchorStyles.None;
            radmin.AutoSize = true;
            radmin.Font = new Font("Showcard Gothic", 10.2F);
            radmin.Location = new Point(26, 7);
            radmin.Name = "radmin";
            radmin.Size = new Size(86, 25);
            radmin.TabIndex = 5;
            radmin.TabStop = true;
            radmin.Text = "admin";
            radmin.UseVisualStyleBackColor = true;
            radmin.CheckedChanged += radmin_CheckedChanged;
            // 
            // rteacher
            // 
            rteacher.Anchor = AnchorStyles.None;
            rteacher.AutoSize = true;
            rteacher.Font = new Font("Showcard Gothic", 10.2F);
            rteacher.Location = new Point(156, 7);
            rteacher.Name = "rteacher";
            rteacher.Size = new Size(104, 25);
            rteacher.TabIndex = 4;
            rteacher.TabStop = true;
            rteacher.Text = "teacher";
            rteacher.UseVisualStyleBackColor = true;
            rteacher.CheckedChanged += rteacher_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.None;
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Showcard Gothic", 10.2F);
            radioButton3.Location = new Point(193, -24);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(92, 25);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Female";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.None;
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Showcard Gothic", 10.2F);
            radioButton4.Location = new Point(63, -24);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(74, 25);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "Male";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.Anchor = AnchorStyles.None;
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Showcard Gothic", 10.2F);
            radioButton5.Location = new Point(204, -59);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(92, 25);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Female";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.Anchor = AnchorStyles.None;
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Showcard Gothic", 10.2F);
            radioButton6.Location = new Point(74, -59);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(74, 25);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "Male";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label1.Location = new Point(558, 377);
            label1.Name = "label1";
            label1.Size = new Size(63, 26);
            label1.TabIndex = 53;
            label1.Text = "role";
            // 
            // fname
            // 
            fname.Anchor = AnchorStyles.None;
            fname.AutoSize = true;
            fname.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            fname.Location = new Point(70, 148);
            fname.Name = "fname";
            fname.Size = new Size(124, 26);
            fname.TabIndex = 55;
            fname.Text = "first name";
            // 
            // lname
            // 
            lname.Anchor = AnchorStyles.None;
            lname.AutoSize = true;
            lname.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            lname.Location = new Point(70, 255);
            lname.Name = "lname";
            lname.Size = new Size(115, 26);
            lname.TabIndex = 56;
            lname.Text = "last name";
            // 
            // mail
            // 
            mail.Anchor = AnchorStyles.None;
            mail.AutoSize = true;
            mail.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            mail.Location = new Point(70, 369);
            mail.Name = "mail";
            mail.Size = new Size(70, 26);
            mail.TabIndex = 57;
            mail.Text = "email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label5.Location = new Point(558, 143);
            label5.Name = "label5";
            label5.Size = new Size(80, 26);
            label5.TabIndex = 58;
            label5.Text = "phone";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label6.Location = new Point(558, 228);
            label6.Name = "label6";
            label6.Size = new Size(122, 26);
            label6.TabIndex = 59;
            label6.Text = "password";
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.None;
            btn_add.BackColor = Color.CornflowerBlue;
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatStyle = FlatStyle.Popup;
            btn_add.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = SystemColors.ButtonHighlight;
            btn_add.Location = new Point(49, 462);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(163, 33);
            btn_add.TabIndex = 60;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.None;
            btn_update.BackColor = Color.CornflowerBlue;
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatStyle = FlatStyle.Popup;
            btn_update.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.ButtonHighlight;
            btn_update.Location = new Point(96, 528);
            btn_update.Margin = new Padding(3, 4, 3, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(163, 33);
            btn_update.TabIndex = 61;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Visible = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.None;
            btn_delete.BackColor = Color.CornflowerBlue;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatStyle = FlatStyle.Popup;
            btn_delete.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ButtonHighlight;
            btn_delete.Location = new Point(291, 528);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(163, 33);
            btn_delete.TabIndex = 62;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Visible = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // errorfname
            // 
            errorfname.AutoSize = true;
            errorfname.ForeColor = Color.Red;
            errorfname.Location = new Point(263, 178);
            errorfname.Name = "errorfname";
            errorfname.Size = new Size(92, 20);
            errorfname.TabIndex = 63;
            errorfname.Tag = "error";
            errorfname.Text = "invalid value";
            errorfname.Visible = false;
            // 
            // errorlname
            // 
            errorlname.AutoSize = true;
            errorlname.ForeColor = Color.Red;
            errorlname.Location = new Point(263, 285);
            errorlname.Name = "errorlname";
            errorlname.Size = new Size(92, 20);
            errorlname.TabIndex = 64;
            errorlname.Tag = "error";
            errorlname.Text = "invalid value";
            errorlname.Visible = false;
            // 
            // errormail
            // 
            errormail.AutoSize = true;
            errormail.ForeColor = Color.Red;
            errormail.Location = new Point(263, 405);
            errormail.Name = "errormail";
            errormail.Size = new Size(92, 20);
            errormail.TabIndex = 65;
            errormail.Tag = "error";
            errormail.Text = "invalid value";
            errormail.Visible = false;
            // 
            // errorphone
            // 
            errorphone.AutoSize = true;
            errorphone.ForeColor = Color.Red;
            errorphone.Location = new Point(729, 178);
            errorphone.Name = "errorphone";
            errorphone.Size = new Size(92, 20);
            errorphone.TabIndex = 66;
            errorphone.Tag = "error";
            errorphone.Text = "invalid value";
            errorphone.Visible = false;
            // 
            // errorpass
            // 
            errorpass.AutoSize = true;
            errorpass.ForeColor = Color.Red;
            errorpass.Location = new Point(729, 261);
            errorpass.Name = "errorpass";
            errorpass.Size = new Size(92, 20);
            errorpass.TabIndex = 67;
            errorpass.Tag = "error";
            errorpass.Text = "invalid value";
            errorpass.Visible = false;
            // 
            // errorgender
            // 
            errorgender.AutoSize = true;
            errorgender.ForeColor = Color.Red;
            errorgender.Location = new Point(729, 341);
            errorgender.Name = "errorgender";
            errorgender.Size = new Size(92, 20);
            errorgender.TabIndex = 68;
            errorgender.Tag = "error";
            errorgender.Text = "invalid value";
            errorgender.Visible = false;
            // 
            // errorrole
            // 
            errorrole.AutoSize = true;
            errorrole.ForeColor = Color.Red;
            errorrole.Location = new Point(729, 412);
            errorrole.Name = "errorrole";
            errorrole.Size = new Size(92, 20);
            errorrole.TabIndex = 69;
            errorrole.Tag = "error";
            errorrole.Text = "invalid value";
            errorrole.Visible = false;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1791, 885);
            Controls.Add(errorrole);
            Controls.Add(errorgender);
            Controls.Add(errorpass);
            Controls.Add(errorphone);
            Controls.Add(errormail);
            Controls.Add(errorlname);
            Controls.Add(errorfname);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(mail);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(txtpassword);
            Controls.Add(txt_phone);
            Controls.Add(txt_mail);
            Controls.Add(txt_lastname);
            Controls.Add(txt_fname);
            Controls.Add(dgv_users);
            Controls.Add(btndash);
            Controls.Add(btnsignout);
            Controls.Add(close_btn);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close_btn;
        private Button btnsignout;
        private Button btndash;
        private DataGridView dgv_users;
        private TextBox txt_fname;
        private TextBox txt_lastname;
        private TextBox txt_mail;
        private TextBox txt_phone;
        private TextBox txtpassword;
        private Panel panel2;
        private RadioButton rb_female;
        private RadioButton rb_male;
        private Label label10;
        private RadioButton rfemale;
        private RadioButton rmale;
        private Panel panel1;
        private RadioButton radmin;
        private RadioButton rteacher;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label1;
        private Label fname;
        private Label lname;
        private Label mail;
        private Label label5;
        private Label label6;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Label errorfname;
        private Label errorlname;
        private Label errormail;
        private Label errorphone;
        private Label errorpass;
        private Label errorgender;
        private Label errorrole;
    }
}
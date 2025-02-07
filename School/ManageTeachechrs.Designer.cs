namespace School
{
    partial class ManageTeachechrs
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
            errorgender = new Label();
            errorphone = new Label();
            errormail = new Label();
            errorlname = new Label();
            errorfname = new Label();
            label6 = new Label();
            label5 = new Label();
            mail = new Label();
            lname = new Label();
            fname = new Label();
            label1 = new Label();
            panel2 = new Panel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            rfemale = new RadioButton();
            rmale = new RadioButton();
            rb_female = new RadioButton();
            rb_male = new RadioButton();
            label10 = new Label();
            txt_phone = new TextBox();
            txt_mail = new TextBox();
            txt_lastname = new TextBox();
            txt_fname = new TextBox();
            dgv_teachers = new DataGridView();
            datepickerhiredate = new DateTimePicker();
            datepickerbirthdate = new DateTimePicker();
            label2 = new Label();
            comboBox1 = new ComboBox();
            searchtextbox = new TextBox();
            btn_search = new Button();
            errorsubject = new Label();
            btnadd = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            dgv_scheduleteacher = new DataGridView();
            btndeletelesson = new Button();
            btnaddseesion = new Button();
            datapickerlessondate = new DateTimePicker();
            comboboxclasses = new ComboBox();
            comboboxlessons = new ComboBox();
            btnrefresh = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_teachers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_scheduleteacher).BeginInit();
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
            close_btn.Location = new Point(1725, 13);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(38, 34);
            close_btn.TabIndex = 13;
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
            btnsignout.Location = new Point(1643, 68);
            btnsignout.Margin = new Padding(3, 4, 3, 4);
            btnsignout.Name = "btnsignout";
            btnsignout.Size = new Size(120, 34);
            btnsignout.TabIndex = 33;
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
            btndash.Location = new Point(12, 33);
            btndash.Margin = new Padding(3, 4, 3, 4);
            btndash.Name = "btndash";
            btndash.Size = new Size(163, 33);
            btndash.TabIndex = 45;
            btndash.Text = "Dash Board";
            btndash.UseVisualStyleBackColor = false;
            btndash.Click += btndash_Click;
            // 
            // errorgender
            // 
            errorgender.AutoSize = true;
            errorgender.ForeColor = Color.Red;
            errorgender.Location = new Point(268, 442);
            errorgender.Name = "errorgender";
            errorgender.Size = new Size(92, 20);
            errorgender.TabIndex = 92;
            errorgender.Tag = "error";
            errorgender.Text = "invalid value";
            errorgender.Visible = false;
            // 
            // errorphone
            // 
            errorphone.AutoSize = true;
            errorphone.ForeColor = Color.Red;
            errorphone.Location = new Point(268, 345);
            errorphone.Name = "errorphone";
            errorphone.Size = new Size(92, 20);
            errorphone.TabIndex = 91;
            errorphone.Tag = "error";
            errorphone.Text = "invalid value";
            errorphone.Visible = false;
            // 
            // errormail
            // 
            errormail.AutoSize = true;
            errormail.ForeColor = Color.Red;
            errormail.Location = new Point(285, 273);
            errormail.Name = "errormail";
            errormail.Size = new Size(92, 20);
            errormail.TabIndex = 90;
            errormail.Tag = "error";
            errormail.Text = "invalid value";
            errormail.Visible = false;
            // 
            // errorlname
            // 
            errorlname.AutoSize = true;
            errorlname.ForeColor = Color.Red;
            errorlname.Location = new Point(285, 209);
            errorlname.Name = "errorlname";
            errorlname.Size = new Size(92, 20);
            errorlname.TabIndex = 89;
            errorlname.Tag = "error";
            errorlname.Text = "invalid value";
            errorlname.Visible = false;
            // 
            // errorfname
            // 
            errorfname.AutoSize = true;
            errorfname.ForeColor = Color.Red;
            errorfname.Location = new Point(285, 126);
            errorfname.Name = "errorfname";
            errorfname.Size = new Size(92, 20);
            errorfname.TabIndex = 88;
            errorfname.Tag = "error";
            errorfname.Text = "invalid value";
            errorfname.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label6.Location = new Point(90, 541);
            label6.Name = "label6";
            label6.Size = new Size(115, 26);
            label6.TabIndex = 84;
            label6.Text = "hire date";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label5.Location = new Point(101, 310);
            label5.Name = "label5";
            label5.Size = new Size(80, 26);
            label5.TabIndex = 83;
            label5.Text = "phone";
            // 
            // mail
            // 
            mail.Anchor = AnchorStyles.None;
            mail.AutoSize = true;
            mail.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            mail.Location = new Point(118, 238);
            mail.Name = "mail";
            mail.Size = new Size(70, 26);
            mail.TabIndex = 82;
            mail.Text = "email";
            // 
            // lname
            // 
            lname.Anchor = AnchorStyles.None;
            lname.AutoSize = true;
            lname.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            lname.Location = new Point(101, 166);
            lname.Name = "lname";
            lname.Size = new Size(115, 26);
            lname.TabIndex = 81;
            lname.Text = "last name";
            // 
            // fname
            // 
            fname.Anchor = AnchorStyles.None;
            fname.AutoSize = true;
            fname.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            fname.Location = new Point(92, 96);
            fname.Name = "fname";
            fname.Size = new Size(124, 26);
            fname.TabIndex = 80;
            fname.Text = "first name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label1.Location = new Point(92, 480);
            label1.Name = "label1";
            label1.Size = new Size(94, 26);
            label1.TabIndex = 78;
            label1.Text = "Subject";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(rfemale);
            panel2.Controls.Add(rmale);
            panel2.Controls.Add(rb_female);
            panel2.Controls.Add(rb_male);
            panel2.Location = new Point(214, 397);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 39);
            panel2.TabIndex = 77;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Showcard Gothic", 10.2F);
            radioButton1.Location = new Point(156, 7);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(92, 25);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.None;
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Showcard Gothic", 10.2F);
            radioButton2.Location = new Point(26, 7);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 25);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rfemale
            // 
            rfemale.Anchor = AnchorStyles.None;
            rfemale.AutoSize = true;
            rfemale.Font = new Font("Showcard Gothic", 10.2F);
            rfemale.Location = new Point(193, -24);
            rfemale.Name = "rfemale";
            rfemale.Size = new Size(92, 25);
            rfemale.TabIndex = 3;
            rfemale.TabStop = true;
            rfemale.Text = "Female";
            rfemale.UseVisualStyleBackColor = true;
            // 
            // rmale
            // 
            rmale.Anchor = AnchorStyles.None;
            rmale.AutoSize = true;
            rmale.Font = new Font("Showcard Gothic", 10.2F);
            rmale.Location = new Point(63, -24);
            rmale.Name = "rmale";
            rmale.Size = new Size(74, 25);
            rmale.TabIndex = 2;
            rmale.TabStop = true;
            rmale.Text = "Male";
            rmale.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            rb_female.Anchor = AnchorStyles.None;
            rb_female.AutoSize = true;
            rb_female.Font = new Font("Showcard Gothic", 10.2F);
            rb_female.Location = new Point(204, -59);
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
            rb_male.Location = new Point(74, -59);
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
            label10.Location = new Point(92, 397);
            label10.Name = "label10";
            label10.Size = new Size(90, 26);
            label10.TabIndex = 76;
            label10.Text = "Gender";
            // 
            // txt_phone
            // 
            txt_phone.Anchor = AnchorStyles.None;
            txt_phone.BackColor = SystemColors.InactiveCaptionText;
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_phone.ForeColor = Color.CornflowerBlue;
            txt_phone.Location = new Point(235, 310);
            txt_phone.Margin = new Padding(3, 4, 3, 4);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(214, 31);
            txt_phone.TabIndex = 74;
            txt_phone.TextChanged += txt_phone_TextChanged;
            // 
            // txt_mail
            // 
            txt_mail.Anchor = AnchorStyles.None;
            txt_mail.BackColor = SystemColors.InactiveCaptionText;
            txt_mail.BorderStyle = BorderStyle.FixedSingle;
            txt_mail.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_mail.ForeColor = Color.CornflowerBlue;
            txt_mail.Location = new Point(235, 233);
            txt_mail.Margin = new Padding(3, 4, 3, 4);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(214, 31);
            txt_mail.TabIndex = 73;
            txt_mail.TextChanged += txt_mail_TextChanged;
            // 
            // txt_lastname
            // 
            txt_lastname.Anchor = AnchorStyles.None;
            txt_lastname.BackColor = SystemColors.InactiveCaptionText;
            txt_lastname.BorderStyle = BorderStyle.FixedSingle;
            txt_lastname.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_lastname.ForeColor = Color.CornflowerBlue;
            txt_lastname.Location = new Point(235, 161);
            txt_lastname.Margin = new Padding(3, 4, 3, 4);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(214, 31);
            txt_lastname.TabIndex = 72;
            txt_lastname.TextChanged += txt_lastname_TextChanged;
            // 
            // txt_fname
            // 
            txt_fname.Anchor = AnchorStyles.None;
            txt_fname.BackColor = SystemColors.InactiveCaptionText;
            txt_fname.BorderStyle = BorderStyle.FixedSingle;
            txt_fname.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_fname.ForeColor = Color.CornflowerBlue;
            txt_fname.Location = new Point(235, 91);
            txt_fname.Margin = new Padding(3, 4, 3, 4);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(214, 31);
            txt_fname.TabIndex = 71;
            txt_fname.TextChanged += txt_fname_TextChanged;
            // 
            // dgv_teachers
            // 
            dgv_teachers.Anchor = AnchorStyles.None;
            dgv_teachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_teachers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_teachers.BackgroundColor = Color.CornflowerBlue;
            dgv_teachers.BorderStyle = BorderStyle.Fixed3D;
            dgv_teachers.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgv_teachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_teachers.GridColor = Color.CornflowerBlue;
            dgv_teachers.Location = new Point(742, 140);
            dgv_teachers.Name = "dgv_teachers";
            dgv_teachers.ReadOnly = true;
            dgv_teachers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgv_teachers.RowHeadersWidth = 51;
            dgv_teachers.Size = new Size(971, 352);
            dgv_teachers.TabIndex = 70;
            dgv_teachers.RowHeaderMouseDoubleClick += dgv_teachers_RowHeaderMouseDoubleClick;
            // 
            // datepickerhiredate
            // 
            datepickerhiredate.Anchor = AnchorStyles.None;
            datepickerhiredate.CalendarForeColor = Color.Brown;
            datepickerhiredate.CalendarMonthBackground = Color.CornflowerBlue;
            datepickerhiredate.CalendarTitleBackColor = Color.CornflowerBlue;
            datepickerhiredate.CalendarTrailingForeColor = SystemColors.ButtonHighlight;
            datepickerhiredate.Location = new Point(226, 540);
            datepickerhiredate.Name = "datepickerhiredate";
            datepickerhiredate.Size = new Size(250, 27);
            datepickerhiredate.TabIndex = 94;
            datepickerhiredate.Value = new DateTime(2025, 2, 4, 0, 0, 0, 0);
            // 
            // datepickerbirthdate
            // 
            datepickerbirthdate.Anchor = AnchorStyles.None;
            datepickerbirthdate.CalendarForeColor = SystemColors.ButtonHighlight;
            datepickerbirthdate.CalendarMonthBackground = Color.CornflowerBlue;
            datepickerbirthdate.CalendarTitleBackColor = Color.CornflowerBlue;
            datepickerbirthdate.CalendarTrailingForeColor = SystemColors.ButtonHighlight;
            datepickerbirthdate.Location = new Point(235, 605);
            datepickerbirthdate.Name = "datepickerbirthdate";
            datepickerbirthdate.Size = new Size(250, 27);
            datepickerbirthdate.TabIndex = 95;
            datepickerbirthdate.Value = new DateTime(2025, 2, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label2.Location = new Point(79, 606);
            label2.Name = "label2";
            label2.Size = new Size(126, 26);
            label2.TabIndex = 96;
            label2.Text = "Birthdate";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(240, 478);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 97;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // searchtextbox
            // 
            searchtextbox.Anchor = AnchorStyles.None;
            searchtextbox.BackColor = SystemColors.InactiveCaptionText;
            searchtextbox.BorderStyle = BorderStyle.FixedSingle;
            searchtextbox.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            searchtextbox.ForeColor = Color.CornflowerBlue;
            searchtextbox.Location = new Point(1237, 68);
            searchtextbox.Margin = new Padding(3, 4, 3, 4);
            searchtextbox.Name = "searchtextbox";
            searchtextbox.Size = new Size(214, 31);
            searchtextbox.TabIndex = 98;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.None;
            btn_search.BackColor = Color.CornflowerBlue;
            btn_search.Cursor = Cursors.Hand;
            btn_search.FlatStyle = FlatStyle.Popup;
            btn_search.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_search.ForeColor = SystemColors.ButtonHighlight;
            btn_search.Location = new Point(956, 69);
            btn_search.Margin = new Padding(3, 4, 3, 4);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(163, 33);
            btn_search.TabIndex = 99;
            btn_search.Text = "search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // errorsubject
            // 
            errorsubject.AutoSize = true;
            errorsubject.ForeColor = Color.Red;
            errorsubject.Location = new Point(268, 509);
            errorsubject.Name = "errorsubject";
            errorsubject.Size = new Size(92, 20);
            errorsubject.TabIndex = 100;
            errorsubject.Tag = "error";
            errorsubject.Text = "invalid value";
            errorsubject.Visible = false;
            // 
            // btnadd
            // 
            btnadd.Anchor = AnchorStyles.None;
            btnadd.BackColor = Color.CornflowerBlue;
            btnadd.Cursor = Cursors.Hand;
            btnadd.FlatStyle = FlatStyle.Popup;
            btnadd.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.ForeColor = SystemColors.ButtonHighlight;
            btnadd.Location = new Point(42, 761);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(163, 33);
            btnadd.TabIndex = 101;
            btnadd.Text = "add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnupdate
            // 
            btnupdate.Anchor = AnchorStyles.None;
            btnupdate.BackColor = Color.CornflowerBlue;
            btnupdate.Cursor = Cursors.Hand;
            btnupdate.FlatStyle = FlatStyle.Popup;
            btnupdate.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnupdate.ForeColor = SystemColors.ButtonHighlight;
            btnupdate.Location = new Point(226, 761);
            btnupdate.Margin = new Padding(3, 4, 3, 4);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(163, 33);
            btnupdate.TabIndex = 102;
            btnupdate.Text = "update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Anchor = AnchorStyles.None;
            btndelete.BackColor = Color.CornflowerBlue;
            btndelete.Cursor = Cursors.Hand;
            btndelete.FlatStyle = FlatStyle.Popup;
            btndelete.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndelete.ForeColor = SystemColors.ButtonHighlight;
            btndelete.Location = new Point(409, 761);
            btndelete.Margin = new Padding(3, 4, 3, 4);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(163, 33);
            btndelete.TabIndex = 103;
            btndelete.Text = "delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // dgv_scheduleteacher
            // 
            dgv_scheduleteacher.Anchor = AnchorStyles.None;
            dgv_scheduleteacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_scheduleteacher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_scheduleteacher.BackgroundColor = Color.CornflowerBlue;
            dgv_scheduleteacher.BorderStyle = BorderStyle.Fixed3D;
            dgv_scheduleteacher.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgv_scheduleteacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_scheduleteacher.GridColor = Color.CornflowerBlue;
            dgv_scheduleteacher.Location = new Point(1110, 521);
            dgv_scheduleteacher.Name = "dgv_scheduleteacher";
            dgv_scheduleteacher.ReadOnly = true;
            dgv_scheduleteacher.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgv_scheduleteacher.RowHeadersWidth = 51;
            dgv_scheduleteacher.Size = new Size(603, 352);
            dgv_scheduleteacher.TabIndex = 105;
            dgv_scheduleteacher.RowHeaderMouseClick += dgv_scheduleteacher_RowHeaderMouseClick;
            // 
            // btndeletelesson
            // 
            btndeletelesson.Anchor = AnchorStyles.None;
            btndeletelesson.BackColor = Color.CornflowerBlue;
            btndeletelesson.Cursor = Cursors.Hand;
            btndeletelesson.FlatStyle = FlatStyle.Popup;
            btndeletelesson.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndeletelesson.ForeColor = SystemColors.ButtonHighlight;
            btndeletelesson.Location = new Point(775, 761);
            btndeletelesson.Margin = new Padding(3, 4, 3, 4);
            btndeletelesson.Name = "btndeletelesson";
            btndeletelesson.Size = new Size(234, 33);
            btndeletelesson.TabIndex = 107;
            btndeletelesson.Text = "delete lesson";
            btndeletelesson.UseVisualStyleBackColor = false;
            btndeletelesson.Click += btndeletelesson_Click;
            // 
            // btnaddseesion
            // 
            btnaddseesion.Anchor = AnchorStyles.None;
            btnaddseesion.BackColor = Color.CornflowerBlue;
            btnaddseesion.Cursor = Cursors.Hand;
            btnaddseesion.FlatStyle = FlatStyle.Popup;
            btnaddseesion.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnaddseesion.ForeColor = SystemColors.ButtonHighlight;
            btnaddseesion.Location = new Point(775, 698);
            btnaddseesion.Margin = new Padding(3, 4, 3, 4);
            btnaddseesion.Name = "btnaddseesion";
            btnaddseesion.Size = new Size(234, 33);
            btnaddseesion.TabIndex = 108;
            btnaddseesion.Text = "add lesson";
            btnaddseesion.UseVisualStyleBackColor = false;
            btnaddseesion.Click += btnaddseesion_Click;
            // 
            // datapickerlessondate
            // 
            datapickerlessondate.Anchor = AnchorStyles.None;
            datapickerlessondate.CalendarForeColor = Color.Brown;
            datapickerlessondate.CalendarMonthBackground = Color.CornflowerBlue;
            datapickerlessondate.CalendarTitleBackColor = Color.CornflowerBlue;
            datapickerlessondate.CalendarTrailingForeColor = SystemColors.ButtonHighlight;
            datapickerlessondate.Location = new Point(775, 540);
            datapickerlessondate.Name = "datapickerlessondate";
            datapickerlessondate.Size = new Size(270, 27);
            datapickerlessondate.TabIndex = 109;
            datapickerlessondate.Value = new DateTime(2025, 2, 4, 0, 0, 0, 0);
            // 
            // comboboxclasses
            // 
            comboboxclasses.FormattingEnabled = true;
            comboboxclasses.Location = new Point(775, 590);
            comboboxclasses.Name = "comboboxclasses";
            comboboxclasses.Size = new Size(151, 28);
            comboboxclasses.TabIndex = 110;
            // 
            // comboboxlessons
            // 
            comboboxlessons.FormattingEnabled = true;
            comboboxlessons.Location = new Point(775, 643);
            comboboxlessons.Name = "comboboxlessons";
            comboboxlessons.Size = new Size(151, 28);
            comboboxlessons.TabIndex = 111;
            // 
            // btnrefresh
            // 
            btnrefresh.Anchor = AnchorStyles.None;
            btnrefresh.BackColor = Color.CornflowerBlue;
            btnrefresh.Cursor = Cursors.Hand;
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Font = new Font("Ravie", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnrefresh.ForeColor = SystemColors.ButtonHighlight;
            btnrefresh.Location = new Point(201, 33);
            btnrefresh.Margin = new Padding(3, 4, 3, 4);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(48, 33);
            btnrefresh.TabIndex = 112;
            btnrefresh.Text = "r";
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // ManageTeachechrs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1791, 885);
            Controls.Add(btnrefresh);
            Controls.Add(comboboxlessons);
            Controls.Add(comboboxclasses);
            Controls.Add(datapickerlessondate);
            Controls.Add(btnaddseesion);
            Controls.Add(btndeletelesson);
            Controls.Add(dgv_scheduleteacher);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(errorsubject);
            Controls.Add(btn_search);
            Controls.Add(searchtextbox);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(datepickerbirthdate);
            Controls.Add(datepickerhiredate);
            Controls.Add(errorgender);
            Controls.Add(errorphone);
            Controls.Add(errormail);
            Controls.Add(errorlname);
            Controls.Add(errorfname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(mail);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(txt_phone);
            Controls.Add(txt_mail);
            Controls.Add(txt_lastname);
            Controls.Add(txt_fname);
            Controls.Add(dgv_teachers);
            Controls.Add(btndash);
            Controls.Add(btnsignout);
            Controls.Add(close_btn);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageTeachechrs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageTeachechrs";
            Load += ManageTeachechrs_LoadAsync;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_teachers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_scheduleteacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close_btn;
        private Button btnsignout;
        private Button btndash;
        private Label errorgender;
        private Label errorphone;
        private Label errormail;
        private Label errorlname;
        private Label errorfname;
        private Label label6;
        private Label label5;
        private Label mail;
        private Label lname;
        private Label fname;
        private Label label1;
        private Panel panel2;
        private RadioButton rfemale;
        private RadioButton rmale;
        private RadioButton rb_female;
        private RadioButton rb_male;
        private Label label10;
        private TextBox txt_phone;
        private TextBox txt_mail;
        private TextBox txt_lastname;
        private TextBox txt_fname;
        private DataGridView dgv_teachers;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker datepickerhiredate;
        private DateTimePicker datepickerbirthdate;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox searchtextbox;
        private Button btn_search;
        private Label errorsubject;
        private Button btnadd;
        private Button btnupdate;
        private Button btndelete;
        private DataGridView dgv_scheduleteacher;
        private Button btndeletelesson;
        private Button btnaddseesion;
        private DateTimePicker datapickerlessondate;
        private ComboBox comboboxclasses;
        private ComboBox comboboxlessons;
        private Button btnrefresh;
    }
}
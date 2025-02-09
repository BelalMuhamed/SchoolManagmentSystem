namespace School
{
    partial class TeacherManageDegree
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
            button1 = new Button();
            btnsignout = new Button();
            dgv_degrees = new DataGridView();
            comboBox1 = new ComboBox();
            btn_Schedule = new Button();
            label2 = new Label();
            degreeadded = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            stdegree = new Label();
            stname = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_degrees).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1732, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(38, 34);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.TextAlign = ContentAlignment.BottomLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnsignout
            // 
            btnsignout.Anchor = AnchorStyles.None;
            btnsignout.BackColor = Color.CornflowerBlue;
            btnsignout.Cursor = Cursors.Hand;
            btnsignout.FlatStyle = FlatStyle.Flat;
            btnsignout.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignout.ForeColor = Color.DarkRed;
            btnsignout.Location = new Point(1659, 55);
            btnsignout.Margin = new Padding(3, 4, 3, 4);
            btnsignout.Name = "btnsignout";
            btnsignout.Size = new Size(120, 34);
            btnsignout.TabIndex = 32;
            btnsignout.Text = "sign out ";
            btnsignout.UseVisualStyleBackColor = false;
            btnsignout.Click += btnsignout_Click;
            // 
            // dgv_degrees
            // 
            dgv_degrees.Anchor = AnchorStyles.None;
            dgv_degrees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_degrees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_degrees.BackgroundColor = Color.CornflowerBlue;
            dgv_degrees.BorderStyle = BorderStyle.Fixed3D;
            dgv_degrees.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgv_degrees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_degrees.GridColor = Color.CornflowerBlue;
            dgv_degrees.Location = new Point(385, 454);
            dgv_degrees.Name = "dgv_degrees";
            dgv_degrees.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgv_degrees.RowHeadersWidth = 51;
            dgv_degrees.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_degrees.Size = new Size(968, 377);
            dgv_degrees.TabIndex = 33;
            dgv_degrees.RowHeaderMouseClick += dgv_degrees_RowHeaderMouseClick;
            dgv_degrees.SelectionChanged += dgv_degrees_SelectionChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.InfoText;
            comboBox1.ForeColor = Color.CornflowerBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(717, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 28);
            comboBox1.TabIndex = 35;
            // 
            // btn_Schedule
            // 
            btn_Schedule.Anchor = AnchorStyles.None;
            btn_Schedule.BackColor = Color.CornflowerBlue;
            btn_Schedule.Cursor = Cursors.Hand;
            btn_Schedule.FlatStyle = FlatStyle.Popup;
            btn_Schedule.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Schedule.ForeColor = SystemColors.ButtonHighlight;
            btn_Schedule.Location = new Point(656, 295);
            btn_Schedule.Margin = new Padding(3, 4, 3, 4);
            btn_Schedule.Name = "btn_Schedule";
            btn_Schedule.Size = new Size(401, 33);
            btn_Schedule.TabIndex = 37;
            btn_Schedule.Text = "Show students ";
            btn_Schedule.UseVisualStyleBackColor = false;
            btn_Schedule.Click += btn_Schedule_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label2.Location = new Point(608, 174);
            label2.Name = "label2";
            label2.Size = new Size(67, 26);
            label2.TabIndex = 38;
            label2.Text = "Class";
            // 
            // degreeadded
            // 
            degreeadded.Anchor = AnchorStyles.None;
            degreeadded.BackColor = SystemColors.InactiveCaptionText;
            degreeadded.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            degreeadded.ForeColor = Color.AliceBlue;
            degreeadded.Location = new Point(53, 132);
            degreeadded.Margin = new Padding(3, 4, 3, 4);
            degreeadded.Name = "degreeadded";
            degreeadded.Size = new Size(229, 31);
            degreeadded.TabIndex = 39;
            degreeadded.KeyPress += degreeadded_KeyPress;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(stdegree);
            panel1.Controls.Add(stname);
            panel1.Controls.Add(degreeadded);
            panel1.Location = new Point(32, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 226);
            panel1.TabIndex = 40;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.CornflowerBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(32, 171);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(277, 33);
            button2.TabIndex = 42;
            button2.Text = "Add Degree";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // stdegree
            // 
            stdegree.Anchor = AnchorStyles.None;
            stdegree.AutoSize = true;
            stdegree.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            stdegree.Location = new Point(39, 72);
            stdegree.Name = "stdegree";
            stdegree.Size = new Size(0, 26);
            stdegree.TabIndex = 41;
            // 
            // stname
            // 
            stname.Anchor = AnchorStyles.None;
            stname.AutoSize = true;
            stname.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            stname.Location = new Point(53, 24);
            stname.Name = "stname";
            stname.Size = new Size(0, 26);
            stname.TabIndex = 40;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.CornflowerBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(32, 839);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(163, 33);
            button3.TabIndex = 43;
            button3.Text = "Dash Board";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TeacherManageDegree
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1791, 885);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btn_Schedule);
            Controls.Add(comboBox1);
            Controls.Add(dgv_degrees);
            Controls.Add(btnsignout);
            Controls.Add(button1);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeacherManageDegree";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherManageDegree";
            Load += TeacherManageDegree_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_degrees).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnsignout;
        private DataGridView dgv_degrees;
        private ComboBox comboBox1;
        private Button btn_Schedule;
        private Label label2;
        private TextBox degreeadded;
        private Panel panel1;
        private Button button2;
        private Label stdegree;
        private Label stname;
        private Button button3;
    }
}
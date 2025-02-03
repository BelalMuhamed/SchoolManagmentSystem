namespace School
{

    partial class LoginForm
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
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label2 = new Label();
            txt_mail = new TextBox();
            txt_pass = new TextBox();
            Btn_Close = new Button();
            close_btn = new Button();
            errorLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(603, 94);
            label1.Name = "label1";
            label1.Size = new Size(163, 50);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label3.Location = new Point(394, 367);
            label3.Name = "label3";
            label3.Size = new Size(122, 26);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(702, 472);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.ControlText;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Gold;
            button2.Location = new Point(855, 585);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Sign Up !";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Rage Italic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(626, 589);
            label4.Name = "label4";
            label4.Size = new Size(238, 25);
            label4.TabIndex = 7;
            label4.Text = "If you don't have account ..";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic);
            label2.Location = new Point(394, 282);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 1;
            label2.Text = "E-Mail";
            // 
            // txt_mail
            // 
            txt_mail.Anchor = AnchorStyles.None;
            txt_mail.BackColor = SystemColors.InactiveCaptionText;
            txt_mail.BorderStyle = BorderStyle.FixedSingle;
            txt_mail.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_mail.ForeColor = Color.CornflowerBlue;
            txt_mail.Location = new Point(585, 273);
            txt_mail.Margin = new Padding(3, 4, 3, 4);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(405, 31);
            txt_mail.TabIndex = 8;
            txt_mail.TextChanged += txt_mail_TextChanged;
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.BackColor = SystemColors.InactiveCaptionText;
            txt_pass.BorderStyle = BorderStyle.FixedSingle;
            txt_pass.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold);
            txt_pass.ForeColor = Color.CornflowerBlue;
            txt_pass.Location = new Point(585, 358);
            txt_pass.Margin = new Padding(3, 4, 3, 4);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(405, 31);
            txt_pass.TabIndex = 9;
            // 
            // Btn_Close
            // 
            Btn_Close.Anchor = AnchorStyles.None;
            Btn_Close.AutoSize = true;
            Btn_Close.BackColor = Color.CornflowerBlue;
            Btn_Close.Cursor = Cursors.Hand;
            Btn_Close.FlatStyle = FlatStyle.Flat;
            Btn_Close.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Close.ForeColor = SystemColors.ActiveCaptionText;
            Btn_Close.Location = new Point(1503, 2);
            Btn_Close.Margin = new Padding(3, 4, 3, 4);
            Btn_Close.Name = "Btn_Close";
            Btn_Close.Size = new Size(38, 35);
            Btn_Close.TabIndex = 10;
            Btn_Close.Text = "X";
            Btn_Close.UseVisualStyleBackColor = false;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.None;
            close_btn.BackColor = Color.CornflowerBlue;
            close_btn.Cursor = Cursors.Hand;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_btn.ForeColor = SystemColors.ActiveCaptionText;
            close_btn.Location = new Point(1317, 25);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(34, 33);
            close_btn.TabIndex = 11;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.ForeColor = Color.Red;
            errorLbl.Location = new Point(651, 416);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(179, 20);
            errorLbl.TabIndex = 12;
            errorLbl.Text = "invalid email or password";
            errorLbl.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1394, 779);
            Controls.Add(errorLbl);
            Controls.Add(close_btn);
            Controls.Add(Btn_Close);
            Controls.Add(txt_pass);
            Controls.Add(txt_mail);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label2;
        private TextBox txt_mail;
        private TextBox txt_pass;
        private Button Btn_Close;
        private Button close_btn;
        private Label errorLbl;
    }
}
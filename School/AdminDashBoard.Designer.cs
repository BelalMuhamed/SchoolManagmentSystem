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
            welcome = new Label();
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
            // 
            // welcomee
            // 
            welcomee.Anchor = AnchorStyles.None;
            welcomee.AutoSize = true;
            welcomee.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcomee.Location = new Point(54, 75);
            welcomee.Name = "welcomee";
            welcomee.Size = new Size(0, 50);
            welcomee.TabIndex = 34;
            // 
            // welcome
            // 
            welcome.Anchor = AnchorStyles.None;
            welcome.AutoSize = true;
            welcome.Location = new Point(54, 30);
            welcome.Name = "welcome";
            welcome.Size = new Size(0, 20);
            welcome.TabIndex = 33;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1791, 885);
            Controls.Add(welcomee);
            Controls.Add(welcome);
            Controls.Add(btnsignout);
            Controls.Add(btnClose);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnsignout;
        private Label welcomee;
        private Label welcome;
    }
}
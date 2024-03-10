using System.Windows.Forms;

namespace Project.Client.UserControls
{
    partial class UCAggregationExample2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentBox = new System.Windows.Forms.GroupBox();
            this.enrollmentYearLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.universityMemberBox = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.studentBox.SuspendLayout();
            this.universityMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentBox
            // 
            this.studentBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.studentBox.Controls.Add(this.enrollmentYearLabel);
            this.studentBox.Controls.Add(this.majorLabel);
            this.studentBox.Controls.Add(this.universityMemberBox);
            this.studentBox.Location = new System.Drawing.Point(317, 144);
            this.studentBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentBox.Name = "studentBox";
            this.studentBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentBox.Size = new System.Drawing.Size(271, 234);
            this.studentBox.TabIndex = 4;
            this.studentBox.TabStop = false;
            this.studentBox.Text = "Student";
            // 
            // enrollmentYearLabel
            // 
            this.enrollmentYearLabel.AutoSize = true;
            this.enrollmentYearLabel.ForeColor = System.Drawing.Color.Black;
            this.enrollmentYearLabel.Location = new System.Drawing.Point(9, 52);
            this.enrollmentYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enrollmentYearLabel.Name = "enrollmentYearLabel";
            this.enrollmentYearLabel.Size = new System.Drawing.Size(113, 17);
            this.enrollmentYearLabel.TabIndex = 2;
            this.enrollmentYearLabel.Text = "Enrollment Year:";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(9, 25);
            this.majorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(47, 17);
            this.majorLabel.TabIndex = 1;
            this.majorLabel.Text = "Major:";
            // 
            // universityMemberBox
            // 
            this.universityMemberBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.universityMemberBox.Controls.Add(this.emailLabel);
            this.universityMemberBox.Controls.Add(this.nameLabel);
            this.universityMemberBox.Controls.Add(this.memberIDLabel);
            this.universityMemberBox.Location = new System.Drawing.Point(8, 82);
            this.universityMemberBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.universityMemberBox.Name = "universityMemberBox";
            this.universityMemberBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.universityMemberBox.Size = new System.Drawing.Size(251, 121);
            this.universityMemberBox.TabIndex = 0;
            this.universityMemberBox.TabStop = false;
            this.universityMemberBox.Text = "University Member";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(8, 87);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 59);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Location = new System.Drawing.Point(8, 32);
            this.memberIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(80, 17);
            this.memberIDLabel.TabIndex = 1;
            this.memberIDLabel.Text = "Member ID:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(316, 404);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 46);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous student";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(488, 404);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 46);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next student";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // UCAggregationExample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.studentBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCAggregationExample2";
            this.Size = new System.Drawing.Size(1183, 652);
            this.studentBox.ResumeLayout(false);
            this.studentBox.PerformLayout();
            this.universityMemberBox.ResumeLayout(false);
            this.universityMemberBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox studentBox;
        private System.Windows.Forms.Label enrollmentYearLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.GroupBox universityMemberBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;

        public GroupBox StudentBox { get => studentBox; set => studentBox = value; }
        public Label EnrollmentYearLabel { get => enrollmentYearLabel; set => enrollmentYearLabel = value; }
        public Label MajorLabel { get => majorLabel; set => majorLabel = value; }
        public GroupBox UniversityMemberBox { get => universityMemberBox; set => universityMemberBox = value; }
        public Label EmailLabel { get => emailLabel; set => emailLabel = value; }
        public Label NameLabel { get => nameLabel; set => nameLabel = value; }
        public Label MemberIDLabel { get => memberIDLabel; set => memberIDLabel = value; }
        public Button BtnPrevious { get => btnPrevious; set => btnPrevious = value; }
        public Button BtnNext { get => btnNext; set => btnNext = value; }
    }
}

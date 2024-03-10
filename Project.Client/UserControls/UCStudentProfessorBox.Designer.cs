using System.Windows.Forms;

namespace Project.Client.UserControls
{
    partial class UCStudentProfessorBox
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
            this.researchAreaLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.enrollmentYearLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.universityMemberBox = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.studentBox.SuspendLayout();
            this.universityMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentBox
            // 
            this.studentBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.studentBox.Controls.Add(this.researchAreaLabel);
            this.studentBox.Controls.Add(this.departmentLabel);
            this.studentBox.Controls.Add(this.enrollmentYearLabel);
            this.studentBox.Controls.Add(this.majorLabel);
            this.studentBox.Controls.Add(this.universityMemberBox);
            this.studentBox.Location = new System.Drawing.Point(40, 83);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(200, 223);
            this.studentBox.TabIndex = 4;
            this.studentBox.TabStop = false;
            this.studentBox.Text = "Student and Professor";
            // 
            // researchAreaLabel
            // 
            this.researchAreaLabel.AutoSize = true;
            this.researchAreaLabel.Location = new System.Drawing.Point(7, 88);
            this.researchAreaLabel.Name = "researchAreaLabel";
            this.researchAreaLabel.Size = new System.Drawing.Size(81, 13);
            this.researchAreaLabel.TabIndex = 4;
            this.researchAreaLabel.Text = "Research Area:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(7, 66);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(65, 13);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Department:";
            // 
            // enrollmentYearLabel
            // 
            this.enrollmentYearLabel.AutoSize = true;
            this.enrollmentYearLabel.ForeColor = System.Drawing.Color.Black;
            this.enrollmentYearLabel.Location = new System.Drawing.Point(7, 42);
            this.enrollmentYearLabel.Name = "enrollmentYearLabel";
            this.enrollmentYearLabel.Size = new System.Drawing.Size(84, 13);
            this.enrollmentYearLabel.TabIndex = 2;
            this.enrollmentYearLabel.Text = "Enrollment Year:";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(7, 20);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(36, 13);
            this.majorLabel.TabIndex = 1;
            this.majorLabel.Text = "Major:";
            // 
            // universityMemberBox
            // 
            this.universityMemberBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.universityMemberBox.Controls.Add(this.emailLabel);
            this.universityMemberBox.Controls.Add(this.nameLabel);
            this.universityMemberBox.Controls.Add(this.memberIDLabel);
            this.universityMemberBox.Location = new System.Drawing.Point(6, 119);
            this.universityMemberBox.Name = "universityMemberBox";
            this.universityMemberBox.Size = new System.Drawing.Size(188, 98);
            this.universityMemberBox.TabIndex = 0;
            this.universityMemberBox.TabStop = false;
            this.universityMemberBox.Text = "University Member";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 71);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Location = new System.Drawing.Point(6, 26);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(62, 13);
            this.memberIDLabel.TabIndex = 1;
            this.memberIDLabel.Text = "Member ID:";
            // 
            // UCStudentProfessorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.studentBox);
            this.Name = "UCStudentProfessorBox";
            this.Size = new System.Drawing.Size(281, 439);
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
        private System.Windows.Forms.Label researchAreaLabel;
        private System.Windows.Forms.Label departmentLabel;

        public GroupBox StudentBox { get => studentBox; set => studentBox = value; }
        public Label EnrollmentYearLabel { get => enrollmentYearLabel; set => enrollmentYearLabel = value; }
        public Label MajorLabel { get => majorLabel; set => majorLabel = value; }
        public GroupBox UniversityMemberBox { get => universityMemberBox; set => universityMemberBox = value; }
        public Label EmailLabel { get => emailLabel; set => emailLabel = value; }
        public Label NameLabel { get => nameLabel; set => nameLabel = value; }
        public Label MemberIDLabel { get => memberIDLabel; set => memberIDLabel = value; }
        public Label ResearchAreaLabel { get => researchAreaLabel; set => researchAreaLabel = value; }
        public Label DepartmentLabel { get => departmentLabel; set => departmentLabel = value; }
    }
}

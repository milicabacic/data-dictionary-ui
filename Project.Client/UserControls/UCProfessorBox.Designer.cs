using System.Windows.Forms;

namespace Project.Client.UserControls
{
    partial class UCProfessorBox
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
            this.ProfessorBox = new System.Windows.Forms.GroupBox();
            this.researchAreaLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.UniversityMemberBox = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.ProfessorBox.SuspendLayout();
            this.UniversityMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfessorBox
            // 
            this.ProfessorBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ProfessorBox.Controls.Add(this.researchAreaLabel);
            this.ProfessorBox.Controls.Add(this.departmentLabel);
            this.ProfessorBox.Controls.Add(this.UniversityMemberBox);
            this.ProfessorBox.Location = new System.Drawing.Point(41, 123);
            this.ProfessorBox.Name = "ProfessorBox";
            this.ProfessorBox.Size = new System.Drawing.Size(200, 173);
            this.ProfessorBox.TabIndex = 2;
            this.ProfessorBox.TabStop = false;
            this.ProfessorBox.Text = "Professor";
            // 
            // researchAreaLabel
            // 
            this.researchAreaLabel.AutoSize = true;
            this.researchAreaLabel.Location = new System.Drawing.Point(7, 42);
            this.researchAreaLabel.Name = "researchAreaLabel";
            this.researchAreaLabel.Size = new System.Drawing.Size(81, 13);
            this.researchAreaLabel.TabIndex = 2;
            this.researchAreaLabel.Text = "Research Area:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(7, 20);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(65, 13);
            this.departmentLabel.TabIndex = 1;
            this.departmentLabel.Text = "Department:";
            // 
            // UniversityMemberBox
            // 
            this.UniversityMemberBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UniversityMemberBox.Controls.Add(this.emailLabel);
            this.UniversityMemberBox.Controls.Add(this.nameLabel);
            this.UniversityMemberBox.Controls.Add(this.memberIDLabel);
            this.UniversityMemberBox.Location = new System.Drawing.Point(6, 67);
            this.UniversityMemberBox.Name = "UniversityMemberBox";
            this.UniversityMemberBox.Size = new System.Drawing.Size(188, 98);
            this.UniversityMemberBox.TabIndex = 0;
            this.UniversityMemberBox.TabStop = false;
            this.UniversityMemberBox.Text = "University Member";
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
            // UCProfessorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProfessorBox);
            this.Name = "UCProfessorBox";
            this.Size = new System.Drawing.Size(281, 439);
            this.ProfessorBox.ResumeLayout(false);
            this.ProfessorBox.PerformLayout();
            this.UniversityMemberBox.ResumeLayout(false);
            this.UniversityMemberBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProfessorBox;
        private System.Windows.Forms.GroupBox UniversityMemberBox;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label researchAreaLabel;

        public GroupBox ProfessorBox1 { get => ProfessorBox; set => ProfessorBox = value; }
        public GroupBox UniversityMemberBox1 { get => UniversityMemberBox; set => UniversityMemberBox = value; }
        public Label MemberIDLabel { get => memberIDLabel; set => memberIDLabel = value; }
        public Label NameLabel { get => nameLabel; set => nameLabel = value; }
        public Label EmailLabel { get => emailLabel; set => emailLabel = value; }
        public Label DepartmentLabel { get => departmentLabel; set => departmentLabel = value; }
        public Label ResearchAreaLabel { get => researchAreaLabel; set => researchAreaLabel = value; }
    }
}

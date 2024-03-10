using Domain;
using Project.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Client.GUIController
{
    internal class StudentProfessorBoxController
    {
        private UCStudentProfessorBox _userControl;
        public StudentProfessorBoxController(UCStudentProfessorBox userControl)
        {
            _userControl = userControl;
        }

        internal void LoadStudentProfessor(UniversityMember member, Student student, Professor professor)
        {
            _userControl.MemberIDLabel.Text += member.MemberID;
            _userControl.MajorLabel.Text += student.Major;
            _userControl.NameLabel.Text += member.Name;
            _userControl.EmailLabel.Text += member.Email;
            _userControl.DepartmentLabel.Text += professor.Department;
            _userControl.ResearchAreaLabel.Text += professor.ResearchArea;
            _userControl.EnrollmentYearLabel.Text += student.EnrollmentYear;
        }
    }
}

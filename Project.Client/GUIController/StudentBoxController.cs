using Domain;
using Project.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Client.GUIController
{
    public class StudentBoxController
    {
        private UCStudentBox _userControl;
        public StudentBoxController(UCStudentBox userControl)
        {
            _userControl = userControl;
        }

        public void LoadStudent(UniversityMember member, Student student)
        {
            _userControl.MemberIDLabel.Text += member.MemberID;
            _userControl.MajorLabel.Text += student.Major;
            _userControl.NameLabel.Text += member.Name;
            _userControl.EmailLabel.Text += member.Email;
            _userControl.EnrollmentYearLabel.Text += student.EnrollmentYear;
        }
    }
}

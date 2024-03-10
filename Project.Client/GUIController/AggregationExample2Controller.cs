using Common;
using Domain;
using Project.Client.ServerCommunication;
using Project.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Client.GUIController
{
    public class AggregationExample2Controller
    {
        private UCAggregationExample2 _userControl;
        private List<UniversityMember> _universityMembers = new List<UniversityMember>();
        private int index = 0;

        public AggregationExample2Controller(UCAggregationExample2 userControl)
        {
            _userControl = userControl;
            LoadMembers();
            LoadMember();
        }

        public void LoadMembers()
        {
            List<UniversityMember> members = Communication.Instance.SendRequestGetResponse<List<UniversityMember>>(Operation.GET_UNIVERSITY_MEMBERS);
            foreach (UniversityMember member in members)
            {
                if (member.Student == null) continue;
                _universityMembers.Add(member); 
            }
        }

        public void LoadMember()
        {
            UniversityMember member = _universityMembers[index];
            Student student = Communication.Instance.SendRequestGetResponse<Student>(
                Operation.GET_STUDENT, 
                new Student() { ID = (int)member.Student}
            );
            LoadStudent(member, student);
        }

        public void LoadStudent(UniversityMember member, Student student)
        {
            _userControl.MemberIDLabel.Text = "ID: " + member.MemberID;
            _userControl.MajorLabel.Text = "Major: " + student.Major;
            _userControl.NameLabel.Text = "Name: " + member.Name;
            _userControl.EmailLabel.Text = "Email: " + member.Email;
            _userControl.EnrollmentYearLabel.Text = "Enrollment Year: " + student.EnrollmentYear;
        }

        public void LoadNextMember()
        {
            if (index == _universityMembers.Count - 1)
            {
                index = 0;
            }
            else index++;
            LoadMember();
        }

        public void LoadPreviousMember()
        {
            if (index <= 0)
            {
                index = _universityMembers.Count - 1;
            }
            else index--;
            LoadMember();
        }
    }
}

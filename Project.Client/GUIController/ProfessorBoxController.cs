using Domain;
using Project.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Client.GUIController
{
    public class ProfessorBoxController
    {
        private UCProfessorBox _userControl;
        public ProfessorBoxController(UCProfessorBox userControl)
        {
            _userControl = userControl;
        }

        internal void LoadProfessor(UniversityMember member, Professor professor)
        {
            _userControl.MemberIDLabel.Text += member.MemberID;
            _userControl.EmailLabel.Text += member.Email;
            _userControl.NameLabel.Text += member.Name;
            _userControl.DepartmentLabel.Text += professor.Department;
            _userControl.ResearchAreaLabel.Text += professor.ResearchArea;
        }
    }
}

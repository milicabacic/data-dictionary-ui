using Domain;
using Project.Client.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.UserControls
{
    public partial class UCStudentProfessorBox : UserControl
    {
        private StudentProfessorBoxController _controller;
        public UCStudentProfessorBox(UniversityMember member, Student student, Professor professor)
        {
            InitializeComponent();
            _controller = new StudentProfessorBoxController(this);
            _controller.LoadStudentProfessor(member, student, professor);
        }

    }
}

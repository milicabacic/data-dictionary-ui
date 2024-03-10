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
    public partial class UCStudentBox : UserControl
    {
        private StudentBoxController _controller;
        public UCStudentBox(UniversityMember member, Student student)
        {
            InitializeComponent();
            _controller = new StudentBoxController(this);
            _controller.LoadStudent(member, student);
        }
    }
}

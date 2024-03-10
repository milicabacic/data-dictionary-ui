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
    public partial class UCProfessorBox : UserControl
    {
        private ProfessorBoxController _controller;

        public UCProfessorBox(UniversityMember member, Professor professor)
        {
            InitializeComponent();
            _controller = new ProfessorBoxController(this);
            _controller.LoadProfessor(member, professor);
        }

    }
}

using Domain;
using Project.Client.GUIController;
using Project.Client.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project.Client.UserControls
{
    public partial class UCSpecializationExample1 : UserControl
    {
        private SpecializationExample1Controller _controller;

        public UCSpecializationExample1()
        {
            InitializeComponent();
            _controller = new SpecializationExample1Controller(this);
        }

        private void ChangeUserControl(UserControl userControl)
        {
            rightPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            rightPanel.Controls.Add(userControl);
        }

        private void tableView_SelectionChanged(object sender, EventArgs e)
        {
            UserControl memberUserControl = _controller.GetMemberUserControl();
            if (memberUserControl == null) return;
            ChangeUserControl(memberUserControl);
        }
    }
}

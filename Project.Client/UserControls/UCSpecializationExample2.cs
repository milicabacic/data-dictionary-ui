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
    public partial class UCSpecializationExample2 : UserControl
    {
        private SpecializationExample2Controller _controller;
        public UCSpecializationExample2()
        {
            InitializeComponent();
            _controller = new SpecializationExample2Controller(this);
        }

        private void animalSpeciesTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _controller.GetAnimalsFromSelectedNode();
        }
    }
}

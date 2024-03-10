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
    public partial class UCAggregationExample2 : UserControl
    {
        private AggregationExample2Controller _controller;
        public UCAggregationExample2()
        {
            InitializeComponent();
            _controller = new AggregationExample2Controller(this);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _controller.LoadPreviousMember();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _controller.LoadNextMember();
        }
    }
}

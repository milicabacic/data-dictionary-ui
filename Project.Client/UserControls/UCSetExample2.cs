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
    public partial class UCSetExample2 : UserControl
    {
        private SetExample2Controller _controller;
        public UCSetExample2()
        {
            InitializeComponent();
            _controller = new SetExample2Controller(this);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            _controller.AddItem();
        }
    }
}

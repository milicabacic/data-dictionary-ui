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
    public partial class UCSetExample1 : UserControl
    {
        private SetExample1Controller _controller;

        public UCSetExample1()
        {
            InitializeComponent();
            _controller = new SetExample1Controller(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.RegisterUser();
            _controller.LoadUsers();
        }

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}

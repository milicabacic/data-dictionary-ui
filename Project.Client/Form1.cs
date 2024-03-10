using Common;
using Domain;
using Client;
using Project.Client.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project.Client.UserControls;

namespace Project.Client
{
    public partial class Form1 : Form
    {
        private ConnectionController _communicationController;

        public Form1()
        {
            InitializeComponent();
            _communicationController = new ConnectionController();
        }

        private void ChangeUserControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _communicationController.Connect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           _communicationController.Disconnect();
        }

        private void example1AggregationToolStripItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCAggregationExample1());
        }

        private void example2AggregationToolStripItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCAggregationExample2());
        }

        private void example1SpecializationToolStripItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCSpecializationExample1());
        }

        private void example2SpecializationToolStripItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCSpecializationExample2());
        }

        private void example1SetToolStripItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCSetExample1());
        }

        private void example2SetToolStripItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(new UCSetExample2());
        }
    }
}

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
    public partial class UCAggregationExample1 : UserControl
    {
        private AggregationExample1Controller _controller;
        public UCAggregationExample1()
        {
            InitializeComponent();
            _controller = new AggregationExample1Controller(this);
        }
    }
}

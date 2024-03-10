using Common;
using Domain;
using Project.Client.ServerCommunication;
using Project.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Client.GUIController
{
    public class AggregationExample1Controller
    {
        private UCAggregationExample1 _userControll;
        public AggregationExample1Controller(UCAggregationExample1 userControll)
        {
            _userControll = userControll;
            LoadMembers();
        }

        public void LoadMembers()
        {
            List<UniversityMember> members = Communication.Instance.SendRequestGetResponse<List<UniversityMember>>(Operation.GET_UNIVERSITY_MEMBERS);
            _userControll.DataGridView1.DataSource = members;
        }
    }
}

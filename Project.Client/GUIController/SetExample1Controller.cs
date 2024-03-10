using Common;
using Domain;
using Exceptions;
using Project.Client.ServerCommunication;
using Project.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Client.GUIController
{
    public class SetExample1Controller
    {
        private UCSetExample1 _userControll;

        public SetExample1Controller(UCSetExample1 userControll)
        {
            _userControll = userControll;
            LoadUsers();
        }

        public void RegisterUser()
        {
            string username = _userControll.UsernameTextBox.Text;
            _userControll.UsernameTextBox.Text = "";
            User newUser = new User()
            {
                Username = username
            };
            try
            {
                Communication.Instance.SendRequestNoResponse(Operation.SAVE_USER, newUser);
                _userControll.DisplayMessage("Novi korisnik registrovan!");
            }
            catch (EntityDuplicateException e)
            {
                _userControll.DisplayMessage(e.Message);
            }
        }

        public void LoadUsers()
        {
            List<User> users = Communication.Instance.SendRequestGetResponse<List<User>>(Operation.GET_USERS);
            _userControll.UserGridView.DataSource = users;
        }
    }
}

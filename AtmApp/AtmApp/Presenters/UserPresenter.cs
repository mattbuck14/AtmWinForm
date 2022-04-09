using AtmApp.Service_Layers;
using AtmApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Presenters
{
    public class UserPresenter
    {
        public IUserView view;
        public UserPresenter(IUserView _view)
        {
            view = _view;
        }

        public void AddUser(Form form)
        {
            UserServiceLayer layer = new UserServiceLayer();
            try
            {
                if (view.FirstName.Equals("") || view.LastName.Equals(""))
                    throw new Exception("Please enter your full name to register.");
                layer.AddUser(view.FirstName, view.LastName, view.Birthday, form);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

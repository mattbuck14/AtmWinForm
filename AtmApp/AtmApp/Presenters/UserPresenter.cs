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
        private IUserView userView;
        private ISecurityView securityView;
        private Exception exception;
        public UserPresenter(IUserView _view, ISecurityView view)
        {
            userView = _view;
            securityView = view;    
        }

        private void SetException(string message)
        {
            exception = new Exception(message);
        }

        private int GetAge(DateTime bday)
        {
            var today = DateTime.Today;
            var age = today.Year - bday.Year;

            if (bday.Date > today.AddYears(-age)) age--;

            return age;
        }

        private bool IsValidInput(int age)
        {
            if (userView.FirstName.Equals("") || userView.LastName.Equals(""))
            {
                SetException("Please enter your full name to register.");
                return false;
            }
            if (age < 18)
            {
                SetException("Must be 18 or older to register an account.");
                return false;
            }
            if (securityView.Pin.Length != 4 || !int.TryParse(securityView.Pin, out _))
            {
                SetException("Please enter a 4 digit pin.");
                return false;
            }
            return true;
        } 

        public void AddUser(Form form)
        {
            UserServiceLayer layer = new UserServiceLayer();
            SecurityPresenter securityPresenter = new SecurityPresenter(securityView);
            int age = GetAge(userView.Birthday);

           // try
           // {
                if (!IsValidInput(age))
                    throw exception;
                layer.AddUser(userView.FirstName, userView.LastName, userView.Birthday, age);
                int userId = layer.GetCreatedUserId();
                securityPresenter.addSecurity(userId);
          //  }
            //catch (Exception ex)
           // {
            //    MessageBox.Show(ex.Message, "Inorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}

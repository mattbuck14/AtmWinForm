using AtmApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Presenters
{
    public class LoginPresenter
    {
        IAccountView accountView;
        ISecurityView securityView;
        private Exception exception;

        public LoginPresenter(){}
        public LoginPresenter(IAccountView aView, ISecurityView sView)
        {
            accountView = aView; 
            securityView = sView; 
        }

        private void SetException(string message)
        {
            exception = new Exception(message);
        }

        private bool ValidInput()
        {
            if (accountView.AccountNumber.Length != 8 || !int.TryParse(accountView.AccountNumber, out _))
            {
                SetException("Invalid Account Number.");
                return false;
            }
            if (securityView.Pin.Length != 4 || !int.TryParse(securityView.Pin, out _))
            {
                SetException("Invalid Pin Number.");
                return false;
            }
            return true;
        }

        public void OpenForm(Form form)
        {
            form.ShowDialog();
        }

        public void Login(Form form)
        {
            AccountPresenter accountPresenter = new AccountPresenter(accountView,securityView);
            try
            {
                if (!ValidInput())
                    throw exception;
                if (accountPresenter.RetrieveAccount())
                    OpenForm(form); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using AtmApp.Models;
using AtmApp.Service_Layers;
using AtmApp.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Presenters
{
    public class AccountPresenter
    {
        IAccountView accountView;
        ISecurityView securityView;
        Account account;

        public AccountPresenter()
        {
            account = new Account();
        }

        public AccountPresenter(IAccountView _view)
        {
            accountView = _view;
            account = new Account();
        }
        public AccountPresenter(IAccountView _view, ISecurityView __view)
        {
            accountView = _view;
            securityView = __view;
            account = new Account();
        }

        private bool MatchingPin(string enteredPin, string comparePin)
        {
            if (enteredPin.Equals(comparePin))
                return true;
            return false;
        }
        public void AddAccount(int userId)
        {
            AccountServiceLayer layer = new AccountServiceLayer();
            Random random = new Random();
            int routingNum = random.Next(100000000, 1000000000);
            layer.AddAccount(routingNum,userId);
        }

        public bool RetrieveAccount()
        {
            AccountServiceLayer layer = new AccountServiceLayer();
            account.AccountNumber = Int32.Parse(accountView.AccountNumber);

            try
            {
                object[] accountInfo = layer.RetrieveAccount(account.AccountNumber);
                if (accountInfo.Length == 0 || !MatchingPin((string)accountInfo[accountInfo.Length-1],securityView.Pin))
                    throw new Exception("Login Failed. Account doesn't exist or incorrect pin was entered.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}

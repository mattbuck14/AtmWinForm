using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Presenters
{
    public class LoginPresenter
    {
        public LoginPresenter()
        {

        }

        public void OpenForm(Form form)
        {
            form.ShowDialog();
        }
    }
}

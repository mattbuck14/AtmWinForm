using AtmApp.Service_Layers;
using AtmApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Presenters
{
    public class SecurityPresenter
    {
        private ISecurityView view;
        public SecurityPresenter(ISecurityView _view)
        {
            view = _view;
        }

        public void addSecurity(int userId)
        {
            SecurityServiceLayer layer = new SecurityServiceLayer();
            layer.AddSecurity(userId, view.Pin);
        }
    }
}

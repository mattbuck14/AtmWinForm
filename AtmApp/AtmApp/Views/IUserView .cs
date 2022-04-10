using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Views
{
    public interface IUserView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime Birthday { get; set; }
    }
}

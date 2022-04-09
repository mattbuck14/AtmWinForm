using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Views
{
    public interface IUserView
    {
        int UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime Birthday { get; set; }
        int Age { get; set; }
    }
}

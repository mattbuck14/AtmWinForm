using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.Views
{
    public  interface ISecurityView
    {
        int UserId { get; set; }
        string Pin { get; set; }
    }
}

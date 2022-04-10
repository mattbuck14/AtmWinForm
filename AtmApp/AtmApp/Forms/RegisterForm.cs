using AtmApp.Presenters;
using AtmApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmApp.Forms
{
    public partial class RegisterForm : Form, IUserView, ISecurityView
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public string FirstName 
        { 
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }
        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }
        public DateTime Birthday
        {
            get { return bdayDatePicker.Value; }
            set { bdayDatePicker.Value = value; }
        }

        public string Pin
        {
            get { return pinNumTextBox.Text; }
            set { pinNumTextBox.Text = value; }
        }

        private void sumbitBtn_Click(object sender, EventArgs e)
        {
            UserPresenter presenter = new UserPresenter(this, this);
            presenter.AddUser(this);
        }
    }
}

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
    public partial class RegisterForm : Form, IUserView
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
        public int UserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private void sumbitBtn_Click(object sender, EventArgs e)
        {
            UserPresenter presenter = new UserPresenter(this);
            presenter.AddUser(this);
        }
    }
}

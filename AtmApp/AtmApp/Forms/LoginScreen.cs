using AtmApp.Forms;
using AtmApp.Presenters;
using AtmApp.Views;

namespace AtmApp
{
    public partial class LoginScreen : Form, IAccountView, ISecurityView
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public string AccountNumber
        {
            get { return accountNumTextBox.Text; }
            set { accountNumTextBox.Text = value; }
        }
        public string Pin
        {
            get { return pinNumTextBox.Text; }
            set { pinNumTextBox.Text = value; }
        }
    

        #region
        public string RoutingNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CashBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime OpenedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        private void registerBtn_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter();
            RegisterForm form = new RegisterForm();
            presenter.OpenForm(form);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter(this, this);
            MainScreen form = new MainScreen();
            presenter.Login(form);
        }
    }
}
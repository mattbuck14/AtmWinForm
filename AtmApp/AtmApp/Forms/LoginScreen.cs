using AtmApp.Forms;
using AtmApp.Presenters;

namespace AtmApp
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            LoginPresenter presenter = new LoginPresenter();
            RegisterForm form = new RegisterForm();
            presenter.OpenForm(form);
        }
    }
}
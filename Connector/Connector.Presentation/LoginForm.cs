using Connector.Library.Models;
using Connector.Presentation.Services;
using MetroFramework.Forms;

namespace Connector.Presentation
{
    public partial class LoginForm : MetroForm
    {

        public LoginForm(User user, LoginLogic loginLogic)
        {
            this.user = user;
            this.loginLogic = loginLogic;
            InitializeComponent();
        }

        //

        private readonly User user;
        private readonly LoginLogic loginLogic;
    }
}

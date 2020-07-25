using Connector.Library.Models;
using Connector.Presentation.Extensions;
using Connector.Presentation.Services;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Connector.Presentation
{
    public partial class MainForm : MetroForm
    {
        public MainForm(MainLogic mainLogic)
        {
            InitializeComponent();

            this.mainLogic = mainLogic;
        }

        //

        private readonly MainLogic mainLogic;
        private IEnumerable<Control> TextBoxes => new[] { mTxtBoxEmail, mTxtBoxPassword };

        private string Email => mTxtBoxEmail.Text;
        private string Password => mTxtBoxPassword.Text;

        //

        private void MainForm_Load(object sender, EventArgs e) => mTileAbout.Focus();

        private void mTxtBoxEmail_Validated(object sender, EventArgs e)
        {
            var isValid = mainLogic.IsDomainValid(Email);
            if (isValid)
                return;

            this.DisplayInvalidDomainErrorMessage();
            TextBoxes.Reset();
        }

        private void mTxtBoxPassword_Validated(object sender, EventArgs e)
        {
            var isValid = mainLogic.IsPasswordValid(Password);
            if (isValid)
                return;

            this.DisplayInvalidPassword();
            TextBoxes.Reset();

        }

        private void mTileAbout_Click(object sender, EventArgs e) => this.DisplayAboutMessage();

        private void mTileRegister_Click(object sender, EventArgs e)
        {
            var isRegistered = mainLogic.IsRegistered(Email);
            if (!isRegistered)
            {
                var user = new User(Email, Password);
                mainLogic.Register(user);
                var registrationForm = new RegistrationForm(user, new RegistrationLogic());
                Hide();
                registrationForm.Show();
                return;
            }

            this.DisplayUserAlreadyRegistered();
            TextBoxes.Reset();
        }

        private void mTileLogIn_Click(object sender, EventArgs e)
        {
            var isRegistered = mainLogic.IsRegistered(Email);
            if (isRegistered)
            {
                var user = mainLogic.Login(Email, Password);
                var loginForm = new LoginForm(user, new LoginLogic());
                Hide();
                loginForm.Show();
                return;
            }

            this.DisplayUserIsNotRegistered();
            TextBoxes.Reset();
        }
    }
}

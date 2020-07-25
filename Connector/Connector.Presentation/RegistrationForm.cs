using Connector.Library.Models;
using Connector.Presentation.Extensions;
using Connector.Presentation.Services;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Connector.Presentation
{
    public partial class RegistrationForm : MetroForm
    {
        public RegistrationForm(User user, RegistrationLogic registrationLogic)
        {
            this.user = user;
            this.registrationLogic = registrationLogic;
            InitializeComponent();
        }

        //

        private readonly RegistrationLogic registrationLogic;
        private readonly User user;
        private UserDetail userDetail;

        private IEnumerable<Control> TextBoxes => new[] { mTxtFirstName, mTxtLastName };

        private void RegistrationForm_Load(object sender, EventArgs e) => TextBoxes.Reset();

        private void mTileAbout_Click(object sender, EventArgs e) => this.DisplayAboutMessage();


        private void mTileRegistration_Click(object sender, EventArgs e)
        {
            userDetail = new UserDetail(mTxtFirstName.Text, mTxtLastName.Text, user.Id, mchkAdmin.IsChecked());
            registrationLogic.Register(userDetail);

            var profileForm = new ProfileForm(userDetail, new ProfileLogic());
            Hide();
            profileForm.Show();
        }

        private void mTileCancel_Click(object sender, EventArgs e)
        {
            var result = this.DisplayExitMessage();
            if (result == "No")
            {
                Dispose();
                TextBoxes.Reset();
                var mainForm = new MainForm(new MainLogic());
                mainForm.Show();
                return;
            }

            TextBoxes.Reset();
            Application.ExitThread();
        }
    }
}

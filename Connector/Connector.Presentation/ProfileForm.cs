using Connector.Library.Models;
using Connector.Presentation.Services;
using MetroFramework.Forms;
using System;

namespace Connector.Presentation
{
    public partial class ProfileForm : MetroForm
    {
        public ProfileForm(UserDetail userDetail, ProfileLogic profileLogic)
        {
            InitializeComponent();

            this.userDetail = userDetail;
            this.profileLogic = profileLogic;
        }

        //

        private readonly UserDetail userDetail;
        private readonly ProfileLogic profileLogic;



        //



        private void ProfileForm_Load(object sender, EventArgs e)
        {
            mCmbGender.DataSource = profileLogic.Genders;

            mCmbCurrentCity.DataSource = profileLogic.GetCitiesNTowns();
            mCmbHometown.DataSource = profileLogic.GetCitiesNTowns();

            mCmbSchool.DataSource = profileLogic.GetSchools();
            mCmbEmployer.DataSource = profileLogic.GetEmployers();

            grpProfile.Text = $@"{userDetail.FirstName},{userDetail.LastName}";
        }

        private void mTileSaveProfile_Click(object sender, EventArgs e)
        {
            var professional = new Professional(userDetail.Id, mCmbEmployer.SelectedItem + "", mTxtJobTitle.Text);

            var educational = new Educational(userDetail.Id, mCmbSchool.SelectedItem + "", int.Parse(mTxtYearGraduated.Text));

            var interests = new[] { mCmbInterests.SelectedItem + "" };

            var userProfile = new UserProfile(
                userDetail.Id,
                char.Parse(mCmbGender.SelectedItem.ToString()),
                mDateTimeBirthdate.Value,
                mCmbCurrentCity.SelectedItem.ToString(),
                mCmbHometown.SelectedItem.ToString(),
                interests);

            profileLogic.Register(educational);
            profileLogic.Register(professional);
            profileLogic.Register(userProfile);
        }
    }
}

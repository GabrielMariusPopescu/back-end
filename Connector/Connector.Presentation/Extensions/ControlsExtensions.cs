using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Connector.Presentation.Extensions
{
    public static class ControlsExtensions
    {
        public static void DisplayAboutMessage(this MetroForm form) =>
            MetroMessageBox.Show(form, Constants.MAIN_MESSAGE, Constants.ABOUT, MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static void DisplayInvalidDomainErrorMessage(this MetroForm form) =>
            DisplayMessage(form, Constants.INVALID_EMAIL_DOMAIN, Constants.ERROR);

        public static void DisplayInvalidPassword(this MetroForm form) =>
            DisplayMessage(form, Constants.INVALID_PASSWORD, Constants.ERROR);

        public static void DisplayUserAlreadyRegistered(this MetroForm form) =>
            DisplayMessage(form, Constants.USER_ALREADY_REGISTERED, Constants.ERROR);

        public static void DisplayUserIsNotRegistered(this MetroForm form) =>
            DisplayMessage(form, Constants.USER_NOT_REGISTERED, Constants.ERROR);


        public static string DisplayExitMessage(this MetroForm form) =>
            DisplayExistMessage(form, Constants.ARE_YOU_SURE, Constants.QUESTION);

        public static void Reset(this IEnumerable<Control> textBoxes)
        {
            var controls = textBoxes as Control[] ?? textBoxes.ToArray();
            controls.ToList().ForEach(it => it.ResetText());
            controls.First().Focus();

        }

        public static bool IsChecked(this MetroCheckBox mchkBox)
        {
            switch (mchkBox.CheckState)
            {
                case CheckState.Checked:
                    return true;
                case CheckState.Unchecked:
                    return false;
                case CheckState.Indeterminate:
                    throw new ArgumentOutOfRangeException();
                default:
                    throw new NotImplementedException();
            }
        }

        //

        private static void DisplayMessage<T, TU>(IWin32Window form, T message, TU caption) =>
            MetroMessageBox.Show(form, message.ToString(), caption.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

        private static string DisplayExistMessage<T, TU>(IWin32Window form, T message, TU caption)
        {
            return MetroMessageBox
                .Show(form, message.ToString(), caption.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? "Yes" : "No";
        }
    }
}
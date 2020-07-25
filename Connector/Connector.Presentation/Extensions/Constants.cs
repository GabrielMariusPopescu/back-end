using System;

namespace Connector.Presentation.Extensions
{
    public static class Constants
    {
        public static readonly string MAIN_MESSAGE = $"{Environment.NewLine}Lite Social Networking for Networking Socialities." +
            $"{Environment.NewLine}" +
            $"When Facebook is too curious about you and you're sick of selfies,{Environment.NewLine}" +
            $"Connector is your friend.{Environment.NewLine}" +
            "Now you can talk and listen without the hustle of giving too much information about yourself.";

        public static readonly string INVALID_EMAIL_DOMAIN = "Invalid Email Domain";
        public static readonly string INVALID_PASSWORD = "Password must contain minimum 4 characters.";
        public static readonly string USER_ALREADY_REGISTERED = "User is aready registered!";
        public static readonly string USER_NOT_REGISTERED = "User is not registered!";
        public static readonly string ARE_YOU_SURE = "Are you sure you want to exit?";

        public static readonly string ABOUT = "About (C)onnector";
        public static readonly string ERROR = "Error";
        public static readonly string INFO = "Information";
        public static readonly string QUESTION = "Question";
    }
}

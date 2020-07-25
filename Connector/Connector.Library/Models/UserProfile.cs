using System;

namespace Connector.Library.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public char Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string CurrentCity { get; set; }
        public string Hometown { get; set; }
        public string[] Interests { get; set; }

        public UserProfile(int id, char gender, DateTime birthDate, string currentCity, string homeTown, string[] interests)
        {
            Id = id;
            Gender = gender;
            Birthdate = birthDate;
            CurrentCity = currentCity;
            Hometown = homeTown;
            Interests = interests;
        }
    }
}

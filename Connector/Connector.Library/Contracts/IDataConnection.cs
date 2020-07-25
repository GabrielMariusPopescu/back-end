using Connector.Library.Models;
using System.Collections.Generic;

namespace Connector.Library.Contracts
{
    public interface IDataConnection
    {
        List<User> GetUsers();
        void InsertUser(User user);
        void InsertUserDetail(UserDetail userDetail);
        void InsertUserProfile(UserProfile userProfile);
        void InsertEducational(Educational educational);
        void InsertProfessional(Professional professional);
    }
}

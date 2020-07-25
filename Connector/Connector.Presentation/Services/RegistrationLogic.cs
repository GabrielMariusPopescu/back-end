using Connector.Library;
using Connector.Library.Models;

namespace Connector.Presentation.Services
{
    public class RegistrationLogic
    {
        public void Register(UserDetail userDetail) =>
            GlobalConfiguration.Connection.InsertUserDetail(userDetail);
    }
}

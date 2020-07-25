using Connector.Library.Contracts;
using Connector.Library.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Connector.Library.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public List<User> GetUsers()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
                return connection.Query<User>("spUser_GetAll").ToList();
        }

        public void InsertUser(User user)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Email", user.Email);
                parameters.Add("@Password", user.Password);
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("spUser_Insert", parameters, commandType: CommandType.StoredProcedure);

                user.Id = parameters.Get<int>("@Id");
            }
        }

        public void InsertUserDetail(UserDetail userDetail)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", userDetail.FirstName);
                parameters.Add("@LastName", userDetail.LastName);
                parameters.Add("@UserId", userDetail.UserId);
                parameters.Add("@IsAdmin", userDetail.IsAdmin);
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("spUserDetail_Insert", parameters, commandType: CommandType.StoredProcedure);

                userDetail.Id = parameters.Get<int>("@Id");
            }
        }

        public void InsertUserProfile(UserProfile userProfile)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Gender", userProfile.Gender);
                parameters.Add("@Birthdate", userProfile.Birthdate);
                parameters.Add("@CurrentCity", userProfile.CurrentCity);
                parameters.Add("@Hometown", userProfile.Hometown);
                parameters.Add("@Interests", userProfile.Interests);
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("spUserProfile_Insert", parameters, commandType: CommandType.StoredProcedure);

                userProfile.Id = parameters.Get<int>("@Id");
            }
        }

        public void InsertEducational(Educational educational)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@SchoolName", educational.SchoolName);
                parameters.Add("@YearGraduated", educational.YearGraduated);
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("spEducational_Insert", parameters, commandType: CommandType.StoredProcedure);

                educational.Id = parameters.Get<int>("@Id");
            }
        }

        public void InsertProfessional(Professional professional)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@EmployerName", professional.EmployerName);
                parameters.Add("@JobTitle", professional.JobTitle);
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);

                connection.Execute("spProfessional_Insert", parameters, commandType: CommandType.StoredProcedure);

                professional.Id = parameters.Get<int>("@Id");
            }

        }

        //

        private string ConnectionString { get; } = GlobalConfiguration.GetConnectionString("myConnectionString");
    }
}

using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Options;
using DogKeepers.Shared.QueryFilters;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace DogKeepers.Server.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(IOptions<ConnectionStringsOptions> connectionStrings)
        {
            _connectionString = connectionStrings.Value.Production;
        }
        public async Task<User> GetByEmailPassword(SingInQueryFilter user)
        {
            User data = null;

            using(var connection = new MySqlConnection(_connectionString)){
                var sqlResponse =
                await connection.QueryAsync<User>(
                    $"select * from users where email = '{user.Email}' and password = '{user.Password}'"
                );

                data = sqlResponse.FirstOrDefault();
            }

            return data;
        }
    }
}
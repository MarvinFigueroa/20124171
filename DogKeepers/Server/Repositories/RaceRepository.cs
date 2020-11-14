using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using MySql.Data.MySqlClient;

namespace DogKeepers.Server.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        public async Task<List<Race>> Get()
        {
            List<Race> races = new List<Race>();
            var sqlComand = "select * from races";

            using(var connection = new MySqlConnection("Server=127.0.0.1;Database=dogkeepers;User Id=root")){
                var sqlResponse = await connection.QueryAsync<Race>(
                    sqlComand
                );

                races = sqlResponse.AsList();
            }

            return races;
        }
    }
}
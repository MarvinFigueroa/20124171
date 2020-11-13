using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using MySql.Data.MySqlClient;

namespace DogKeepers.Server.Repositories
{
    public class DogRepository : IDogRepository
    {
        public async Task<List<Dog>> GetList(int random = 0)
        {
            List<Dog> dogs = new List<Dog>();
            var sqlCommand = @"
            select 
                * 
            from 
                dogs
                join races
                    on races.Id = raceId
                join sizes
                    on sizes.Id = sizeId
            ";

            if(random!= 0){
                sqlCommand = $"{sqlCommand} order by rand() limit {random}";
            }


            using(var connection = new MySqlConnection("Server=127.0.0.1;Database=dogkeepers;User Id=root")){
                var sqlResponse = await connection.QueryAsync<Dog, Race, Size, Dog>(
                    sqlCommand,
                    (dg, ra, si) => {
                        dg.Race = ra;
                        dg.Size = si;

                        return dg;
                    },
                    splitOn: "id, id"
                );

                dogs = sqlResponse.AsList();
            }
            
            return dogs;
        }
    }
}
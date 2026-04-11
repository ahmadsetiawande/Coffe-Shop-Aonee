using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffe_Shop.Models;

namespace Coffe_Shop.Repos
{
    public class UserRepo
    {
        public async Task<int> CreateAsync(User user)
        {
            using var conn = Datbase.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO user" +
                "(code,phone,name,email,username,password )" +
                "VALUES" +
                "(@code,@phone,@name,@email,@username,@password)" +
                "SELECT LAST_INSER_ID()";

            cmd.Parameters.AddWithValue("@code", user.Code);
            cmd.Parameters.AddWithValue("@phone", (object?)user.Phone ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@name", (object?)user.Name ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@email", (object?)user.Email ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", (object?)user.Password ?? System.DBNull.Value);
            var id = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(id);


        }

        public async Task<bool> UpdateAsync(User user)
        {
            using var conn = Datbase.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE user SET code=@code, phone@phone, " +
                "name=@name, email=@email, username=@username, password=@password " +
                "WHERE id_user=@id";
            cmd.Parameters.AddWithValue("@code", user.Code);
            cmd.Parameters.AddWithValue("@phone", (object?)user.Phone ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@name", (object?)user.Name ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@email", (object?)user.Email ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", (object?)user.Password ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@id", user.IdUser);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;
        }
    }
}

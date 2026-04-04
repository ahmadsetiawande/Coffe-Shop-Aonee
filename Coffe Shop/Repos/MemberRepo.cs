using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffe_Shop.Models;

namespace Coffe_Shop.Repos
{
    public class MemberRepo
    {
            public async Task<int> CreateAsync(Member member)
            {
                using var conn = Datbase.GetConnection();
                await conn.OpenAsync();
                using var cmd = conn.CreateCommand ();
                cmd.CommandText = "INSERT INTO member " +
                    "(code,full_name,phone,email,username,password,last_update,is_deleted) " +
                    "VALUES" +
                    "(@code,@full_name,@email,@username,@password,@last_update,@is_deleted) " +
                    "SELECT LAST_INSERT_ID();";

            cmd.Parameters.AddWithValue("@code", member.Code);
            cmd.Parameters.AddWithValue("@full_name", (object?)member.FullName ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@phone", (object?)member.Phone ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@email", (object?)member.Email ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@username", member.Username);
            cmd.Parameters.AddWithValue("@password", (object?)member.Password ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@last_update", (object?)member.LastUpdate ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@is_deleted", (object?)member.IsDeleted ?? System.DBNull.Value);
            var id = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(id);

            }

            public async Task<bool> UpdateAsync(Member member)
            {
                using var conn = Datbase.GetConnection();
                await conn.OpenAsync();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE member SET code=@code, full_name@full_name, " +
                    "phone=@phone, email=@email, username=@username, password=@password " +
                    "last_update=@last_update, is_deleted=@is_deleted WHERE id_member=@id";
                cmd.Parameters.AddWithValue("@code", member.Code);
                cmd.Parameters.AddWithValue("@full_name", (object?)member.FullName ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@phone", (object?)member.Phone ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@email", (object?)member.Email ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@username", member.Username);
                cmd.Parameters.AddWithValue("@password", (object?)member.Password ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@last_update", (object?)member.LastUpdate ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@is_deleted", (object?)member.IsDeleted ?? System.DBNull.Value);
                cmd.Parameters.AddWithValue("@id", member.IdMember);
                var affected = await cmd.ExecuteNonQueryAsync();
                return affected > 0;

            }
    }



}

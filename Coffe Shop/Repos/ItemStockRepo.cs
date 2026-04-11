using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffe_Shop.Models;

namespace Coffe_Shop.Repos
{
    public class ItemStockRepo
    {
        public async Task<int> CreateAsync(ItemStock itemstock)
        {
            using var conn = Datbase.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO itemstock " +
                "(code,title,measurement,quantity,last_update,is_deleted) " +
                "VALUES" +
                "(@code,@title,@measurement,@quantity,@last_update,@is_deleted) " +
                "SELECT LAST_INSERT_ID();";

            cmd.Parameters.AddWithValue("@code", itemstock.Code);
            cmd.Parameters.AddWithValue("@title", (object?)itemstock.Title ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@measurement", (object?)itemstock.Measurement ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@quantity", (object?)itemstock.Quantity ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@last_update", (object?)itemstock.LastUpadte ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@is_deleted", (object?)itemstock.IsDeleted ?? System.DBNull.Value);
            var id = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(id);
        }

        public async Task<bool> UpdateAsync(ItemStock itemstock)
        {
            using var conn = Datbase.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE itemstock SET code=@code, title=@title, " +
                "measurement=@measurement, quantity=@quantity " +
                "last_update=@last_update, is_deleted=@is_deleted WHERE id_item=@id";
            cmd.Parameters.AddWithValue("@code", itemstock.Code);
            cmd.Parameters.AddWithValue("@title", (object?)itemstock.Title ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@measurement", (object?)itemstock.Measurement ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@quantity", (object?)itemstock.Quantity ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@last_update", (object?)itemstock.LastUpadte ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@is_deleted", (object?)itemstock.IsDeleted ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@id", itemstock.IdItem);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;

        }
    } 
}

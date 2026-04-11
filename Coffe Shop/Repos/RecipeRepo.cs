using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffe_Shop.Models;

namespace Coffe_Shop.Repos
{
    public class RecipeRepo
    {
        public async Task<int> CreateAsync(Recipe recipe)
        {
            using var conn = Datbase.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO recipe " +
                "(code,name,type,id_item_a,id_item_b,id_item_c,id_item_d,qty_item_a,qty_item_b,qty_item_c,qty_item_d,recipe_instruction,saving_instruction,last_update) " +
                "VALUES" +
                "(@code,@name,@type,@id_item_a,@id_item_b,@id_item_c,@id_item_d,@qty_item_a,@qty_item_b,@qty_item_c,@qty_item_d,@recipe_instruction,@saving_instruction,@last_update) " +
                "SELECT LAST_INSERT_ID();";

            cmd.Parameters.AddWithValue("@code", recipe.Code);
            cmd.Parameters.AddWithValue("@name", (object?)recipe.Name ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@type", (object?)recipe.Type ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@id_item_a", (object?)recipe.IdItemA ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@@id_item_b", (object?)recipe.IdItemB ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@@id_item_c", (object?)recipe.IdItemC ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@@id_item_d", (object?)recipe.IdItemD ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@qty_item_a", (object?)recipe.QtyItemA ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@qty_item_b", (object?)recipe.QtyItemB ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@qty_item_c", (object?)recipe.QtyItemC ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@qty_item_d", (object?)recipe.QtyItemD ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@recipe-instruction", (object?)recipe.RecipeInstruction ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@saving_instruction", (object?)recipe.SavingInstruction ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@last_update", (object?)recipe.LastUpdate ?? System.DBNull.Value);
            var id = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(id);
        }

        public async Task<bool> UpdateAsync(Recipe recipe)
        {
            using var conn = Datbase.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE recipe SET code=@code, name=@name, type=@type " +
                "id_item_a=@id_item_a, id_item_b=@id_item_b, id_item_c=@id_item_c id_item_d=@id_item_d" +
                "qty_item_a=@qty_item_a, qty_item_b=@qty_item_b, qty_item_c=@qty_item_c, qty_item_d=@qty_item_d" +
                "recipe_instruction=@recipr_instruction, saving_instruction=@saving_instruction" +
                "last_update=@last_update, WHERE id_receipt=@id";
            cmd.Parameters.AddWithValue("@code", recipe.Code);
            cmd.Parameters.AddWithValue("@name", (object?)recipe.Name ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@type", (object?)recipe.Type ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@id_item_a", (object?)recipe.IdItemA ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@@id_item_b", (object?)recipe.IdItemB ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@@id_item_c", (object?)recipe.IdItemC ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@@id_item_d", (object?)recipe.IdItemD ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@qty_item_a", (object?)recipe.QtyItemA ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@qty_item_b", (object?)recipe.QtyItemB ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@qty_item_c", (object?)recipe.QtyItemC ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@qty_item_d", (object?)recipe.QtyItemD ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@recipe-instruction", (object?)recipe.RecipeInstruction ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@saving_instruction", (object?)recipe.SavingInstruction ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@last_update", (object?)recipe.LastUpdate ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@id", recipe.IdReceipt);
          
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;

        }
    } 

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffe_Shop.Models;

namespace Coffe_Shop.Repos
{
    public class TransactionRepo
    {
        public async Task<int> CreateAsync(Transacion transaction)
        {
            using var conn = Datbase.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO transaction " +
                "(code,id_member,n_menu,transaction_date,sub_total,id_discount,discount,tax_rate,tax,total,paid,change ) " +
                "VALUES" +
                "(@code,@id_member,@n_menu,@transaction_date,@sub_total,@id_discount,@discount,@tax_rate,@tax,@total,@paid,@change) " +
                "SELECT LAST_INSERT_ID();";

            cmd.Parameters.AddWithValue("@code", transaction.Code);
            cmd.Parameters.AddWithValue("@id_member", (object?)transaction.IdMember ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@n_menu", (object?)transaction.NMenu ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@transaction_date", (object?)transaction.TransactionDate ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@sub_total", (object?)transaction.SubTotal ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@@id_discount", (object?)transaction.IdDiscount ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@discount", (object?)transaction.Discount ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@tax_rate", (object?)transaction.TaxRate ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@tax", (object?)transaction.Tax ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@total", (object?)transaction.Total ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@paid", (object?)transaction.Paid ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@change", (object?)transaction.Change ?? System.DBNull.Value);
            var id = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(id);
        }

        public async Task<bool> UpdateAsync(Transacion transaction)
        {
            using var conn = Datbase.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE transaction SET code=@code, id_member=@id_member, " +
                "n_menu=@n_menu, transaction_date=@transaction_date, sub_total=@sub_total, id_discount=@id_discount, discount=@discount " +
                "tax_rate=@tax_rate, tax=@tax, total=@total, paid=@paid, change=@change WHERE id_transaction=@id";
            cmd.Parameters.AddWithValue("@code", transaction.Code);
            cmd.Parameters.AddWithValue("@id_member", (object?)transaction.IdMember ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@n_menu", (object?)transaction.NMenu ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@transaction_date", (object?)transaction.TransactionDate ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@sub_total", (object?)transaction.SubTotal ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@@id_discount", (object?)transaction.IdDiscount ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@discount", (object?)transaction.Discount ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@tax_rate", (object?)transaction.TaxRate ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@tax", (object?)transaction.Tax ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@total", (object?)transaction.Total ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@paid", (object?)transaction.Paid ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@change", (object?)transaction.Change ?? System.DBNull.Value);
            cmd.Parameters.AddWithValue("@id", transaction.IdTransaction);
            var affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;

        }
    }
}

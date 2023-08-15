using System;
using System.Data;
using DigiCash.Models;
using DigiCash.Models.DbModels;
using Microsoft.Extensions.Options;
using Npgsql;

namespace DigiCash.Services
{
    public class PostgreSqlServices : DBModel
    {
        private NpgsqlConnection connection;

        public PostgreSqlServices(IOptions<PostgreDbSettings> postgreDbSettings)
        {
            string connectionString = postgreDbSettings.Value.ConnectionString;
            connection = new NpgsqlConnection(connectionString);
        }

        public override void addValue(User user)
        {

        }

        public override void addValue(string userId, Wallet wallet)
        {
            //kullanıcıya yeni bir cüzdan oluşturur
        }

        public override void deleteValue(string walletId)
        {
            //kullanıcının istediği wallet ı silmesini sağlar
        }

        public async override Task<DataTable> getValue(string tableName, string id)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM {tableName} WHERE id = @id";
            await using (connection)
            {
                Console.WriteLine("ben çalıştım");
                connection.OpenAsync();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        Console.WriteLine("ben0 de çalıştım");
                        adapter.Fill(dataTable);
                        Console.WriteLine("ben de çalıştım");

                    }
                }
            }
            Console.WriteLine("ben1 de çalıştım");
            connection.Close();
            Console.WriteLine("ben2 de çalıştım");
            return dataTable;
        }

        public async override void updateValue(DataRow wallet)
        {
            await using (connection)
            {
                using var cmd = new NpgsqlCommand("UPDATE wallets SET balance = @newBalance WHERE walletId = @rowId", connection);

                cmd.Parameters.AddWithValue("newBalance", wallet["balance"]); // Set the new value
                cmd.Parameters.AddWithValue("rowId", wallet["walletId"]); // Set the row ID to update

                cmd.ExecuteNonQuery();
            }
            connection.CloseAsync();
        }
}
}


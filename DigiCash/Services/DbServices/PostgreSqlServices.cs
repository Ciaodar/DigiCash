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
            using (connection)
            {
                string query = "INSERT INTO users (username, email) VALUES (@username, @email)";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TcKimlikNo", user.TcKimlikNo);
                    command.Parameters.AddWithValue("@FirstName", user.firstName);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public override void addValue(string userId, Wallet wallet)
        {
            //kullanıcıya yeni bir cüzdan oluşturur
            using (connection)
            {
                string query = "INSERT INTO wallets (userId, balance) VALUES (@userId, @balance)";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@balance", wallet.Balance);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public override void deleteValue(string walletId)
        {
            //kullanıcının istediği wallet ı silmesini sağlar
            using (connection)
            {
                string query = "DELETE FROM wallets WHERE walletId = @walletId";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@walletId", walletId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public async override Task<DataTable> getValue(string tableName, string id)
        {
            DataTable dataTable = new DataTable();//entity list kullanılmalı datatable çok kullanılmaz
            string query = "SELECT * FROM wallets WHERE id = 1";
                Console.WriteLine("ben çalıştım1");
                await connection.OpenAsync();
                Console.WriteLine("ben çalıştım2");
                using (var cmd = new NpgsqlCommand("SELECT * FROM \"Wallets\" WHERE \"walletid\" = @walletid", connection))
                {
                    Console.WriteLine("ben çalıştım3");
                    cmd.Parameters.AddWithValue("walletid", id);
                    Console.WriteLine("ben çalıştım4");
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Console.WriteLine("ben çalıştım5");
                        while (await reader.ReadAsync())
                        {
                            Console.WriteLine("ben çalıştım6");
                            // Access reader columns by index or 
                            double balance = reader.GetDouble(reader.GetOrdinal("balance"));
                            Console.WriteLine(balance);
                        }
                    }
                

            }
            await connection.CloseAsync();

            return dataTable;
        }

        public async override void updateValue(double balance)
        {
                await connection.OpenAsync();
                using var cmd = new NpgsqlCommand("UPDATE \"Wallets\" SET \"balance\" = @newBalance WHERE \"walletid\" = '1'", connection);
                cmd.Parameters.AddWithValue("newBalance", balance); // Set the new value
                cmd.Parameters.AddWithValue("tableName", "Wallets");

                cmd.ExecuteNonQuery();
                await connection.CloseAsync();

        }
}
}


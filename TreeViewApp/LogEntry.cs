using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TreeViewApp
{
    public sealed class LogEntry
    {
        public int Id { get; set; }
        public string Environment { get; set; } = string.Empty;
        public string SqlServer { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
        public string User { get; set; } = System.Environment.UserName;
        public bool Success { get; set; }
        public string ScriptRan { get; set; } = string.Empty;
        public string? ErrorMessage { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public int BatchNumber { get; set; }

        public static async Task<int> GetNextBatchNumberAsync()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LogDb"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Connection string 'LogDb' is missing or empty in configuration.");
            }

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand("LogExecution_GetNextBatch", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            await connection.OpenAsync().ConfigureAwait(false);
            var result = await command.ExecuteScalarAsync().ConfigureAwait(false);
            return Convert.ToInt32(result);
        }

        public static async Task<IReadOnlyList<int>> GetBatchNumbersAsync()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LogDb"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Connection string 'LogDb' is missing or empty in configuration.");
            }

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand("LogExecution_GetBatches", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            await connection.OpenAsync().ConfigureAwait(false);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);

            var batches = new List<int>();
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                batches.Add(reader.GetInt32(reader.GetOrdinal("BatchNumber")));
            }

            return batches;
        }

        public static async Task<IReadOnlyList<LogEntry>> GetByBatchAsync(int batchNumber)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LogDb"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Connection string 'LogDb' is missing or empty in configuration.");
            }

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand("LogExecution_GetByBatch", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@BatchNumber", SqlDbType.Int).Value = batchNumber;

            await connection.OpenAsync().ConfigureAwait(false);
            using var reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(false);

            var results = new List<LogEntry>();
            while (await reader.ReadAsync().ConfigureAwait(false))
            {
                results.Add(Map(reader));
            }

            return results;
        }

        public static async Task<int> InsertAsync(LogEntry entry)
        {
            if (entry is null)
            {
                throw new ArgumentNullException(nameof(entry));
            }

            var connectionString = ConfigurationManager.ConnectionStrings["LogDb"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Connection string 'LogDb' is missing or empty in configuration.");
            }

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand("LogExecution_Insert", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            command.Parameters.Add("@Environment", SqlDbType.NVarChar, 50).Value = entry.Environment;
            command.Parameters.Add("@SqlServer", SqlDbType.NVarChar, 200).Value = entry.SqlServer;
            command.Parameters.Add("@DatabaseName", SqlDbType.NVarChar, 200).Value = entry.DatabaseName;
            command.Parameters.Add("@User", SqlDbType.NVarChar, 200).Value = entry.User;
            command.Parameters.Add("@Success", SqlDbType.Bit).Value = entry.Success;
            command.Parameters.Add("@ScriptRan", SqlDbType.NVarChar, -1).Value = entry.ScriptRan;
            command.Parameters.Add("@ErrorMessage", SqlDbType.NVarChar, -1).Value = (object?)entry.ErrorMessage ?? DBNull.Value;
            command.Parameters.Add("@CreatedDate", SqlDbType.DateTime2).Value = entry.CreatedDate;
            command.Parameters.Add("@BatchNumber", SqlDbType.Int).Value = entry.BatchNumber;

            await connection.OpenAsync().ConfigureAwait(false);
            var result = await command.ExecuteScalarAsync().ConfigureAwait(false);
            return Convert.ToInt32(result);
        }

        private static LogEntry Map(IDataRecord record)
        {
            return new LogEntry
            {
                Id = record.GetInt32(record.GetOrdinal("Id")),
                Environment = record.GetString(record.GetOrdinal("Environment")),
                SqlServer = record.GetString(record.GetOrdinal("SqlServer")),
                DatabaseName = record.GetString(record.GetOrdinal("DatabaseName")),
                User = record.GetString(record.GetOrdinal("User")),
                BatchNumber = record.GetInt32(record.GetOrdinal("BatchNumber")),
                Success = record.GetBoolean(record.GetOrdinal("Success")),
                ScriptRan = record.GetString(record.GetOrdinal("ScriptRan")),
                ErrorMessage = record.IsDBNull(record.GetOrdinal("ErrorMessage")) ? null : record.GetString(record.GetOrdinal("ErrorMessage")),
                CreatedDate = record.GetDateTime(record.GetOrdinal("CreatedDate"))
            };
        }
    }
}

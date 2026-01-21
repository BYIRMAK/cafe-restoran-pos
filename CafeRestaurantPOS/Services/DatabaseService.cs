using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using CafeRestaurantPOS.Models;

namespace CafeRestaurantPOS.Services
{
    public class DatabaseService
    {
        private static string dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "CafeRestaurantPOS",
            "pos_database.db"
        );

        private static string ConnectionString => $"Data Source={dbPath};Version=3;";

        public static void Initialize()
        {
            string directory = Path.GetDirectoryName(dbPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                CreateTables();
                SeedDefaultData();
            }
        }

        private static void CreateTables()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        FullName TEXT NOT NULL,
                        Role TEXT NOT NULL,
                        IsActive INTEGER NOT NULL DEFAULT 1,
                        CreatedAt TEXT NOT NULL
                    )";

                string createLicensesTable = @"
                    CREATE TABLE IF NOT EXISTS Licenses (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        LicenseKey TEXT NOT NULL,
                        DeviceId TEXT NOT NULL,
                        ActivatedAt TEXT NOT NULL,
                        ExpiresAt TEXT NOT NULL,
                        IsActive INTEGER NOT NULL DEFAULT 1
                    )";

                using (var cmd = new SQLiteCommand(createUsersTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SQLiteCommand(createLicensesTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private static void SeedDefaultData()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string insertAdmin = @"
                    INSERT INTO Users (Username, Password, FullName, Role, IsActive, CreatedAt)
                    VALUES (@username, @password, @fullname, @role, 1, @createdAt)";

                using (var cmd = new SQLiteCommand(insertAdmin, conn))
                {
                    cmd.Parameters.AddWithValue("@username", "admin");
                    cmd.Parameters.AddWithValue("@password", EncryptionService.HashPassword("admin123"));
                    cmd.Parameters.AddWithValue("@fullname", "Administrator");
                    cmd.Parameters.AddWithValue("@role", "Admin");
                    cmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static User ValidateUser(string username, string password)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password AND IsActive = 1";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", EncryptionService.HashPassword(password));

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Username = reader["Username"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Role = reader["Role"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static void SaveLicense(License license)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Licenses (LicenseKey, DeviceId, ActivatedAt, ExpiresAt, IsActive)
                    VALUES (@licenseKey, @deviceId, @activatedAt, @expiresAt, 1)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@licenseKey", license.LicenseKey);
                    cmd.Parameters.AddWithValue("@deviceId", license.DeviceId);
                    cmd.Parameters.AddWithValue("@activatedAt", license.ActivatedAt.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@expiresAt", license.ExpiresAt.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static License GetActiveLicense()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Licenses WHERE IsActive = 1 ORDER BY Id DESC LIMIT 1";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new License
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                LicenseKey = reader["LicenseKey"].ToString(),
                                DeviceId = reader["DeviceId"].ToString(),
                                ActivatedAt = DateTime.Parse(reader["ActivatedAt"].ToString()),
                                ExpiresAt = DateTime.Parse(reader["ExpiresAt"].ToString()),
                                IsActive = Convert.ToBoolean(reader["IsActive"])
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}

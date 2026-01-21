using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using LicenseManager.Models;

namespace LicenseManager.Services
{
    public class DatabaseService
    {
        private static string dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "CafeRestaurantPOS_LicenseManager",
            "license_manager.db"
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
            }
        }

        private static void CreateTables()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string createCustomersTable = @"
                    CREATE TABLE IF NOT EXISTS Customers (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        BusinessName TEXT NOT NULL,
                        ContactPerson TEXT NOT NULL,
                        Email TEXT,
                        Phone TEXT,
                        Address TEXT,
                        CreatedAt TEXT NOT NULL
                    )";

                string createLicensesTable = @"
                    CREATE TABLE IF NOT EXISTS Licenses (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        CustomerId INTEGER NOT NULL,
                        LicenseKey TEXT NOT NULL,
                        DeviceId TEXT NOT NULL,
                        GeneratedAt TEXT NOT NULL,
                        ExpiresAt TEXT NOT NULL,
                        IsActive INTEGER NOT NULL DEFAULT 1,
                        FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
                    )";

                using (var cmd = new SQLiteCommand(createCustomersTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SQLiteCommand(createLicensesTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AddCustomer(Customer customer)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Customers (BusinessName, ContactPerson, Email, Phone, Address, CreatedAt)
                    VALUES (@businessName, @contactPerson, @email, @phone, @address, @createdAt)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@businessName", customer.BusinessName);
                    cmd.Parameters.AddWithValue("@contactPerson", customer.ContactPerson);
                    cmd.Parameters.AddWithValue("@email", customer.Email ?? "");
                    cmd.Parameters.AddWithValue("@phone", customer.Phone ?? "");
                    cmd.Parameters.AddWithValue("@address", customer.Address ?? "");
                    cmd.Parameters.AddWithValue("@createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Customers ORDER BY CreatedAt DESC";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                BusinessName = reader["BusinessName"].ToString(),
                                ContactPerson = reader["ContactPerson"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Address = reader["Address"].ToString(),
                                CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
                            });
                        }
                    }
                }
            }

            return customers;
        }

        public static void SaveLicense(License license)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                    INSERT INTO Licenses (CustomerId, LicenseKey, DeviceId, GeneratedAt, ExpiresAt, IsActive)
                    VALUES (@customerId, @licenseKey, @deviceId, @generatedAt, @expiresAt, 1)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", license.CustomerId);
                    cmd.Parameters.AddWithValue("@licenseKey", license.LicenseKey);
                    cmd.Parameters.AddWithValue("@deviceId", license.DeviceId);
                    cmd.Parameters.AddWithValue("@generatedAt", license.GeneratedAt.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@expiresAt", license.ExpiresAt.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<License> GetAllLicenses()
        {
            List<License> licenses = new List<License>();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
                    SELECT l.*, c.BusinessName as CustomerName 
                    FROM Licenses l
                    INNER JOIN Customers c ON l.CustomerId = c.Id
                    ORDER BY l.GeneratedAt DESC";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            licenses.Add(new License
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                CustomerId = Convert.ToInt32(reader["CustomerId"]),
                                LicenseKey = reader["LicenseKey"].ToString(),
                                DeviceId = reader["DeviceId"].ToString(),
                                GeneratedAt = DateTime.Parse(reader["GeneratedAt"].ToString()),
                                ExpiresAt = DateTime.Parse(reader["ExpiresAt"].ToString()),
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                CustomerName = reader["CustomerName"].ToString()
                            });
                        }
                    }
                }
            }

            return licenses;
        }

        public static Customer GetCustomerById(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Customers WHERE Id = @id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                BusinessName = reader["BusinessName"].ToString(),
                                ContactPerson = reader["ContactPerson"].ToString(),
                                Email = reader["Email"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Address = reader["Address"].ToString(),
                                CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebAPI_Dapper.Models.Entities;
using WebAPI_Dapper.Models.Interfaces;

namespace WebAPI_Dapper.Models.Repository
{
    public class ClientRepository:IRepository<Client>
    {
        private readonly string _connectionString = @"Server=DESKTOP-ARM4FB7\SQLEXPRESS;Database=DapperDB;Initial Catalog=DapperDB;Integrated Security=True";
        public void Create(Client item)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO Clients (Name, Phone, Mail) VALUES(@Name, @Phone, @Mail);";
                db.Execute(sqlQuery,item);
            }
        }

        public void Remove(int Id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "DELETE FROM Clients WHERE Id = @id";
                db.Execute(sqlQuery, new { Id });
            }
        }

        public void Update(Client item)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "UPDATE Clients SET Name = @Name, Phone = @Phone, Mail = @Mail WHERE Id = @Id";
                db.Execute(sqlQuery, item);
            }
        }

        public IEnumerable<Client> GetAll()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                IEnumerable<Client> clients= db.Query<Client>("Select * FROM Clients");
                return clients;
            }
        }

        public Client Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

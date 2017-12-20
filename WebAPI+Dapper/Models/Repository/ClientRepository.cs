using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Dapper.Models.Entities;
using WebAPI_Dapper.Models.Interfaces;

namespace WebAPI_Dapper.Models.Repository
{
    public class ClientRepository:IRepository<Client>
    {
        public ClientRepository()
        {
            
        }
        public void Create(Client item)
        {
            throw new NotImplementedException();
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Client item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

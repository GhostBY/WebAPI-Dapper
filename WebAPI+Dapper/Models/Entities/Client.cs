using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Dapper.Models.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}

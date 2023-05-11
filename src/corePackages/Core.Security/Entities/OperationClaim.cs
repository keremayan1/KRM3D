using Core.Persistance.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Entities
{
    public class OperationClaim : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public OperationClaim()
        {
        }

        public OperationClaim(int id, string name) :this()
        {
            Id = id;
            Name = name;
        }
    }
}

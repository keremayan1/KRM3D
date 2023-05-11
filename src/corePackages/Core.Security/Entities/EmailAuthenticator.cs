using Core.Persistance.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Entities
{
    public class EmailAuthenticator:Entity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? ActivationKey { get; set; }
        public bool IsVerified { get; set; }

        public EmailAuthenticator()
        {

        }

        public EmailAuthenticator(int id,int userId, string? activationKey, bool isVerified):this()
        {
            Id = id;
            UserId = userId;
            ActivationKey = activationKey;
            IsVerified = isVerified;
        }
    }
}

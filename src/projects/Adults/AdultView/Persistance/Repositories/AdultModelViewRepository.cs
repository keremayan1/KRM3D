using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class AdultModelViewRepository : EfRepositoryBase<AdultModelView, MySQLContext>, IAdultModelViewRepository
    {
        public AdultModelViewRepository(MySQLContext context) : base(context)
        {
        }
    }


}

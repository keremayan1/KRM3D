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
    public class GenderRepository : EfRepositoryBase<GenderReadModel, SQLContext>, IGenderRepository
    {
        public GenderRepository(SQLContext context) : base(context)
        {
        }
    }
}

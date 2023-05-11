using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using child =Child.Domain.Entities;


namespace Child.Infrasructure.Adapters.PersonService
{
    public interface IKpsService
    {
        Task<bool> Verify(child.Child child);
    }
}

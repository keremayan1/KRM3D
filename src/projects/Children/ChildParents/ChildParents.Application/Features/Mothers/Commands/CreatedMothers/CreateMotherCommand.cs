using ChildParents.Application.Features.Mothers.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParents.Application.Features.Mothers.Commands.CreatedMothers
{
    public  class CreateMotherCommand:IRequest<CreatedMotherDto>
    {
        public bool DoesHaveAMother { get; set; }
        public string ChildrenId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EducationStatusId { get; set; }
        public string Job { get; set; }
        public string TelephoneNumber { get; set; }
    }
}

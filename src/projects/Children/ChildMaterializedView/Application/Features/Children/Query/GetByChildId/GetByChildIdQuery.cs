using Application.Features.Children.Models;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Children.Query.GetByChildId
{
    public class GetByChildIdQuery:IRequest<ChildModel>
    {
        public string Id { get; set; }
        public class GetByChildIdQueryHandler : IRequestHandler<GetByChildIdQuery, ChildModel>
        {
            private readonly IChildRepository _childRepository;
            private readonly IMapper _mapper;

            public GetByChildIdQueryHandler(IChildRepository childRepository, IMapper mapper)
            {
                _childRepository = childRepository;
                _mapper = mapper;
            }

            public async Task<ChildModel> Handle(GetByChildIdQuery request, CancellationToken cancellationToken)
            {
                var models = await _childRepository.GetListAsync(x=>x.Id==request.Id,
                                                                include: x => x.Include(g => g.Gender)
                                                                               .Include(g => g.ChildFather)
                                                                               .Include(g => g.ChildFather.EducationStatus)
                                                                               .Include(x => x.ChildMother)
                                                                               .Include(x => x.ChildMother.EducationStatus)
                                                                               .Include(x => x.ChildSiblings).ThenInclude(educationStatus => educationStatus.EducationStatus)
                                                                               .Include(x => x.ChildSiblings).ThenInclude(gender => gender.Gender)
                                                                               .Include(x => x.QuestionAnswers).ThenInclude(question => question.Question)
                                                                               .Include(x => x.QuestionAnswers).ThenInclude(questionTitle => questionTitle.Question.QuestionTitle));

                var mappedModels = _mapper.Map<ChildModel>(models);
                return mappedModels;
            }
        }
    }
}

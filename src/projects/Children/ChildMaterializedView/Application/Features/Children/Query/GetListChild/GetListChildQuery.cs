using Application.Features.Children.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Children.Query.GetListChild
{
    public class GetListChildQuery : IRequest<ChildModel>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListChildQueryHandler : IRequestHandler<GetListChildQuery, ChildModel>
        {
            private readonly IChildRepository _childRepository;
            private readonly IMapper _mapper;

            public GetListChildQueryHandler(IChildRepository childRepository, IMapper mapper)
            {
                _childRepository = childRepository;
                _mapper = mapper;
            }

            public async Task<ChildModel> Handle(GetListChildQuery request, CancellationToken cancellationToken)
            {
                var models = await _childRepository.GetListAsync(include: x => x.Include(g => g.Gender)
                                                                                .Include(g => g.ChildFather)
                                                                                .Include(g => g.ChildFather.EducationStatus)
                                                                                .Include(x => x.ChildMother)
                                                                                .Include(x => x.ChildMother.EducationStatus)
                                                                                .Include(x => x.ChildSiblings).ThenInclude(educationStatus=>educationStatus.EducationStatus)
                                                                                .Include(x => x.ChildSiblings).ThenInclude(gender => gender.Gender)
                                                                                .Include(x=>x.QuestionAnswers).ThenInclude(question=>question.Question)
                                                                                .Include(x => x.QuestionAnswers).ThenInclude(questionTitle => questionTitle.Question.QuestionTitle)
                                                                                ,
                                                                                index: request.PageRequest.Page,
                                                                                size: request.PageRequest.PageSize);

                var mappedModels = _mapper.Map<ChildModel>(models);
                return mappedModels;
            }
        }
    }
}

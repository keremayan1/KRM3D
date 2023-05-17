using Application.Features.Adult.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Adult.Queries.GetListAdult
{
    public class GetListAdultQuery:IRequest<AdultModel>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListAdultQueryHandler : IRequestHandler<GetListAdultQuery, AdultModel>
        {
            private readonly IAdultModelViewRepository _adultModelViewRepository;
            private readonly IMapper _mapper;

            public GetListAdultQueryHandler(IAdultModelViewRepository adultModelViewRepository, IMapper mapper)
            {
                _adultModelViewRepository = adultModelViewRepository;
                _mapper = mapper;
            }

            public async Task<AdultModel> Handle(GetListAdultQuery request, CancellationToken cancellationToken)
            {
                var models = await _adultModelViewRepository.GetListAsync(include: x => x.Include(x => x.AdultGender)
                                                                                 .Include(x=>x.AdultMarriedStatus)
                                                                                 .Include(x => x.EducationStatus)
                                                                                 .Include(x => x.AdultFather)
                                                                                 .Include(x => x.AdultFather.AdultEducationStatus)
                                                                                 .Include(x => x.AdultMother)
                                                                                 .Include(x => x.AdultMother.AdultEducationStatus)
                                                                                 .Include(x => x.AdultSiblings).ThenInclude(educationStatus => educationStatus.AdultEducationStatus)
                                                                                 .Include(x => x.AdultSiblings).ThenInclude(gender => gender.AdultGender)
                                                                                 .Include(x => x.AdultQuestionAnswers).ThenInclude(question => question.AdultQuestion)
                                                                                 .Include(x => x.AdultQuestionAnswers).ThenInclude(questionTitle => questionTitle.AdultQuestion.AdultQuestionTitle)
                                                                                 ,
                                                                                 index: request.PageRequest.Page,
                                                                                 size: request.PageRequest.PageSize);
                var mappedModels = _mapper.Map<AdultModel>(models);
                return mappedModels;
            }
        }
    }
}

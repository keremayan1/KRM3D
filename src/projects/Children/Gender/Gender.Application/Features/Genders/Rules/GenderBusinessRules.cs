using Core.CrossCuttingConcerns.Exceptions;
using Gender.Application.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using genders = Gender.Domain.Entities;
namespace Gender.Application.Features.Genders.Rules
{
    public class GenderBusinessRules
    {
        private readonly IGenderRepository _genderRepository;

        public GenderBusinessRules(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }
        public async Task GenderCannotNull(genders.Gender gender)
        {
            if (gender == null)
            {
                throw new BusinessException("Gender doesn't null");
            }
        }
        public async Task GenderNameCannotBeDuplicatedWhenInserted(string genderName)
        {
            var result = await _genderRepository.GetListAsync(x => x.GenderName == genderName);
            if (result.Any())
            {
                throw new BusinessException("Gender Name Exists");
            }
        }
        public async Task GenderNameCannotBeDuplicatedWhenUpdated(string genderName)
        {
            var result = await _genderRepository.GetListAsync(x => x.GenderName == genderName);
            if (result.Any())
            {
                throw new BusinessException("Gender Name Exists");
            }
        }
    }
}

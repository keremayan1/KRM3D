using Child.Application.Services.Repositories;
using Child.Infrasructure.Adapters.PersonService;
using Core.CrossCuttingConcerns.Exceptions;

using child = Child.Domain.Entities;


namespace Child.Application.Features.Children.Rules
{
    public class ChildBusinessRules
    {
        private readonly IChildRepository _childRepository;
        private readonly IKpsService _kpsService;

        public ChildBusinessRules(IChildRepository childRepository, IKpsService kpsService)
        {
            _childRepository = childRepository;
            _kpsService = kpsService;
        }
        public  void CheckIfNationalIdExists(string nationalId)
        {
            var result = _childRepository.Any(x => x.NationalId == nationalId);
            if (result)
            {
                throw new BusinessException("Hata Boyle Bir Kullanici Sistemde Vardir");
            }
        }
        public async Task VerifyNationalId(child.Child child)
        {
            var result = await _kpsService.Verify(child);
            if (!result)
            {
                throw new BusinessException("Hatali TC");
            }
        }
        public void ChildPropertiesToUpper(child.Child child)
        {
            child.FirstName = child.FirstName.ToUpper();
            child.LastName = child.LastName.ToUpper();
            child.SchoolName = child.SchoolName.ToUpper();
            child.SchoolName = child.SchoolName.ToUpper();
        }
        public void ChildPropertiesTrim(child.Child child)
        {
            child.FirstName = child.FirstName.Trim();
            child.LastName = child.LastName.Trim();
            child.SchoolName = child.SchoolName.Trim();
            child.SchoolName = child.SchoolName.Trim();
        }
    }
}

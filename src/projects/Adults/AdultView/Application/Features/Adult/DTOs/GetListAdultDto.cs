using Application.Features.AdultFather.DTOs;
using Application.Features.AdultMother.DTOs;
using Application.Features.AdultSiblings.DTOs;
using Application.Features.QuestionAnswer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Adult.DTOs
{
    public class GetListAdultDto
    {
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GenderName { get; set; }
        public string EducationStatusName { get; set; }
        public string MarriedStatusName { get; set; }
        public string EthnicName { get; set; }
        public string ReligionName { get; set; }
        public string Job { get; set; }
        public string IsLiveWith { get; set; }
        public string DidSheHeComeWith { get; set; }
        public string PersonComesFromHere { get; set; }
        public string ReasonOfApplication { get; set; }


        public GetAdultMotherDto AdultMother { get; set; }
        public GetAdultFatherDto AdultFather { get; set; }
        public List<GetAdultSiblingsDto> AdultSiblingsDtos { get; set; }
        public List<GetListAdultQuestionAnswerDto> AdultQuestionAnswerDtos { get; set; }

    }
}

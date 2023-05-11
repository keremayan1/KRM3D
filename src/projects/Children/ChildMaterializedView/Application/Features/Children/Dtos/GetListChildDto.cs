using Application.Features.ChildFather.DTOs;
using Application.Features.ChildMother.DTOs;
using Application.Features.ChildSiblings.DTOs;
using Application.Features.QuestionAnswer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Children.Dtos
{
    public class GetListChildDto
    {
        public string Id { get; set; }
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GenderName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SchoolName { get; set; }
        public string ClassName { get; set; }
        public GetChildFatherDto ChildFather { get; set; }
        public GetChildMotherDto ChildMother { get; set; }
        public List<GetListChildSiblingsDto> ChildSiblings { get; set; }
        public List<GetQuestionAnswerDto> QuestionAnswers { get; set; }

    }
}

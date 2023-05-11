using Application.Features.Children.Dtos;
using Core.Persistance.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Children.Models
{
    public class ChildModel:BasePageableModel
    {
        public IList<GetListChildDto> Items { get; set; }

    }
}

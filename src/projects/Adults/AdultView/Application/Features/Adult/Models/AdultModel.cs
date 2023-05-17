using Application.Features.Adult.DTOs;
using Core.Persistance.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Adult.Models
{
    public class AdultModel:BasePageableModel
    {
        public IList<GetListAdultDto> Items { get; set; }
    }
}

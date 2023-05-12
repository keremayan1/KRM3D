using Core.Persistance.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AdultMarriedStatusModelView:Entity
    {
        public string _id { get; set; }
        public string MarriedStatusName { get; set; }
        public AdultMarriedStatusModelView()
        {
            
        }

        public AdultMarriedStatusModelView(string id, string marriedStatusName):this()
        {
            _id = id;
            MarriedStatusName = marriedStatusName;
        }
    }
}

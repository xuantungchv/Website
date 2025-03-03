using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Menu
{
    public class MenuId : ValueObject
    {
        public Guid Id { get; set; }
        private MenuId(Guid id)
        {
            Id = id;
        }
        public static void GenerateId()
        {
            new MenuId(Guid.NewGuid());
        }
        public override IEnumerable<object> GetEqualityComponent()
        {
            throw new NotImplementedException();
        }
    }
}

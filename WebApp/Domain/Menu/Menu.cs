using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Menu
{
    public sealed class Menu : AggregateRoot<MenuId>
    {

        private Menu(MenuId id): base(id) 
        {

        }
 
    }
}

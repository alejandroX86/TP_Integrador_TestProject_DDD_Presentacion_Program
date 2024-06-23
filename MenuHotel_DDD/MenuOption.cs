using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuHotel_DDD
{
    public class MenuOption
    {
        public int Option { get; }
        public string Description { get; }

        public MenuOption(int option, string description)
        {
            Option = option;
            Description = description;
        }
    }
}

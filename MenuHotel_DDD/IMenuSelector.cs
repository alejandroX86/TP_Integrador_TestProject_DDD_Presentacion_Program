using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuHotel_DDD
{
    public interface IMenuSelector
    {
        MenuOption SelectOption(string input);
    }
}

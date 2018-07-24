using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BotHealth
{
    class ValidateInput
    {

        static Regex rgxAdd = new Regex("/n");
        public static Boolean validateAddMedicine(String AddMedicine)
        {
            return rgxAdd.IsMatch(AddMedicine);
        }
    }
}

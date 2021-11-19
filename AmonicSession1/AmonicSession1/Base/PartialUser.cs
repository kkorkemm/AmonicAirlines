using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmonicSession1.Base
{
    public partial class Users
    {
        public int Age => DateTime.Now.Year - Convert.ToDateTime(Birthdate).Year;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTK_HT.Check
{
    public class check
    {
        public bool IsValid(string username, string password) { return (username == "admin" && password == "123"); }
    }
}

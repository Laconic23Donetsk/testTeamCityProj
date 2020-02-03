using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTeamCityConsoleProj
{
    public class Class2
    {
        public string Bar(int a)
        {
            return a.ToString();
        }

        public string DoubleBar(int a, int b)
        {
            return Bar(a) + Bar(b);
        }
    }
}

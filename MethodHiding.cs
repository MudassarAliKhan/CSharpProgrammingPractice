using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public class MethodHiding
    {
        public void Mh1()
        {

        }
    }

    public class Methodh2: MethodHiding
    {
        public new void Mh1()
        {
            base.Mh1();
        }
    }
}

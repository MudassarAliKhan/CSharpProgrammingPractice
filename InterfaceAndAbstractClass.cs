using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    interface A1
    {
        void Add();
    }
    public class InterfaceAndAbstractClass : AbstractClass
    {
        public override void M1()
        {
            throw new NotImplementedException();
        }

        public override void M2()
        {
            throw new NotImplementedException();
        }

        public override void Method1()
        {
            throw new NotImplementedException();
        }

        public override void Method2()
        {
            throw new NotImplementedException();
        }
    }
}

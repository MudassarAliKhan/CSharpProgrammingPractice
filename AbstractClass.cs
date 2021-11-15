using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingPractice
{
    public interface I1
    {
        void M1();
        void M2();
    }
    public abstract class AbstractClass:I1
    {
        int a;
        int b;
        public abstract void M1();
        public abstract void M2();
        public abstract void Method1();
        public abstract void Method2();
        

    }
}

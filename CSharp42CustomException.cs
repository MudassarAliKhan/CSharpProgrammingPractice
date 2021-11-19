using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace CSharpProgrammingPractice
{
    public class _42CustomException:Exception
    {
        public _42CustomException():base()
        {

        }
        public _42CustomException(String Message):base(Message)
        {
            Console.WriteLine(Message);
        }
        public _42CustomException(String Message , Exception InnerException):base(Message,InnerException)
        {

        }
        public _42CustomException(SerializationInfo info, StreamingContext streamingContext):base(info,streamingContext)
        {

        }
        
    }
    [Serializable]
    public class Test
    {
        /*public static void Main(String[] args)
        {
            throw new _42CustomException("Custom Exception");
        }*/

    }
}

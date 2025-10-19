using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    public class stringVsStringBuilderProgram
    {
        private string pass;
        public stringVsStringBuilderProgram(string pass)
        {
            this.pass = pass;
            pass = string.Concat(pass, "123");
            Console.WriteLine(pass);
        }
        static void Main(string[] args)
        {
            string str = "sbbb";
            stringVsStringBuilderProgram obj = new stringVsStringBuilderProgram(str);
            Console.ReadKey();
        }
    }
}

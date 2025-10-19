using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithDeep
{
    class AccessSpecifier // Type -- public, internal , Default- internal 
    {
        public string publicField = "publicField";
        private string privateField = "privateField";
        protected string protectedField = "protectedField";
        internal string internalField = "internalField";
        protected internal string protectedInternalField = "protectedInternalField";

        public string PublicMethod()
        {
            return publicField;
        }

        private string PrivateMethod()
        {
            return privateField;
        }

        protected string ProtectedMethod()
        {
            return protectedField;
        }

        internal string InternalMethod()
        {
            return internalField;
        }

        protected internal string ProtectedInternalMethod()
        {
            return protectedInternalField;
        }
        static void Main()
        {
            //Access Specifier:-
            // To access the class member or type member we use accessSpecifier 
            // Types of Access Specifier:-
            //1. Public - Anywhere will accessible based on reference.
            //2. Private - within the class only.
            //3. Protected - within derived(inherited) class instance 
            //4. Internal - within same assembly.
            //5. Protected Internal - protected + internal 

            var obj = new AccessSpecifier();
        }
    }

    class parentClass
    {
        protected string ProtectedMethod()
        {
            return "Protectemethod called here";
        }
    }

    class childClass : parentClass
    {
        public void ShowMessage()
        {
            ProtectedMethod();
        }
    }
}

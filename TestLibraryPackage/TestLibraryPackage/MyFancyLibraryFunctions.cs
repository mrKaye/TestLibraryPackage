using DependendLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibraryPackage
{
    public class MyFancyLibraryFunctions
    {
        public string ConvertMYString(string input)
        {
            var dependendtstring = DependentFunctions.ReturnDependentString();

            return $"This is what you wrote: {input} : {dependendtstring} ";
        }

        public bool IsTrue()
        {
            return true;
        }

    }
}

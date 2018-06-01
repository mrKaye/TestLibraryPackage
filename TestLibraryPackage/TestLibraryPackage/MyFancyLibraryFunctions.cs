using DependendLib;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibraryPackage
{
    public class MyFancyLibraryFunctions
    {
        public string InputMyString(string input)
        {
            var dependendtstring = DependentFunctions.ReturnDependentString();

            return $"This is what you wrote: {input} : {dependendtstring} ";
        }

        public bool IsTrue()
        {
            return true;
        }

        public string ReturnMyJsonObject()
        {
            dynamic testObject = new ExpandoObject();
            testObject.User = "Test Testesen";
            testObject.Description = "This is a test user";
            testObject.LastLogon = DateTime.Now.AddHours(-1);
            var mysjon = Newtonsoft.Json.JsonConvert.SerializeObject(testObject);
            return mysjon;

        }

    }

}

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

        public string ReturnMyJsonObjeckt()
        {
            var obj = new TestObject() { ObjectDescription = "Fancy object", ObjectID = "1" };
            var mysjon = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            return mysjon;

        }

    }

    public class TestObject
    {
        public string ObjectID { get; set; }
        public string ObjectDescription { get; set; }
    }
}

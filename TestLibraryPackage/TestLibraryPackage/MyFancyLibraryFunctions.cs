using DependendLib;
using System;
using System.Dynamic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

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

        public string ReturnUser()
        {
            dynamic testObject = new ExpandoObject();
            testObject.User = "Test Testesen";
            testObject.Description = "This is a test user";
            testObject.LastLogon = DateTime.Now.AddHours(-1);

            return Newtonsoft.Json.JsonConvert.SerializeObject(testObject);

        }

        public string ReturnChuckJoke()
        {
            string html = string.Empty;
            string url = @"https://api.icndb.com/jokes/random/?limitTo=[nerdy]";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var jsnoresult = reader.ReadToEnd();
                var jsnobjDeserializeObject = JsonConvert.DeserializeObject<RootObject>(jsnoresult);
                return jsnobjDeserializeObject.value.joke;
            }





        }

    }

}

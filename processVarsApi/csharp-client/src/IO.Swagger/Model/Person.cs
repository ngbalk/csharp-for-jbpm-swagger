using System.Dynamic;
using Newtonsoft.Json;
using IO.Swagger.Client;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model{

    [JsonObject(Title="svm.hello_bpm.Person")]
    public class Person{
        public string name { get; set; }
        public int age { get; set; }
    }
}
using Newtonsoft.Json;
using IO.Swagger.Client;

namespace IO.Swagger.Model{

    [JsonObject(Title="svm.hello_bpm.Person")]
    public class Person{
        public string name { get; set; }
        public int age { get; set; }
    }
}

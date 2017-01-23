using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace IO.Swagger.Model
{
    public class Task
    {
        [JsonProperty("task-id")]
        public string TaskId {get; set;}

    }
}
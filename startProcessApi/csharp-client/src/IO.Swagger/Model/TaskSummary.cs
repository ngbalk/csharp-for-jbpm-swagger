using System.Collections.Generic;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
    public class TaskSummary
    {
        [JsonProperty("task-summary")]
        public List<Task> tasks { get; set; }
    }
}
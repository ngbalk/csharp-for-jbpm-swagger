using System;
using Newtonsoft.Json;
using IO.Swagger.Client;

namespace IO.Swagger.Model{

	public class Person{
		public string name { get; set; }
		public int age { get; set; }

	    [JsonConverter(typeof(DateTimeConverter))]
	    public DateTime dateTime { get; set; }
	}

}

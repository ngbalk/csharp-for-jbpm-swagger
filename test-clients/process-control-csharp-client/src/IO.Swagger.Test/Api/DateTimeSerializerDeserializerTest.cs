using System;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Newtonsoft.Json;
using NUnit.Framework;

namespace IO.Swagger.Test
{
    public class DateTimeSerializerDeserializerTest
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
            instance.Configuration.Username = "kieserver";
            instance.Configuration.Password = "kieserver1!";        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }


        [Test]
        public void serializeDateTimeTest()
        {
            Dictionary<string,object> dict = new Dictionary<string, object>();
            dict.Add("day","christmas");
            dict.Add("date",new DateTime(2017,12,25));
            var res = JsonConvert.SerializeObject(dict, new CustomObjectTypeSerializer( new Dictionary<Type, string>()));
            Assert.AreEqual(res,"{\"day\":\"christmas\",\"date\":1514160000000.0}");
        }

        [Test]
        public void serializeCustomObjectDateTimeTest()
        {
            Person person = new Person();
            person.age = 23;
            person.name = "nick";
            person.dateTime = new DateTime(2017,12,25);
            Dictionary<Type, string> tr = new Dictionary<Type, string>();
            tr.Add(typeof(Person),"svm.hello_bpm.Person");
            var json = JsonConvert.SerializeObject(person, new CustomObjectTypeSerializer(tr));
            Console.WriteLine(json);

        }

        [Test]
        public void deserializeDateTimeTest()
        {
            dynamic res = JsonConvert.DeserializeObject("{'day':'christmas','date':1514160000000.0}", typeof(object),
            new CustomObjectTypeDeserializer(new Dictionary<string, Type>()));
            Assert.AreEqual(res.date, new DateTime(2017, 12, 25));
        }


        [Test]
        public void deserializeCustomObjectDateTime()
        {
            Dictionary<string, Type> tr = new Dictionary<string, Type>();
            tr.Add("svm.hello_bpm.Person",typeof(Person));
            var person =
                "{'person': {'svm.hello_bpm.Person': {'name': 'nick', 'age': 23, 'dateTime': 1485814503946 }}}";
            dynamic res = JsonConvert.DeserializeObject(person, typeof(object), new CustomObjectTypeDeserializer(tr));
            Person convertedPerson = (Person) res.person;
            Assert.IsInstanceOf<DateTime>(convertedPerson.dateTime);
        }
    }
}
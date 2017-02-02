/* 
 * project
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1-SNAPSHOT
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using RestSharp.Deserializers;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProcessVarsTests
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
            instance.Configuration.Password = "kieserver1!";
            instance.Configuration.ApiClient.AddToTypeRegistry("svm.hello_bpm.Person", typeof(Person));
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        
        /// <summary>
        /// Test ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGet
        /// </summary>
        [Test]
        public void ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGetTest()
        {
            string containerId = "SVMContainer";
            int? pInstanceId = 2;
            dynamic response = instance.ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGet(containerId, pInstanceId);
            Console.WriteLine(response.person);
            Person person = (Person) response.person;

            Console.WriteLine("\n \n \n" + person.name);
            Console.WriteLine(response.occupation);
            Console.WriteLine(response.salary);
            Assert.IsInstanceOf<Object> (response, "response is Object");
        }

        [Test]
        public void customDeserializerTest()
        {
            Dictionary<string, Type> typeRegistry = new Dictionary<string, Type>
            {
                {"svm.hello_bpm.Person", typeof(Person)}
            };

            dynamic result = JsonConvert.DeserializeObject(@"{'person' : {'svm.hello_bpm.Person':{'name':'nick','age':23}}}", typeof(ExpandoObject), new CustomObjectTypeDeserializer(typeRegistry));
            IDictionary<string, object> dict = (IDictionary<string,object>) result;
            foreach (var key in dict.Keys)
            {
                Console.WriteLine(key);
                Console.WriteLine(dict[key].GetType());
            }
            Person person = (Person) result.person;
            Console.WriteLine(person.name + " " + person.age);
        }
        
    }

}
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
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

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
    public class DefaultApiTests
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
        /// Test ServerContainersIdProcessesPIdInstancesPost
        /// </summary>
        [Test]
        public void ServerContainersIdProcessesPIdInstancesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string pId = null;
            //Object body = null;
            //var response = instance.ServerContainersIdProcessesPIdInstancesPost(id, pId, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ServerQueriesContainersIdProcessInstancesGet
        /// </summary>
        [Test]
        public void ServerQueriesContainersIdProcessInstancesGetTest()
        {

            string id = "SVMContainer";
            ProcessInstanceList response = (ProcessInstanceList) instance.ServerQueriesContainersIdProcessInstancesGet(id);
            Console.WriteLine(response.ProcessInstance[0].ToString());
            Assert.IsInstanceOf<ProcessInstanceList> (response, "response is ProcessInstanceList");
        }
        
    }

}

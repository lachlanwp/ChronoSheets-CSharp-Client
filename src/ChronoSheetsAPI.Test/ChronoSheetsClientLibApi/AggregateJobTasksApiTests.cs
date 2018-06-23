/* 
 * ChronoSheets API
 *
 * An API for integrating into ChronoSheets timesheets
 *
 * OpenAPI spec version: v1
 * Contact: lachlan@chronosheets.com
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

using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace ChronoSheetsAPI.Test
{
    /// <summary>
    ///  Class for testing AggregateJobTasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AggregateJobTasksApiTests
    {
        private AggregateJobTasksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AggregateJobTasksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AggregateJobTasksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AggregateJobTasksApi
            //Assert.IsInstanceOfType(typeof(AggregateJobTasksApi), instance, "instance is a AggregateJobTasksApi");
        }

        
        /// <summary>
        /// Test AggregateJobTasksGetAggregateJobTasks
        /// </summary>
        [Test]
        public void AggregateJobTasksGetAggregateJobTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.AggregateJobTasksGetAggregateJobTasks(xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseListAggregateJobCode> (response, "response is CsApiApiResponseListAggregateJobCode");
        }
        
    }

}

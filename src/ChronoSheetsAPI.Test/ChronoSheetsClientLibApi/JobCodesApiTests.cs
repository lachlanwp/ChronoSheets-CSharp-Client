/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
 *
 * OpenAPI spec version: v1
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

using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace ChronoSheetsAPI.Test
{
    /// <summary>
    ///  Class for testing JobCodesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class JobCodesApiTests
    {
        private JobCodesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new JobCodesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JobCodesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' JobCodesApi
            //Assert.IsInstanceOfType(typeof(JobCodesApi), instance, "instance is a JobCodesApi");
        }

        
        /// <summary>
        /// Test JobCodesCreateJobCode
        /// </summary>
        [Test]
        public void JobCodesCreateJobCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CSInsertJobCodeRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.JobCodesCreateJobCode(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseInt32> (response, "response is CSApiResponseInt32");
        }
        
        /// <summary>
        /// Test JobCodesDeleteJobCode
        /// </summary>
        [Test]
        public void JobCodesDeleteJobCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobCodeId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.JobCodesDeleteJobCode(jobCodeId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseBoolean> (response, "response is CSApiResponseBoolean");
        }
        
        /// <summary>
        /// Test JobCodesGetJobCodeById
        /// </summary>
        [Test]
        public void JobCodesGetJobCodeByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobCodeId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.JobCodesGetJobCodeById(jobCodeId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseJobCode> (response, "response is CSApiResponseJobCode");
        }
        
        /// <summary>
        /// Test JobCodesGetJobCodes
        /// </summary>
        [Test]
        public void JobCodesGetJobCodesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.JobCodesGetJobCodes(xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseListJobCode> (response, "response is CSApiResponseListJobCode");
        }
        
        /// <summary>
        /// Test JobCodesUpdateJobCode
        /// </summary>
        [Test]
        public void JobCodesUpdateJobCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CSUpdateJobCodeRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.JobCodesUpdateJobCode(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseBoolean> (response, "response is CSApiResponseBoolean");
        }
        
    }

}

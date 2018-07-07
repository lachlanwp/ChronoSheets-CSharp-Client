/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
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
    ///  Class for testing UserJobFavouritesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserJobFavouritesApiTests
    {
        private UserJobFavouritesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserJobFavouritesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserJobFavouritesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserJobFavouritesApi
            //Assert.IsInstanceOfType(typeof(UserJobFavouritesApi), instance, "instance is a UserJobFavouritesApi");
        }

        
        /// <summary>
        /// Test UserJobFavouritesCreateJobFavourite
        /// </summary>
        [Test]
        public void UserJobFavouritesCreateJobFavouriteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CSInsertUserJobFavouriteRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.UserJobFavouritesCreateJobFavourite(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseInt32> (response, "response is CSApiResponseInt32");
        }
        
        /// <summary>
        /// Test UserJobFavouritesDeleteJobFavourite
        /// </summary>
        [Test]
        public void UserJobFavouritesDeleteJobFavouriteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.UserJobFavouritesDeleteJobFavourite(jobId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseBoolean> (response, "response is CSApiResponseBoolean");
        }
        
        /// <summary>
        /// Test UserJobFavouritesGetJobFavourites
        /// </summary>
        [Test]
        public void UserJobFavouritesGetJobFavouritesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.UserJobFavouritesGetJobFavourites(xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseListUserJobFavourite> (response, "response is CSApiResponseListUserJobFavourite");
        }
        
    }

}

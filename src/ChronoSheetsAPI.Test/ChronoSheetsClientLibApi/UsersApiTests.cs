/* 
 * ChronoSheets API
 *
 * ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.
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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsInstanceOfType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test UsersCreateTimesheetUser
        /// </summary>
        [Test]
        public void UsersCreateTimesheetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CsApiInsertUserRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.UsersCreateTimesheetUser(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseInsertUserResponse> (response, "response is CsApiApiResponseInsertUserResponse");
        }
        
        /// <summary>
        /// Test UsersGetTimesheetUser
        /// </summary>
        [Test]
        public void UsersGetTimesheetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.UsersGetTimesheetUser(userId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseUserForManagement> (response, "response is CsApiApiResponseUserForManagement");
        }
        
        /// <summary>
        /// Test UsersGetTimesheetUsers
        /// </summary>
        [Test]
        public void UsersGetTimesheetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.UsersGetTimesheetUsers(xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseListUserForManagement> (response, "response is CsApiApiResponseListUserForManagement");
        }
        
        /// <summary>
        /// Test UsersUpdateTimesheetUser
        /// </summary>
        [Test]
        public void UsersUpdateTimesheetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CsApiUpdateUserRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.UsersUpdateTimesheetUser(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseUpdateUserResponse> (response, "response is CsApiApiResponseUpdateUserResponse");
        }
        
    }

}

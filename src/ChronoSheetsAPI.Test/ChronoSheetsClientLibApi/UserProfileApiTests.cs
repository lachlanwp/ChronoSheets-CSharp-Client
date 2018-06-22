/* 
 * ChronoSheets API Documentation
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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
    ///  Class for testing UserProfileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserProfileApiTests
    {
        private UserProfileApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserProfileApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserProfileApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserProfileApi
            //Assert.IsInstanceOfType(typeof(UserProfileApi), instance, "instance is a UserProfileApi");
        }

        
        /// <summary>
        /// Test UserProfileDoLogin
        /// </summary>
        [Test]
        public void UserProfileDoLoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CsApiDoLoginRequest request = null;
            //var response = instance.UserProfileDoLogin(request);
            //Assert.IsInstanceOf<CsApiApiResponseDoLoginResponse> (response, "response is CsApiApiResponseDoLoginResponse");
        }
        
        /// <summary>
        /// Test UserProfileDoLogout
        /// </summary>
        [Test]
        public void UserProfileDoLogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.UserProfileDoLogout(xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseBoolean> (response, "response is CsApiApiResponseBoolean");
        }
        
        /// <summary>
        /// Test UserProfileGetMyProfile
        /// </summary>
        [Test]
        public void UserProfileGetMyProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.UserProfileGetMyProfile(xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseUserProfile> (response, "response is CsApiApiResponseUserProfile");
        }
        
        /// <summary>
        /// Test UserProfileKeepSessionAlive
        /// </summary>
        [Test]
        public void UserProfileKeepSessionAliveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.UserProfileKeepSessionAlive(xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseBoolean> (response, "response is CsApiApiResponseBoolean");
        }
        
        /// <summary>
        /// Test UserProfileUpdateMyProfile
        /// </summary>
        [Test]
        public void UserProfileUpdateMyProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CsApiUpdateMyProfileRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.UserProfileUpdateMyProfile(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseSignupResponse> (response, "response is CsApiApiResponseSignupResponse");
        }
        
    }

}

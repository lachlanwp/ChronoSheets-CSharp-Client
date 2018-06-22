/* 
 * ChronoSheets API
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
    ///  Class for testing OrganisationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrganisationApiTests
    {
        private OrganisationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganisationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganisationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrganisationApi
            //Assert.IsInstanceOfType(typeof(OrganisationApi), instance, "instance is a OrganisationApi");
        }

        
        /// <summary>
        /// Test OrganisationGetOrganisation
        /// </summary>
        [Test]
        public void OrganisationGetOrganisationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.OrganisationGetOrganisation(xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseOrganisation> (response, "response is CsApiApiResponseOrganisation");
        }
        
        /// <summary>
        /// Test OrganisationUpdateOrganisation
        /// </summary>
        [Test]
        public void OrganisationUpdateOrganisationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CsApiUpdateOrganisationRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.OrganisationUpdateOrganisation(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseUpdateOrganisationResponse> (response, "response is CsApiApiResponseUpdateOrganisationResponse");
        }
        
    }

}

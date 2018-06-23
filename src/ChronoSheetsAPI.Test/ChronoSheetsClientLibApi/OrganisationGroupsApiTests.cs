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
    ///  Class for testing OrganisationGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrganisationGroupsApiTests
    {
        private OrganisationGroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganisationGroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganisationGroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrganisationGroupsApi
            //Assert.IsInstanceOfType(typeof(OrganisationGroupsApi), instance, "instance is a OrganisationGroupsApi");
        }

        
        /// <summary>
        /// Test OrganisationGroupsCreateOrganisationGroup
        /// </summary>
        [Test]
        public void OrganisationGroupsCreateOrganisationGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CsApiInsertOrganisationGroupRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.OrganisationGroupsCreateOrganisationGroup(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseInt32> (response, "response is CsApiApiResponseInt32");
        }
        
        /// <summary>
        /// Test OrganisationGroupsGetOrganisationGroup
        /// </summary>
        [Test]
        public void OrganisationGroupsGetOrganisationGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? organisationGroupId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.OrganisationGroupsGetOrganisationGroup(organisationGroupId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseOrganisationGroup> (response, "response is CsApiApiResponseOrganisationGroup");
        }
        
        /// <summary>
        /// Test OrganisationGroupsGetOrganisationGroups
        /// </summary>
        [Test]
        public void OrganisationGroupsGetOrganisationGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xChronosheetsAuth = null;
            //var response = instance.OrganisationGroupsGetOrganisationGroups(xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseListOrganisationGroup> (response, "response is CsApiApiResponseListOrganisationGroup");
        }
        
        /// <summary>
        /// Test OrganisationGroupsGetOrganisationGroupsForJob
        /// </summary>
        [Test]
        public void OrganisationGroupsGetOrganisationGroupsForJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.OrganisationGroupsGetOrganisationGroupsForJob(jobId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseListOrganisationGroup> (response, "response is CsApiApiResponseListOrganisationGroup");
        }
        
        /// <summary>
        /// Test OrganisationGroupsGetOrganisationGroupsForVehicle
        /// </summary>
        [Test]
        public void OrganisationGroupsGetOrganisationGroupsForVehicleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? vehicleId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.OrganisationGroupsGetOrganisationGroupsForVehicle(vehicleId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseListOrganisationGroup> (response, "response is CsApiApiResponseListOrganisationGroup");
        }
        
        /// <summary>
        /// Test OrganisationGroupsUpdateOrganisationGroup
        /// </summary>
        [Test]
        public void OrganisationGroupsUpdateOrganisationGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CsApiSaveOrganisationGroupRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.OrganisationGroupsUpdateOrganisationGroup(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseBoolean> (response, "response is CsApiApiResponseBoolean");
        }
        
    }

}

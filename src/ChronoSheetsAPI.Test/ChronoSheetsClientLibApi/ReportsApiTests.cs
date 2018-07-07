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
    ///  Class for testing ReportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportsApiTests
    {
        private ReportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportsApi
            //Assert.IsInstanceOfType(typeof(ReportsApi), instance, "instance is a ReportsApi");
        }

        
        /// <summary>
        /// Test ReportsGetAllChartsDataAdmin
        /// </summary>
        [Test]
        public void ReportsGetAllChartsDataAdminTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string userIds = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ReportsGetAllChartsDataAdmin(startDate, endDate, userIds, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseCombinedReportsData> (response, "response is CSApiResponseCombinedReportsData");
        }
        
        /// <summary>
        /// Test ReportsGetAllChartsDataUser
        /// </summary>
        [Test]
        public void ReportsGetAllChartsDataUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ReportsGetAllChartsDataUser(startDate, endDate, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseCombinedReportsData> (response, "response is CSApiResponseCombinedReportsData");
        }
        
        /// <summary>
        /// Test ReportsGetOrgTripById
        /// </summary>
        [Test]
        public void ReportsGetOrgTripByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? tripId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ReportsGetOrgTripById(tripId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseTrip> (response, "response is CSApiResponseTrip");
        }
        
        /// <summary>
        /// Test ReportsGetOrganisationTimesheetFileAttachments
        /// </summary>
        [Test]
        public void ReportsGetOrganisationTimesheetFileAttachmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? skip = null;
            //int? take = null;
            //string userIds = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ReportsGetOrganisationTimesheetFileAttachments(startDate, endDate, skip, take, userIds, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseForPaginatedListOrgReportTimesheetFileAttachment> (response, "response is CSApiResponseForPaginatedListOrgReportTimesheetFileAttachment");
        }
        
        /// <summary>
        /// Test ReportsGetOrganisationTrips
        /// </summary>
        [Test]
        public void ReportsGetOrganisationTripsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? skip = null;
            //int? take = null;
            //string userIds = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ReportsGetOrganisationTrips(startDate, endDate, skip, take, userIds, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseForPaginatedListOrgReportTrip> (response, "response is CSApiResponseForPaginatedListOrgReportTrip");
        }
        
        /// <summary>
        /// Test ReportsGetRawDataAdmin
        /// </summary>
        [Test]
        public void ReportsGetRawDataAdminTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string userIds = null;
            //string sort = null;
            //string order = null;
            //int? skip = null;
            //int? take = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ReportsGetRawDataAdmin(startDate, endDate, userIds, sort, order, skip, take, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseForPaginatedListRawReportItem> (response, "response is CSApiResponseForPaginatedListRawReportItem");
        }
        
        /// <summary>
        /// Test ReportsProjectCostingsAdmin
        /// </summary>
        [Test]
        public void ReportsProjectCostingsAdminTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string userIds = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ReportsProjectCostingsAdmin(startDate, endDate, userIds, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseListProjectCostingReportItem> (response, "response is CSApiResponseListProjectCostingReportItem");
        }
        
        /// <summary>
        /// Test ReportsUserJobsOverTime
        /// </summary>
        [Test]
        public void ReportsUserJobsOverTimeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string xChronosheetsAuth = null;
            //var response = instance.ReportsUserJobsOverTime(startDate, endDate, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseListJobSeriesReportItem> (response, "response is CSApiResponseListJobSeriesReportItem");
        }
        
    }

}

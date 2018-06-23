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
    ///  Class for testing TripsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TripsApiTests
    {
        private TripsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TripsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TripsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TripsApi
            //Assert.IsInstanceOfType(typeof(TripsApi), instance, "instance is a TripsApi");
        }

        
        /// <summary>
        /// Test TripsCreateTrip
        /// </summary>
        [Test]
        public void TripsCreateTripTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CsApiCreateTripRequest request = null;
            //string xChronosheetsAuth = null;
            //var response = instance.TripsCreateTrip(request, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseInt32> (response, "response is CsApiApiResponseInt32");
        }
        
        /// <summary>
        /// Test TripsGetMyTripById
        /// </summary>
        [Test]
        public void TripsGetMyTripByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? tripId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.TripsGetMyTripById(tripId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseTrip> (response, "response is CsApiApiResponseTrip");
        }
        
        /// <summary>
        /// Test TripsGetMyTrips
        /// </summary>
        [Test]
        public void TripsGetMyTripsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? skip = null;
            //int? take = null;
            //int? vehicleId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.TripsGetMyTrips(startDate, endDate, skip, take, vehicleId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CsApiApiResponseForPaginatedListTrip> (response, "response is CsApiApiResponseForPaginatedListTrip");
        }
        
    }

}

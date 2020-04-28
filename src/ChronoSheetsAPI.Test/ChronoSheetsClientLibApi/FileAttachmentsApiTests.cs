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
    ///  Class for testing FileAttachmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FileAttachmentsApiTests
    {
        private FileAttachmentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FileAttachmentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FileAttachmentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FileAttachmentsApi
            //Assert.IsInstanceOfType(typeof(FileAttachmentsApi), instance, "instance is a FileAttachmentsApi");
        }

        
        /// <summary>
        /// Test FileAttachmentsDeleteTimesheetFileAttachment
        /// </summary>
        [Test]
        public void FileAttachmentsDeleteTimesheetFileAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fileAttachmentId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.FileAttachmentsDeleteTimesheetFileAttachment(fileAttachmentId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseBoolean> (response, "response is CSApiResponseBoolean");
        }
        
        /// <summary>
        /// Test FileAttachmentsGetFileAttachmentById
        /// </summary>
        [Test]
        public void FileAttachmentsGetFileAttachmentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fileAttachmentId = null;
            //string xChronosheetsAuth = null;
            //var response = instance.FileAttachmentsGetFileAttachmentById(fileAttachmentId, xChronosheetsAuth);
            //Assert.IsInstanceOf<CSApiResponseTimesheetFileAttachment> (response, "response is CSApiResponseTimesheetFileAttachment");
        }
        
        /// <summary>
        /// Test FileAttachmentsGetMyFileAttachments
        /// </summary>
        [Test]
        public void FileAttachmentsGetMyFileAttachmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string xChronosheetsAuth = null;
            //int? skip = null;
            //int? take = null;
            //var response = instance.FileAttachmentsGetMyFileAttachments(startDate, endDate, xChronosheetsAuth, skip, take);
            //Assert.IsInstanceOf<CSApiResponseForPaginatedListTimesheetFileAttachment> (response, "response is CSApiResponseForPaginatedListTimesheetFileAttachment");
        }
        
    }

}

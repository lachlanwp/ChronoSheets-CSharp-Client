# ChronoSheetsAPI - the C# library for the ChronoSheets API

No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v1
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out ChronoSheetsAPI.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new AggregateJobTasksApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get jobs and tasks information, aggregated
                CsApiApiResponseListAggregateJobCode result = apiInstance.AggregateJobTasksGetAggregateJobTasks(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregateJobTasksApi.AggregateJobTasksGetAggregateJobTasks: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://www.chronosheets.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AggregateJobTasksApi* | [**AggregateJobTasksGetAggregateJobTasks**](docs/AggregateJobTasksApi.md#aggregatejobtasksgetaggregatejobtasks) | **GET** /api/AggregateJobTasks/GetAggregateJobTasks | Get jobs and tasks information, aggregated
*ClientsApi* | [**ClientsCreateClient**](docs/ClientsApi.md#clientscreateclient) | **PUT** /api/Clients/CreateClient | Create a client
*ClientsApi* | [**ClientsGetClient**](docs/ClientsApi.md#clientsgetclient) | **GET** /api/Clients/GetClient | Get a particular client
*ClientsApi* | [**ClientsGetClients**](docs/ClientsApi.md#clientsgetclients) | **GET** /api/Clients/GetClients | Get a collection of clients that are under your organisation
*ClientsApi* | [**ClientsUpdateClient**](docs/ClientsApi.md#clientsupdateclient) | **POST** /api/Clients/UpdateClient | Update a client
*FleetApi* | [**FleetCreateVehicle**](docs/FleetApi.md#fleetcreatevehicle) | **PUT** /api/Fleet/CreateVehicle | Create a vehicle
*FleetApi* | [**FleetGetVehicleById**](docs/FleetApi.md#fleetgetvehiclebyid) | **GET** /api/Fleet/GetVehicleById | Get a particular vehicle
*FleetApi* | [**FleetGetVehicles**](docs/FleetApi.md#fleetgetvehicles) | **GET** /api/Fleet/GetVehicles | Get a collection of vehicles that are under your organisation
*FleetApi* | [**FleetUpdateVehicle**](docs/FleetApi.md#fleetupdatevehicle) | **POST** /api/Fleet/UpdateVehicle | Update a vehicle
*JobCodesApi* | [**JobCodesCreateJobCode**](docs/JobCodesApi.md#jobcodescreatejobcode) | **PUT** /api/JobCodes/CreateJobCode | Create a job code
*JobCodesApi* | [**JobCodesDeleteJobCode**](docs/JobCodesApi.md#jobcodesdeletejobcode) | **DELETE** /api/JobCodes/DeleteJobCode | Delete a job code
*JobCodesApi* | [**JobCodesGetJobCodeById**](docs/JobCodesApi.md#jobcodesgetjobcodebyid) | **GET** /api/JobCodes/GetJobCodeById | Get a particular job code by job code id
*JobCodesApi* | [**JobCodesGetJobCodes**](docs/JobCodesApi.md#jobcodesgetjobcodes) | **GET** /api/JobCodes/GetJobCodes | Get job codes for your organisation
*JobCodesApi* | [**JobCodesUpdateJobCode**](docs/JobCodesApi.md#jobcodesupdatejobcode) | **POST** /api/JobCodes/UpdateJobCode | Update a job code
*OrganisationApi* | [**OrganisationGetOrganisation**](docs/OrganisationApi.md#organisationgetorganisation) | **GET** /api/Organisation/GetOrganisation | Get your organisation.  Requires 'OrganisationAdmin' permission.
*OrganisationApi* | [**OrganisationUpdateOrganisation**](docs/OrganisationApi.md#organisationupdateorganisation) | **POST** /api/Organisation/UpdateOrganisation | Update an organisation.  Requires 'OrganisationAdmin' permission.
*OrganisationGroupUsersApi* | [**OrganisationGroupUsersGetOrganisationGroupUsers**](docs/OrganisationGroupUsersApi.md#organisationgroupusersgetorganisationgroupusers) | **GET** /api/OrganisationGroupUsers/GetOrganisationGroupUsers | Get a collection of organisation group users that belong to an organisation group
*OrganisationGroupUsersApi* | [**OrganisationGroupUsersUpdateOrganisationGroupUsers**](docs/OrganisationGroupUsersApi.md#organisationgroupusersupdateorganisationgroupusers) | **POST** /api/OrganisationGroupUsers/UpdateOrganisationGroupUsers | Set the users who belong to an organisation group
*OrganisationGroupsApi* | [**OrganisationGroupsCreateOrganisationGroup**](docs/OrganisationGroupsApi.md#organisationgroupscreateorganisationgroup) | **PUT** /api/OrganisationGroups/CreateOrganisationGroup | Create an organisation group
*OrganisationGroupsApi* | [**OrganisationGroupsGetOrganisationGroup**](docs/OrganisationGroupsApi.md#organisationgroupsgetorganisationgroup) | **GET** /api/OrganisationGroups/GetOrganisationGroup | Get a particular organisation group
*OrganisationGroupsApi* | [**OrganisationGroupsGetOrganisationGroups**](docs/OrganisationGroupsApi.md#organisationgroupsgetorganisationgroups) | **GET** /api/OrganisationGroups/GetOrganisationGroups | Get a collection of organisation groups that are under your organisation
*OrganisationGroupsApi* | [**OrganisationGroupsGetOrganisationGroupsForJob**](docs/OrganisationGroupsApi.md#organisationgroupsgetorganisationgroupsforjob) | **GET** /api/OrganisationGroups/GetOrganisationGroupsForJob | Get org groups for a particular job
*OrganisationGroupsApi* | [**OrganisationGroupsGetOrganisationGroupsForVehicle**](docs/OrganisationGroupsApi.md#organisationgroupsgetorganisationgroupsforvehicle) | **GET** /api/OrganisationGroups/GetOrganisationGroupsForVehicle | Get org groups for a particular vehicle
*OrganisationGroupsApi* | [**OrganisationGroupsUpdateOrganisationGroup**](docs/OrganisationGroupsApi.md#organisationgroupsupdateorganisationgroup) | **POST** /api/OrganisationGroups/UpdateOrganisationGroup | Update an organisation group
*ProjectsApi* | [**ProjectsCreateProject**](docs/ProjectsApi.md#projectscreateproject) | **PUT** /api/Projects/CreateProject | Create a project
*ProjectsApi* | [**ProjectsGetProjectById**](docs/ProjectsApi.md#projectsgetprojectbyid) | **GET** /api/Projects/GetProjectById | Get project by Id
*ProjectsApi* | [**ProjectsGetProjectsForClient**](docs/ProjectsApi.md#projectsgetprojectsforclient) | **GET** /api/Projects/GetProjectsForClient | Get projects for a particular client
*ProjectsApi* | [**ProjectsUpdateProject**](docs/ProjectsApi.md#projectsupdateproject) | **POST** /api/Projects/UpdateProject | Update a project
*ReportsApi* | [**ReportsGetAllChartsDataAdmin**](docs/ReportsApi.md#reportsgetallchartsdataadmin) | **GET** /api/Reports/GetAllChartsDataAdmin | Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects)
*ReportsApi* | [**ReportsGetAllChartsDataUser**](docs/ReportsApi.md#reportsgetallchartsdatauser) | **GET** /api/Reports/GetAllChartsDataUser | Get Consolidated User Reports Data (Jobs and Tasks)
*ReportsApi* | [**ReportsGetOrgTripById**](docs/ReportsApi.md#reportsgetorgtripbyid) | **GET** /api/Reports/GetOrgTripById | Get trip by Id, for reporting purposes
*ReportsApi* | [**ReportsGetOrganisationTimesheetFileAttachments**](docs/ReportsApi.md#reportsgetorganisationtimesheetfileattachments) | **GET** /api/Reports/GetOrganisationTimesheetFileAttachments | Reports on Organisation timesheet file attachments
*ReportsApi* | [**ReportsGetOrganisationTrips**](docs/ReportsApi.md#reportsgetorganisationtrips) | **GET** /api/Reports/GetOrganisationTrips | Reports on Organisation trips (GPS tracking from whole organisation)
*ReportsApi* | [**ReportsGetRawDataAdmin**](docs/ReportsApi.md#reportsgetrawdataadmin) | **GET** /api/Reports/GetRawDataAdmin | Get Timesheets Raw Data
*ReportsApi* | [**ReportsProjectCostingsAdmin**](docs/ReportsApi.md#reportsprojectcostingsadmin) | **GET** /api/Reports/ProjectCostingsAdmin | Gets project cost estimations VS actual cost for date range and users
*ReportsApi* | [**ReportsUserJobsOverTime**](docs/ReportsApi.md#reportsuserjobsovertime) | **GET** /api/Reports/UserJobsOverTime | Timeseries jobs data for the logged in user
*TasksApi* | [**TasksCreateTask**](docs/TasksApi.md#taskscreatetask) | **PUT** /api/Tasks/CreateTask | Create a task
*TasksApi* | [**TasksDeleteTask**](docs/TasksApi.md#tasksdeletetask) | **DELETE** /api/Tasks/DeleteTask | Delete a task
*TasksApi* | [**TasksGetTaskById**](docs/TasksApi.md#tasksgettaskbyid) | **GET** /api/Tasks/GetTaskById | Get a particular task by id
*TasksApi* | [**TasksGetTasks**](docs/TasksApi.md#tasksgettasks) | **GET** /api/Tasks/GetTasks | Get tasks in your organisation
*TasksApi* | [**TasksGetTasksForJob**](docs/TasksApi.md#tasksgettasksforjob) | **GET** /api/Tasks/GetTasksForJob | Get tasks for a particular job
*TasksApi* | [**TasksUpdateTask**](docs/TasksApi.md#tasksupdatetask) | **POST** /api/Tasks/UpdateTask | Update a task
*TimesheetsApi* | [**TimesheetsDeleteTimesheet**](docs/TimesheetsApi.md#timesheetsdeletetimesheet) | **DELETE** /api/Timesheets/DeleteTimesheet | Delete a timesheet
*TimesheetsApi* | [**TimesheetsGetTimesheets**](docs/TimesheetsApi.md#timesheetsgettimesheets) | **GET** /api/Timesheets/GetTimesheets | Get timesheets between start and end dates
*TimesheetsApi* | [**TimesheetsInsertSingleTimesheet**](docs/TimesheetsApi.md#timesheetsinsertsingletimesheet) | **PUT** /api/Timesheets/InsertSingleTimesheet | Inserts a single timesheet record
*TimesheetsApi* | [**TimesheetsUpdateTimesheets**](docs/TimesheetsApi.md#timesheetsupdatetimesheets) | **POST** /api/Timesheets/UpdateTimesheets | Batch update timesheets
*TripsApi* | [**TripsCreateTrip**](docs/TripsApi.md#tripscreatetrip) | **POST** /api/Trips/CreateTrip | Create a new trip.  Important: create a timesheet record before calling this, passing in the new timesheet record id as a reference.
*TripsApi* | [**TripsGetMyTripById**](docs/TripsApi.md#tripsgetmytripbyid) | **GET** /api/Trips/GetMyTripById | Get trip by Id
*TripsApi* | [**TripsGetMyTrips**](docs/TripsApi.md#tripsgetmytrips) | **GET** /api/Trips/GetMyTrips | Get my trips
*UserJobFavouritesApi* | [**UserJobFavouritesCreateJobFavourite**](docs/UserJobFavouritesApi.md#userjobfavouritescreatejobfavourite) | **PUT** /api/UserJobFavourites/CreateJobFavourite | Create a job favourite
*UserJobFavouritesApi* | [**UserJobFavouritesDeleteJobFavourite**](docs/UserJobFavouritesApi.md#userjobfavouritesdeletejobfavourite) | **DELETE** /api/UserJobFavourites/DeleteJobFavourite | Delete a job favourite
*UserJobFavouritesApi* | [**UserJobFavouritesGetJobFavourites**](docs/UserJobFavouritesApi.md#userjobfavouritesgetjobfavourites) | **GET** /api/UserJobFavourites/GetJobFavourites | Get your job favourites
*UserPayRatesApi* | [**UserPayRatesCreatePayRate**](docs/UserPayRatesApi.md#userpayratescreatepayrate) | **PUT** /api/UserPayRates/CreatePayRate | Create a new pay rate for a particular user, archiving the previous pay rate
*UserPayRatesApi* | [**UserPayRatesGetPayRates**](docs/UserPayRatesApi.md#userpayratesgetpayrates) | **GET** /api/UserPayRates/GetPayRates | Get a collection of pay rates for a particular user, specified by user id
*UserProfileApi* | [**UserProfileDoLogin**](docs/UserProfileApi.md#userprofiledologin) | **POST** /api/UserProfile/DoLogin | 
*UserProfileApi* | [**UserProfileDoLogout**](docs/UserProfileApi.md#userprofiledologout) | **DELETE** /api/UserProfile/DoLogout | 
*UserProfileApi* | [**UserProfileGetMyProfile**](docs/UserProfileApi.md#userprofilegetmyprofile) | **GET** /api/UserProfile/GetMyProfile | 
*UserProfileApi* | [**UserProfileKeepSessionAlive**](docs/UserProfileApi.md#userprofilekeepsessionalive) | **GET** /api/UserProfile/KeepSessionAlive | 
*UserProfileApi* | [**UserProfileUpdateMyProfile**](docs/UserProfileApi.md#userprofileupdatemyprofile) | **POST** /api/UserProfile/UpdateMyProfile | 
*UsersApi* | [**UsersCreateTimesheetUser**](docs/UsersApi.md#userscreatetimesheetuser) | **PUT** /api/Users/CreateTimesheetUser | Create a user in your organisation
*UsersApi* | [**UsersGetTimesheetUser**](docs/UsersApi.md#usersgettimesheetuser) | **GET** /api/Users/GetTimesheetUser | Get a particular user in your organisation
*UsersApi* | [**UsersGetTimesheetUsers**](docs/UsersApi.md#usersgettimesheetusers) | **GET** /api/Users/GetTimesheetUsers | Get users for your organisation
*UsersApi* | [**UsersUpdateTimesheetUser**](docs/UsersApi.md#usersupdatetimesheetuser) | **POST** /api/Users/UpdateTimesheetUser | Update a user
*UsualHoursApi* | [**UsualHoursGetUsualHours**](docs/UsualHoursApi.md#usualhoursgetusualhours) | **GET** /api/UsualHours/GetUsualHours | Get usual hours (rostered hours) for an employee
*UsualHoursApi* | [**UsualHoursSetUsualHours**](docs/UsualHoursApi.md#usualhourssetusualhours) | **POST** /api/UsualHours/SetUsualHours | Set usual hours (rostered hours) for an employee


<a name="documentation-for-models"></a>
## Documentation for Models

 - [ChronoSheetsClientLibModel.CsApiAggregateJobCode](docs/CsApiAggregateJobCode.md)
 - [ChronoSheetsClientLibModel.CsApiAggregateJobTask](docs/CsApiAggregateJobTask.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseBoolean](docs/CsApiApiResponseBoolean.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseClient](docs/CsApiApiResponseClient.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseCombinedReportsData](docs/CsApiApiResponseCombinedReportsData.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseDoLoginResponse](docs/CsApiApiResponseDoLoginResponse.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseFleetVehicle](docs/CsApiApiResponseFleetVehicle.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseForPaginatedListOrgReportTimesheetFileAttachment](docs/CsApiApiResponseForPaginatedListOrgReportTimesheetFileAttachment.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseForPaginatedListOrgReportTrip](docs/CsApiApiResponseForPaginatedListOrgReportTrip.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseForPaginatedListRawReportItem](docs/CsApiApiResponseForPaginatedListRawReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseForPaginatedListTrip](docs/CsApiApiResponseForPaginatedListTrip.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseInsertUserResponse](docs/CsApiApiResponseInsertUserResponse.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseInt32](docs/CsApiApiResponseInt32.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseJobCode](docs/CsApiApiResponseJobCode.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListAggregateJobCode](docs/CsApiApiResponseListAggregateJobCode.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListClient](docs/CsApiApiResponseListClient.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListFleetVehicle](docs/CsApiApiResponseListFleetVehicle.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListInt32](docs/CsApiApiResponseListInt32.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListJobCode](docs/CsApiApiResponseListJobCode.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListJobSeriesReportItem](docs/CsApiApiResponseListJobSeriesReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListOrganisationGroup](docs/CsApiApiResponseListOrganisationGroup.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListProject](docs/CsApiApiResponseListProject.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListProjectCostingReportItem](docs/CsApiApiResponseListProjectCostingReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListTimesheet](docs/CsApiApiResponseListTimesheet.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListTimesheetTask](docs/CsApiApiResponseListTimesheetTask.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListUserForManagement](docs/CsApiApiResponseListUserForManagement.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListUserHourlyRate](docs/CsApiApiResponseListUserHourlyRate.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListUserJobFavourite](docs/CsApiApiResponseListUserJobFavourite.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseListUsualHoursDay](docs/CsApiApiResponseListUsualHoursDay.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseOrganisation](docs/CsApiApiResponseOrganisation.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseOrganisationGroup](docs/CsApiApiResponseOrganisationGroup.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseProject](docs/CsApiApiResponseProject.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseSignupResponse](docs/CsApiApiResponseSignupResponse.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseTimesheetTask](docs/CsApiApiResponseTimesheetTask.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseTrip](docs/CsApiApiResponseTrip.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseUpdateOrganisationResponse](docs/CsApiApiResponseUpdateOrganisationResponse.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseUpdateUserResponse](docs/CsApiApiResponseUpdateUserResponse.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseUserForManagement](docs/CsApiApiResponseUserForManagement.md)
 - [ChronoSheetsClientLibModel.CsApiApiResponseUserProfile](docs/CsApiApiResponseUserProfile.md)
 - [ChronoSheetsClientLibModel.CsApiBatchUpdateTimesheetRequest](docs/CsApiBatchUpdateTimesheetRequest.md)
 - [ChronoSheetsClientLibModel.CsApiClient](docs/CsApiClient.md)
 - [ChronoSheetsClientLibModel.CsApiClientSeriesReportItem](docs/CsApiClientSeriesReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiClientSideUser](docs/CsApiClientSideUser.md)
 - [ChronoSheetsClientLibModel.CsApiClientTotalsReportItem](docs/CsApiClientTotalsReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiCombinedReportsData](docs/CsApiCombinedReportsData.md)
 - [ChronoSheetsClientLibModel.CsApiCreateTripRequest](docs/CsApiCreateTripRequest.md)
 - [ChronoSheetsClientLibModel.CsApiDoLoginRequest](docs/CsApiDoLoginRequest.md)
 - [ChronoSheetsClientLibModel.CsApiDoLoginResponse](docs/CsApiDoLoginResponse.md)
 - [ChronoSheetsClientLibModel.CsApiFleetVehicle](docs/CsApiFleetVehicle.md)
 - [ChronoSheetsClientLibModel.CsApiInsertClientRequest](docs/CsApiInsertClientRequest.md)
 - [ChronoSheetsClientLibModel.CsApiInsertJobCodeRequest](docs/CsApiInsertJobCodeRequest.md)
 - [ChronoSheetsClientLibModel.CsApiInsertOrganisationGroupRequest](docs/CsApiInsertOrganisationGroupRequest.md)
 - [ChronoSheetsClientLibModel.CsApiInsertProjectRequest](docs/CsApiInsertProjectRequest.md)
 - [ChronoSheetsClientLibModel.CsApiInsertTaskRequest](docs/CsApiInsertTaskRequest.md)
 - [ChronoSheetsClientLibModel.CsApiInsertUserHourlyRateRequest](docs/CsApiInsertUserHourlyRateRequest.md)
 - [ChronoSheetsClientLibModel.CsApiInsertUserJobFavouriteRequest](docs/CsApiInsertUserJobFavouriteRequest.md)
 - [ChronoSheetsClientLibModel.CsApiInsertUserRequest](docs/CsApiInsertUserRequest.md)
 - [ChronoSheetsClientLibModel.CsApiInsertUserResponse](docs/CsApiInsertUserResponse.md)
 - [ChronoSheetsClientLibModel.CsApiInsertVehicleRequest](docs/CsApiInsertVehicleRequest.md)
 - [ChronoSheetsClientLibModel.CsApiJobCode](docs/CsApiJobCode.md)
 - [ChronoSheetsClientLibModel.CsApiJobSeriesReportItem](docs/CsApiJobSeriesReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiJobTotalsReportItem](docs/CsApiJobTotalsReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiOrgReportTimesheetFileAttachment](docs/CsApiOrgReportTimesheetFileAttachment.md)
 - [ChronoSheetsClientLibModel.CsApiOrgReportTrip](docs/CsApiOrgReportTrip.md)
 - [ChronoSheetsClientLibModel.CsApiOrganisation](docs/CsApiOrganisation.md)
 - [ChronoSheetsClientLibModel.CsApiOrganisationGroup](docs/CsApiOrganisationGroup.md)
 - [ChronoSheetsClientLibModel.CsApiProject](docs/CsApiProject.md)
 - [ChronoSheetsClientLibModel.CsApiProjectCostingReportItem](docs/CsApiProjectCostingReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiProjectSeriesReportItem](docs/CsApiProjectSeriesReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiProjectTotalsReportItem](docs/CsApiProjectTotalsReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiRawReportItem](docs/CsApiRawReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiSaveClientRequest](docs/CsApiSaveClientRequest.md)
 - [ChronoSheetsClientLibModel.CsApiSaveOrganisationGroupRequest](docs/CsApiSaveOrganisationGroupRequest.md)
 - [ChronoSheetsClientLibModel.CsApiSaveVehicleRequest](docs/CsApiSaveVehicleRequest.md)
 - [ChronoSheetsClientLibModel.CsApiSetOrganisationGroupUsersRequest](docs/CsApiSetOrganisationGroupUsersRequest.md)
 - [ChronoSheetsClientLibModel.CsApiSetUsualHoursRequest](docs/CsApiSetUsualHoursRequest.md)
 - [ChronoSheetsClientLibModel.CsApiSignupResponse](docs/CsApiSignupResponse.md)
 - [ChronoSheetsClientLibModel.CsApiTaskSeriesReportItem](docs/CsApiTaskSeriesReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiTaskTotalsReportItem](docs/CsApiTaskTotalsReportItem.md)
 - [ChronoSheetsClientLibModel.CsApiTimeSlot](docs/CsApiTimeSlot.md)
 - [ChronoSheetsClientLibModel.CsApiTimesheet](docs/CsApiTimesheet.md)
 - [ChronoSheetsClientLibModel.CsApiTimesheetTask](docs/CsApiTimesheetTask.md)
 - [ChronoSheetsClientLibModel.CsApiTrip](docs/CsApiTrip.md)
 - [ChronoSheetsClientLibModel.CsApiTripCoordinate](docs/CsApiTripCoordinate.md)
 - [ChronoSheetsClientLibModel.CsApiUpdateJobCodeRequest](docs/CsApiUpdateJobCodeRequest.md)
 - [ChronoSheetsClientLibModel.CsApiUpdateMyProfileRequest](docs/CsApiUpdateMyProfileRequest.md)
 - [ChronoSheetsClientLibModel.CsApiUpdateOrganisationRequest](docs/CsApiUpdateOrganisationRequest.md)
 - [ChronoSheetsClientLibModel.CsApiUpdateOrganisationResponse](docs/CsApiUpdateOrganisationResponse.md)
 - [ChronoSheetsClientLibModel.CsApiUpdateProjectRequest](docs/CsApiUpdateProjectRequest.md)
 - [ChronoSheetsClientLibModel.CsApiUpdateTaskRequest](docs/CsApiUpdateTaskRequest.md)
 - [ChronoSheetsClientLibModel.CsApiUpdateUserRequest](docs/CsApiUpdateUserRequest.md)
 - [ChronoSheetsClientLibModel.CsApiUpdateUserResponse](docs/CsApiUpdateUserResponse.md)
 - [ChronoSheetsClientLibModel.CsApiUserForManagement](docs/CsApiUserForManagement.md)
 - [ChronoSheetsClientLibModel.CsApiUserHourlyRate](docs/CsApiUserHourlyRate.md)
 - [ChronoSheetsClientLibModel.CsApiUserJobFavourite](docs/CsApiUserJobFavourite.md)
 - [ChronoSheetsClientLibModel.CsApiUserProfile](docs/CsApiUserProfile.md)
 - [ChronoSheetsClientLibModel.CsApiUsualHoursDay](docs/CsApiUsualHoursDay.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="x-chronosheets-auth"></a>
### x-chronosheets-auth

- **Type**: API key
- **API key parameter name**: x-chronosheets-auth
- **Location**: HTTP header


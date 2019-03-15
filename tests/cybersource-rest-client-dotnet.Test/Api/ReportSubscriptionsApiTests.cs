/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using CyberSource.Api;
using NUnit.Framework;

namespace CyberSource.Test.Api
{
    /// <summary>
    ///  Class for testing ReportSubscriptionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportSubscriptionsApiTests
    {
        private ReportSubscriptionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportSubscriptionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportSubscriptionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportSubscriptionsApi
            //Assert.IsInstanceOfType(typeof(ReportSubscriptionsApi), instance, "instance is a ReportSubscriptionsApi");
        }

        
        /// <summary>
        /// Test CreateSubscription
        /// </summary>
        [Test]
        public void CreateSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RequestBody1 requestBody = null;
            //string organizationId = null;
            //instance.CreateSubscription(requestBody, organizationId);
            
        }
        
        /// <summary>
        /// Test DeleteSubscription
        /// </summary>
        [Test]
        public void DeleteSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportName = null;
            //instance.DeleteSubscription(reportName);
            
        }
        
        /// <summary>
        /// Test GetAllSubscriptions
        /// </summary>
        [Test]
        public void GetAllSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllSubscriptions();
            //Assert.IsInstanceOf<ReportingV3ReportSubscriptionsGet200Response> (response, "response is ReportingV3ReportSubscriptionsGet200Response");
        }
        
        /// <summary>
        /// Test GetSubscription
        /// </summary>
        [Test]
        public void GetSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportName = null;
            //var response = instance.GetSubscription(reportName);
            //Assert.IsInstanceOf<ReportingV3ReportSubscriptionsGet200ResponseSubscriptions> (response, "response is ReportingV3ReportSubscriptionsGet200ResponseSubscriptions");
        }
        
    }

}

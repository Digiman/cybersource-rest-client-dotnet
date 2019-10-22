/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using CyberSource.Api;
using NUnit.Framework;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing DecisionManagerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DecisionManagerApiTests
    {
        private DecisionManagerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DecisionManagerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DecisionManagerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DecisionManagerApi
            //Assert.IsInstanceOfType(typeof(DecisionManagerApi), instance, "instance is a DecisionManagerApi");
        }

        
        /// <summary>
        /// Test CreateDecisionManagerCase
        /// </summary>
        [Test]
        public void CreateDecisionManagerCaseTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateDecisionManagerCaseRequest createDecisionManagerCaseRequest = null;
            //var response = instance.CreateDecisionManagerCase(createDecisionManagerCaseRequest);
            //Assert.IsInstanceOf<RiskV1DecisionsPost201Response> (response, "response is RiskV1DecisionsPost201Response");
        }
        
    }

}
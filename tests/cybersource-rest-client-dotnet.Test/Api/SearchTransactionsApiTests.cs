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
    ///  Class for testing SearchTransactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SearchTransactionsApiTests
    {
        private SearchTransactionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SearchTransactionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SearchTransactionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SearchTransactionsApi
            //Assert.IsInstanceOfType(typeof(SearchTransactionsApi), instance, "instance is a SearchTransactionsApi");
        }

        
        /// <summary>
        /// Test CreateSearch
        /// </summary>
        [Test]
        public void CreateSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TssV2TransactionsPostResponse createSearchRequest = null;
            //var response = instance.CreateSearch(createSearchRequest);
            //Assert.IsInstanceOf<TssV2TransactionsPost201Response> (response, "response is TssV2TransactionsPost201Response");
        }
        
        /// <summary>
        /// Test GetSearch
        /// </summary>
        [Test]
        public void GetSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetSearch(id);
            //Assert.IsInstanceOf<TssV2TransactionsPost201Response> (response, "response is TssV2TransactionsPost201Response");
        }
        
    }

}

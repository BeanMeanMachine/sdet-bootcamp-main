﻿using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;

namespace SdetBootcampDay3.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        private const string BASE_URL = "http://jsonplaceholder.typicode.com";

        private RestClient client;

        [OneTimeSetUp]
        public void SetupRestSharpClient()
        {
            client = new RestClient(BASE_URL);
        }

        /**
         * TODO: rewrite these three tests into a single parameterized test
         * If you're stuck, have a look at the exercises for Day 1, as we
         * did the exact same thing there (just for a unit test instead of an API test).
         * Do this either using the [TestCase] attribute, or using [TestDataSource] combined
         * with the appropriate method to create and yield the TestCaseData objects.
         */


        [Test]
        public async Task GetDataForUser3_CheckName_ShouldEqualClementineBauch()
        {
            RestRequest request = new RestRequest("/users/3", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            JObject responseData = JObject.Parse(response.Content!);

            Assert.That(responseData.SelectToken("name")!.ToString(), Is.EqualTo("Clementine Bauch"));
        }
        //Format input in brackets with  TestCase Nunit and then append user int, name as string, User 1 is X

        [TestCase(1, "Leanne Graham", TestName = "User 1 is Leanne Graham")]
        [TestCase(2, "Ervin Howell", TestName = "User 2 is Ervin Howell")]
        [TestCase(3, "Clementine Bauch", TestName = "User 3 is Clementine Bauch")]

        public async Task GetDataForUser_CheckName_ShouldEqualExpectedName_UsingTestCase
            (int userId, string expectedName)
        {
            RestRequest request = new RestRequest($"/users/{userId}", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            JObject responseData = JObject.Parse(response.Content!);

            Assert.That(responseData.SelectToken("name")!.ToString(), Is.EqualTo(expectedName));
        }

    }
}
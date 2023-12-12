using System.Net.Http.Json;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using ServiceClient;
using ServiceClient.Models;

namespace ServiceTests.PersonAPI
{
    public class PersonApiTests
    {
        private WebApplicationFactory<Program> _server;
        private HttpClient _client;

        public PersonApiTests()
        {
            _server = new WebApplicationFactory<Program>();
        }

        [SetUp]
        public void Setup()
        {
            _client = _server.CreateClient();
        }

        [Test]
        public async Task Get_5PersonsInStore_5PersonsReturned()
        {
            var persons = await _client.GetFromJsonAsync<IEnumerable<Person>>("/Person");

            persons.Should().HaveCount(5);
        }

        [Test]
        public async Task Get_5PersonsInStore_2AdultsReturned()
        {
            var persons = await _client.GetFromJsonAsync<IEnumerable<Person>>("/Person/Adults");

            persons.Should().HaveCount(2);
        }

        [Test]
        public async Task Get_5PersonsInStore_2ChildsReturned()
        {
            var persons = await _client.GetFromJsonAsync<IEnumerable<Person>>("/Person/Children");

            persons.Should().HaveCount(3);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClient.Data;
using ServiceClient.Logic;
using ServiceClient.Models;

namespace ServiceClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonManager _manager;

        public PersonController(IPersonManager manager)
        {
            _manager = manager;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            var persons = _manager.GetAll();

            return Ok(persons);
        }


        [HttpGet()]
        [Route("/Person/Adults")]
        public IActionResult GetAllAdults()
        {
            var adults = _manager.GetAllAdults();

            return Ok(adults);
        }

        [HttpGet()]
        [Route("/Person/Children")]
        public IActionResult GetAllChildren()
        {
            var children = _manager.GetAllChildren();

            return Ok(children);
        }
    }
}

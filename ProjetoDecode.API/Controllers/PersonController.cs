using Microsoft.AspNetCore.Mvc;
using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace ProjetoDecode.API.Controllers
{
    //[Route("[controller]")]
    [Route("person/")]
    [ApiController]
    public class PersonController : Controller //ControllerBase
    {
        private readonly IApplicationServicePerson _applicationServicePerson;

        public PersonController(IApplicationServicePerson applicationServicePerson)
        {
            _applicationServicePerson = applicationServicePerson;
        }

        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServicePerson.GetAll());
        }

        //GET api/value/1
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        
        {
            return Ok(_applicationServicePerson.GetById(id));
        }

        //POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PersonDTO personDTO)
        {
            try
            {
                if (personDTO == null)
                    return NotFound();

                _applicationServicePerson.Add(personDTO);
                return Ok("Person registered!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //PUT api/values/1
        [HttpPut]
        public ActionResult Put([FromBody] PersonDTO personDTO)
        {
            try
            {
                if (personDTO == null)
                    return NotFound();

                _applicationServicePerson.Update(personDTO);
                return Ok("Person updated!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //DELETE api/values/1
        [HttpDelete]
        public ActionResult Delete([FromBody] PersonDTO personDTO)
        {
            try
            {
                if (personDTO == null)
                    return NotFound();

                _applicationServicePerson.Remove(personDTO);
                return Ok("Person deleted!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

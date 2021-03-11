using Microsoft.AspNetCore.Mvc;
using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace ProjetoDecode.API.Controllers
{
    [Route("hobby/")]
    [ApiController]
    public class HobbyController : Controller
    {
        private readonly IApplicationServiceHobby _applicationServiceHobby;

        public HobbyController(IApplicationServiceHobby applicationServiceHobby)
        {
            _applicationServiceHobby = applicationServiceHobby;
        }

        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceHobby.GetAll());
        }

        //GET api/value/1
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            return Ok(_applicationServiceHobby.GetById(id));
        }

        //POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] HobbyDTO hobbyDTO)
        {
            try
            {
                if (hobbyDTO == null)
                    return NotFound();

                _applicationServiceHobby.Add(hobbyDTO);
                return Ok("Hobby registered!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //PUT api/values/1
        [HttpPut]
        public ActionResult Put([FromBody] HobbyDTO hobbyDTO)
        {
            try
            {
                if (hobbyDTO == null)
                    return NotFound();

                _applicationServiceHobby.Update(hobbyDTO);
                return Ok("Hobby updated!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //DELETE api/values/1
        [HttpDelete]
        public ActionResult Delete([FromBody] HobbyDTO hobbyDTO)
        {
            try
            {
                if (hobbyDTO == null)
                    return NotFound();

                _applicationServiceHobby.Remove(hobbyDTO);
                return Ok("Hobby deleted!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

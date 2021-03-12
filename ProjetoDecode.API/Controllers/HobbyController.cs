using Microsoft.AspNetCore.Mvc;
using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
            try
            {
                return Ok(_applicationServiceHobby.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //GET api/value/1
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            try
            {
                return Ok(_applicationServiceHobby.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //GET api/value/lastname
        [HttpGet("search/{search}")]
        public ActionResult<IEnumerable<string>> Search(string search)
        {
            try
            {
                var _search = _applicationServiceHobby.GetAll().Where(x => x.Name.ToLower().Contains(search.ToLower()));
                return Ok(_search);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
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
                return BadRequest(e.Message);
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
                return BadRequest(e.Message);
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
                return BadRequest(e.Message);
            }
        }
    }
}

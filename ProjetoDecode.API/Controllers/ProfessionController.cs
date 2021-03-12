using Microsoft.AspNetCore.Mvc;
using ProjetoDecode.Application.DTO;
using ProjetoDecode.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDecode.API.Controllers
{
    [Route("profession/")]
    [ApiController]
    public class ProfessionController : Controller
    {
        private readonly IApplicationServiceProfession _applicationServiceProfession;

        public ProfessionController(IApplicationServiceProfession applicationServiceProfession)
        {
            _applicationServiceProfession = applicationServiceProfession;
        }

        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                return Ok(_applicationServiceProfession.GetAll());
            }
            catch(Exception e)
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
                return Ok(_applicationServiceProfession.GetById(id));
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
                var _search = _applicationServiceProfession.GetAll().Where(x => x.Role.ToLower().Contains(search.ToLower()));
                return Ok(_search);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProfessionDTO professionDTO)
        {
            try
            {
                if (professionDTO == null)
                    return NotFound();

                _applicationServiceProfession.Add(professionDTO);
                return Ok("Profession registered!");
            }
            catch (Exception e)
            {
                //throw e;
                return BadRequest(e.Message);
            }
        }

        //PUT api/values/1
        [HttpPut]
        public ActionResult Put([FromBody] ProfessionDTO professionDTO)
        {
            try
            {
                if (professionDTO == null)
                    return NotFound();

                _applicationServiceProfession.Update(professionDTO);
                return Ok("Profession updated!");
            }
            catch (Exception e)
            {
                //throw e;
                return BadRequest(e.Message);
            }
        }

        //DELETE api/values/1
        [HttpDelete]
        public ActionResult Delete([FromBody] ProfessionDTO professionDTO)
        {
            try
            {
                if (professionDTO == null)
                    return NotFound();

                _applicationServiceProfession.Remove(professionDTO);
                return Ok("Profession deleted!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

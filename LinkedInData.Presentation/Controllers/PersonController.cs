using System;
using System.Collections.Generic;
using System.Linq;
using LinkedInData.Application.DTO;
using LinkedInData.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LinkedInData.Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly IApplicationServicePerson _applicationServicePerson;


        public PersonController(IApplicationServicePerson applicationServicePerson)
        {
            _applicationServicePerson = applicationServicePerson;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                return Ok(_applicationServicePerson.GetAll());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {

            try
            {
                PersonDTO person = _applicationServicePerson.GetById(id);

                if ((person != null) && (person.PersonId != 0))
                {
                    return Ok(person);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet("GetTopClients/{number}")]
        public ActionResult<string> GetTopClients(int number)
        {
            try
            {
                var personIds = from p in _applicationServicePerson.GetTopClients(number)
                                select new { p.PersonId };


                return Ok(personIds);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        [HttpGet("GetClientPosition/{personId}")]
        public ActionResult<string> GetClientPosition(int personId)
        {
            try
            {
                int position = _applicationServicePerson.GetClientPosition(personId);

                if (position > 0)
                {
                    return Ok(new { Position = position });
                }
                else
                {
                    return NotFound();
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("Insert")]
        public ActionResult Insert([FromBody] PersonDTO personDTO)
        {
            try
            {
                if (personDTO == null)
                    return NotFound();

                PersonDTO person = _applicationServicePerson.GetById(personDTO.PersonId);

                if (person.PersonId > 0)
                    return BadRequest();

                _applicationServicePerson.Add(personDTO);

                int position = _applicationServicePerson.GetClientPosition(personDTO.PersonId);

                if (position > 0)
                {
                    return Ok(new { Position = position });
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost("MultipleInsert")]
        public ActionResult MultipleInsert([FromBody] List<PersonDTO> personDTO)
        {
            try
            {
                if (personDTO == null)
                    return NotFound();

                foreach (var person in personDTO)
                {
                    _applicationServicePerson.Add(person);
                }

                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        [HttpPut]
        public ActionResult Put([FromBody] PersonDTO personDTO)
        {
            try
            {
                if (personDTO == null)
                    return NotFound();

                _applicationServicePerson.Update(personDTO);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] PersonDTO personDTO)
        {
            try
            {
                if (personDTO == null)
                    return NotFound();

                _applicationServicePerson.Remove(personDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

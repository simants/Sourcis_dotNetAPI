using Microsoft.AspNetCore.Mvc;
using Sourcis_dotNetAPI.Models;
using Sourcis_dotNetAPI.Services;

namespace Sourcis_dotNetAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PersonController : ControllerBase{
    private readonly IPersonServices _personServices;

    public PersonController(IPersonServices personServices){
        _personServices = personServices;
    }

    [HttpGet]
    public ActionResult<List<Person>> GetAllData(){
        return Ok(_personServices.GetAllData());
    }

    [HttpGet("{id}")]
    public ActionResult<Person> GetPersonById(int id){
        var response = _personServices.GetPersonById(id);
        if (response == null){
            return NotFound();
        }
        return Ok(response);
    }

    [HttpPost]
    public ActionResult<Person> AddPerson(int id, Person person){
        return _personServices.AddPerson(person);
    }

    [HttpPut("id")]
    public ActionResult<Person> UpdatePerson(int id, Person person){
        try{
            var response = _personServices.UpdatePerson(id, person);
            if (response == -1){
                return BadRequest();
            }
            else if (response == 0){
                return NotFound();
            }
            return NoContent();
        }
        catch(System.Exception){
            throw;
        }
    }

    [HttpDelete("{id}")]
    public ActionResult<Person> DeletePerson(int id){
        var response = _personServices.DeletePerson(id);
        if (response == null){
            return NotFound();
        }
        return Ok(response);
    }
}


using Microsoft.AspNetCore.Mvc;
using Sourcis_dotNetAPI.Models;
using Sourcis_dotNetAPI.Services;

namespace Sourcis_dotNetAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CarController : ControllerBase{
    private readonly ICarServices _icarservices;
    public CarController(ICarServices carservices){
        _icarservices = carservices;
    }

    [HttpGet]
    public ActionResult<List<Car>> GetAllCars(){
        return Ok(_icarservices.GetAllCars());
    }

    [HttpGet("{id}")]
    public ActionResult<Car> GetCarById(int id){
        var response = _icarservices.GetCarById(id);
        if(response == null){
            return NotFound();
        }
        return Ok(response);
    }

    [HttpPost]
    public ActionResult<Car> AddCar(Car car){
        return Ok(_icarservices.AddCar(car));
    }

    [HttpPut("{id}")]
    public ActionResult<Car> UpdateCar(int id, Car car){
        try{
            var response = _icarservices.UpdateCar(id, car);
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
    public ActionResult<Car> DeleteCar(int id){
        var response = _icarservices.DeleteCar(id);
        if (response == null){
            return NotFound();
        }
        return Ok(response);
    }
}
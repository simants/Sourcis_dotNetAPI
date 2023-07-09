using Microsoft.EntityFrameworkCore;
using Sourcis_dotNetAPI.Context;
using Sourcis_dotNetAPI.Models;

namespace Sourcis_dotNetAPI.Services{
    public interface ICarServices{
        public List<Car> GetAllCars();
        public Car GetCarById(int id);
        public Car AddCar(Car car);
        public int UpdateCar(int id, Car car);
        public Car DeleteCar(int id);
    }
    public class CarServices : ICarServices{
        private readonly MyDbContext _mydbcontext;
        public CarServices(MyDbContext myDbContext){
            _mydbcontext = myDbContext;
            myDbContext.Database.EnsureCreated();
        }

        public Car AddCar(Car car)
        {
            _mydbcontext.Car.Add(car);
            _mydbcontext.SaveChanges();
            return GetCarById(car.Id);
        }

        public Car DeleteCar(int id)
        {
            var check = _mydbcontext.Car.Find(id);
            if (check != null){
                _mydbcontext.Car.Remove(check);
                _mydbcontext.SaveChanges();
            }
            return check;
        }

        public List<Car> GetAllCars()
        {
           return _mydbcontext.Car.ToList();
        }

        public Car GetCarById(int id)
        {
            return _mydbcontext.Car.Find(id);
        }

        public int UpdateCar(int id, Car car)
        {
            if (id != car.Id){
                return -1;
            }
            _mydbcontext.Entry(car).State = EntityState.Modified;
            try{
                _mydbcontext.SaveChanges();
            }
            catch(DbUpdateConcurrencyException){
                if(! _mydbcontext.Car.Any( c => c.Id == id))
                return 0;
                throw;
            }
            return 1;
        }
    }
}
using Sourcis_dotNetAPI.Context;
using Sourcis_dotNetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Sourcis_dotNetAPI.Services{
    public interface IPersonServices{
        public List<Person> GetAllData();
        public Person GetPersonById(int id);
        public Person AddPerson(Person person);
        public int UpdatePerson(int id, Person person);
        public Person DeletePerson(int id);
    }
    public class PersonServices : IPersonServices
    {
        public readonly MyDbContext _mydbcontext;
        public PersonServices(MyDbContext myDbContext){
            _mydbcontext = myDbContext;
            myDbContext.Database.EnsureCreated();
        }

        public Person AddPerson(Person person)
        {
            _mydbcontext.Person.Add(person);
            _mydbcontext.SaveChanges();
            return GetPersonById(person.Id);
        }

        public Person DeletePerson(int id)
        {
            var check = _mydbcontext.Person.Find(id);
            if(check != null){
                _mydbcontext.Person.Remove(check);
                _mydbcontext.SaveChanges();
            }
            return check;
        }

        public List<Person> GetAllData()
        {
            return _mydbcontext.Person.ToList();
        }

        public Person GetPersonById(int id)
        {
            return _mydbcontext.Person.Find(id);
        }

        public int UpdatePerson(int id, Person person)
        {
            if(id != person.Id){
                return -1;
            }
            _mydbcontext.Entry(person).State = EntityState.Modified;

            //This is to check race condition

            try{
                _mydbcontext.SaveChanges();
            }
            catch(DbUpdateConcurrencyException){
                if(!_mydbcontext.Person.Any(p => p.Id == id))
                return 0;
                throw;
            }
            return 1;
        }
    }
}
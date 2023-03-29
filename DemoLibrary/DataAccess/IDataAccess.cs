using DemoLibrary.Models;

namespace DemoLibrary.DataAccess;

public interface IDataAccess
{
    List<PersonModel> GetPeople();
    PersonModel InsertPeople(string firstName, string lastName);
    void DeletePerson(int id);
}
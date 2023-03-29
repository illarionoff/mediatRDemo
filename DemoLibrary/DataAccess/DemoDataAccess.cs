using DemoLibrary.Models;

namespace DemoLibrary.DataAccess;

public class DemoDataAccess : IDataAccess
{
    private readonly List<PersonModel> people = new();
    public DemoDataAccess()
    {
        people.Add(new PersonModel { Id = 1, FirstName = "John", LastName = "Doe" });
        people.Add(new PersonModel { Id = 2, FirstName = "Jane", LastName = "Doe" });
    }

    public void DeletePerson(int id)
    {
        people.RemoveAll(x => x.Id == id);
    }

    public List<PersonModel> GetPeople()
    {
        return people;
    }

    public PersonModel InsertPeople(string firstName, string lastName)
    {
        PersonModel p = new() { Id = 1, FirstName = firstName, LastName = lastName };
        p.Id = people.Max(x => x.Id) + 1;
        people.Add(p);
        return p;
    }
}

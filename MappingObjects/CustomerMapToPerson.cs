namespace MappingObjects;

public class CustomerMapToPerson : IMapper<Customer, Person>
{
    
    public Person Map(Customer source)
    {
        return new Person{
            Id = source.Id,
            FirstName = source.FirstName,
            LastName = source.LastName,            
        };
    }
}
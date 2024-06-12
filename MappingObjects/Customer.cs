namespace MappingObjects;

public class Customer
{
    public int Id { get; set;}
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public DateTime CreatedOn { get; set;}

    public T Map<T>(IMapper<Customer,T> mapper)
    {
        return mapper.Map(this);
    }

    
}
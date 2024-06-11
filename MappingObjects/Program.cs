using MappingObjects;

Customer customer = new Customer{
    Id = 1,
    FirstName = "Mehedi",
    LastName = "Hasan",
    CreatedOn = DateTime.Now.Date
};

// Using Custom Mapper Class
// var mapper = new CustomerMapToPerson();
// Person person = mapper.Map(customer);

// Using Generic Mapper Method
Person person = customer.Map<Person>(new CustomerMapToPerson());

Console.WriteLine($"Id: {person.Id}, Name: {person.FirstName} {person.LastName}");
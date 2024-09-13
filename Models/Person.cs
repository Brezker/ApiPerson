using Microsoft.AspNetCore.Mvc;

namespace ApiPerson.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public int Age { get; set; }
    }
}

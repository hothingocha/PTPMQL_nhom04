using System.ComponentModel.DataAnnotations;

namespace MvcPerson.Models;

    public class Person
    {
        public string? PersonId { get; set; }
         public string? Fullname {get; set; }
        public string? Address {get; set; }
    }

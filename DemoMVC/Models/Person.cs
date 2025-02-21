using System.ComponentModel.DataAnnotations;

namespace MvcPerson.Models;

    public class Person
    {
        public string? PersonId { get; set; }
         public string? Fullname {get; set; }
        public string? Address {get; set; }

        public Person()
        {
            PersonId = string.Empty;
            Fullname = string.Empty;
            Address = string.Empty;
        }
    }

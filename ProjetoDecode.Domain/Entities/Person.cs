using ProjetoDecode.Domain.Enumerators;
using ProjetoDecode.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace ProjetoDecode.Domain.Entities
{
    public class Person : Base, IEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public Status Status { get; set; }
        //public virtual Profession Profession { get; set; }
        public int ProfessionId { get; set; }
        public virtual IEnumerable<PeopleHobbies> PeopleHobbies { get; set; } = new List<PeopleHobbies>();


    }
}

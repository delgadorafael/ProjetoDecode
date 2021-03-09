using ProjetoDecode.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDecode.Domain.Entities
{
    public class PeopleHobbies : Base, IEntity
    {
        public Person Person { get; set; }
        public Hobby Hobbies { get; set; }
    }
}

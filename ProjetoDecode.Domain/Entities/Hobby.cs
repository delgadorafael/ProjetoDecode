using ProjetoDecode.Domain.Interfaces;
using System.Collections.Generic;

namespace ProjetoDecode.Domain.Entities
{
    public class Hobby : Base, IEntity
    {
        public string Name { get; set; }
        public ICollection<PeopleHobbies> PeopleHobbies { get; set; } = new List<PeopleHobbies>();
    }
}

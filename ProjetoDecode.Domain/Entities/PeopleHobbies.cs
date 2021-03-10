using ProjetoDecode.Domain.Interfaces;

namespace ProjetoDecode.Domain.Entities
{
    public class PeopleHobbies : Base, IEntity
    {
        public Person Person { get; set; }
        public Hobby Hobbies { get; set; }
    }
}

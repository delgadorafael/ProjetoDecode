using ProjetoDecode.Domain.Interfaces;

namespace ProjetoDecode.Domain.Entities
{
    public class PeopleHobbies : Base, IEntity
    {
        public int PersonId { get; set; }
        public virtual Hobby Hobby { get; set; }
    }
}

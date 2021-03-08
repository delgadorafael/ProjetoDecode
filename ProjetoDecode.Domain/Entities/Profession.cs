using ProjetoDecode.Domain.Interfaces;

namespace ProjetoDecode.Domain.Entities
{
    public class Profession : Base, IEntity
    {
        public string Role { get; set; }
    }
}

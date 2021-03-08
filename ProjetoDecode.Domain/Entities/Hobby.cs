using ProjetoDecode.Domain.Interfaces;

namespace ProjetoDecode.Domain.Entities
{
    public class Hobby : Base, IEntity
    {
        public string Name { get; set; }
    }
}

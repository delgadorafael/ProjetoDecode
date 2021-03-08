using ProjetoDecode.Domain.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDecode.Application.DTO
{
    class PersonDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public Status Status { get; set; }
        public ProfessionDTO Profession { get; set; }
        public List<HobbyDTO> Hobbies { get; set; }
    }
}

using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.DTO {

    public class UserDTO
    {
        public int id { get; set; }
        public int personId { get; set; }
        public virtual Person? person { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        //public UserTypeEnum? userType { get; set; }

        public User mapToEntity()
        {
            return new User
            {
                Id = id,
                PersonId = personId,
                Person = person,
                Username = username,
                Password = password,
                Email = email,
                //UserType = userType,
            };
        }

        public UserDTO mapToDTO(User user)
        {
            return new UserDTO
            {
                id = user.Id,
                personId = user.PersonId,
                person = user.Person,
                username = user.Username,
                password = user.Password,
                email = user.Email,
                //userType = user.UserType,
            };
        }
    }
}

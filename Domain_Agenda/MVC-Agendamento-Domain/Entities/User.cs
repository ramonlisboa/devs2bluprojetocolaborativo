using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    public class User
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public virtual Person? Person { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        //public UserTypeEnum? UserType { get; set; }
    }
}

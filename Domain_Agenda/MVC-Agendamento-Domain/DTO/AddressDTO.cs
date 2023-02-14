using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.DTO {
    public class AddressDTO
    {
        public int id { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string district { get; set; }
        public string street { get; set; }
        public string number { get; set; }

        public Address mapToEntity()
        {
            return new Address()
            {
                Id = id,
                PostalCode = postalCode,
                District = district,
                Street = street,
                Number = number
            };
        }
        public AddressDTO mapToDTO(Address address)
        {
            return new AddressDTO()
            {
                id = address.Id,
                postalCode = address.PostalCode,
                district = address.District,
                street = address.Street,
                number = address.Number
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.Entities.Dtos
{
    public class VisitorDto
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string IdentityNo { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

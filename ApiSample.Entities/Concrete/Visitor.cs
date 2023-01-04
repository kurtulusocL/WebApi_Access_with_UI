using ApiSample.Core.Entities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample.Entities.Concrete
{
    public class Visitor : BaseEntity
    {
        public string NameSurname{ get; set; }
        public string IdentityNo { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

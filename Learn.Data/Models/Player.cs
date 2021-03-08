using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Learn.Data.Models
{
    public class Player : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
     
    }
}

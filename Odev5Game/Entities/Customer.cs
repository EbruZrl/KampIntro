using Odev5Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Entities
{
    public class Customer:IEntity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MyProperty { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}

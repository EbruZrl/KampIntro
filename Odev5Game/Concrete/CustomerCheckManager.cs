using Odev5Game.Abstract;
using Odev5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

   
    }
}

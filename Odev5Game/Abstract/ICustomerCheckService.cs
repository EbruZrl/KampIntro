using Odev5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}

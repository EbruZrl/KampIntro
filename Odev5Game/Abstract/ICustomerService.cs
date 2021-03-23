using Odev5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        void Add(Customer customer);
    }
}

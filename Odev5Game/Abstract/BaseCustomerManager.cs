using Odev5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Saved to db: " + customer.FirstName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "silindi");
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "eklendi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "güncellendi");
        }
    }
}

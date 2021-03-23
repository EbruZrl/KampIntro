using Odev5Game.Abstract;
using Odev5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5Game.Concrete
{
    public class CustomerManager : BaseCustomerManager 
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }

            else
            {
                throw new Exception("Öyle biri yok ki öyle biri yok sen beni çıldırtmak mı istiyorsun?");
            }
        }


    }




}

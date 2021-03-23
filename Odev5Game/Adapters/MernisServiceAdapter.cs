using Odev5Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Odev5Game.Adapters;
using Odev5Game.Concrete;
using Odev5Game.Entities;
using MernisKimlik;
using System.Threading.Tasks;

namespace Odev5Game.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
            return  client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);

            //TC kimlik noyu asenkron (async) çalıştır. Await cevabı bekleee. 
        }
    }
}

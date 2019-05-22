using System;
using System.Collections.Generic;
using System.Text;

namespace BasketManagment
{
    interface ICustomerService
    {
        Customer Register(string Name, string Address, DateTime Dob, string Email);
        bool Update(string Name, string Address, DateTime Dob, string Email);
        bool Delete(string Email);
        bool AddBasket(string Email, Basket basket);
        void DeleteBasket(string Email, int BasketId);
        List<Customer> GetRecentCustomers();
    }
}

using BasketManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagment
{
    public class CustomerService : ICustomerService
    {
        

        public Customer Register(string Name, string Address, DateTime Dob, string Email)
        {
            try
            {
                if (Dob.AddYears(80) >= DateTime.Now)
                {
                    var rep = new Repository();
                    rep.Add(new Customer(Name, Address, Dob, Email));
                    rep.SaveChanges();

                    var customer = rep.Set<Customer>().Last();
                    return customer;
                }
                return null;
            }
            catch (Exception e)
            {
                
                return null;
            }



        }

        public bool Update(string Name, string Address, DateTime Dob, string Email)
        {
            try
            {
                var rep = new Repository();
                var update = rep.Set<Customer>().SingleOrDefault(b => b.Email == Email);
                if (update == null)
                {
                    Console.WriteLine("Please Try Again!");
                }
                update.Name = Name;
                update.Address = Address;
                update.Dob = Dob;
                rep.Customer.Update(update);
                rep.SaveChanges();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(string Email)
        {
            try
            {
                var rep = new Repository();
                var delete = rep.Set<Customer>().SingleOrDefault(b => b.Email == Email);
                if (delete == null)
                {
                    Console.WriteLine("Please Try Again!");
                }
                rep.Remove(delete.Email);
                rep.SaveChanges();

                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public bool AddBasket(string Email, Basket basket)
        {
            try
            {
                var rep = new Repository();
                var add = rep.Set<Customer>().SingleOrDefault(b => b.Email == Email);
                if (add != null)
                {
                    basket.Customer = add;
                    rep.Basket.Add(basket);
                    rep.Add(basket);
                    rep.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void DeleteBasket(string Email, int BasketId)
        {
            try
            {
                var rep = new Repository();
                var removeB = rep.Set<Basket>().SingleOrDefault(b => b.BasketId == BasketId);
                var removeC = rep.Set<Customer>().SingleOrDefault(c => c.Email == Email);
                removeC.Baskets.Remove(removeB);
                 rep.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
        }

        public List<Customer> GetRecentCustomers()
        {
            var recentCustomers = new List<Customer>();
            try
            {
                var rep = new Repository();
                recentCustomers = rep.Set<Customer>()
                    .Where(c => c.Dor.AddDays(7) >= DateTime.Today)
                    .ToList();

                return recentCustomers;
            }
            catch (Exception e)
            {
                return recentCustomers;
            }
        }

    }
}


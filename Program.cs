using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BasketManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            var rep = new Repository();


            //apo pneumatiko san paradeigma gia add kai delete product
           // rep.Set<Basket>().Where(p => p.Customer.Email== "").Where(b => b.BasketId== x).Include(b =>b.ProductBasket).ToList()

            //REGISTER CUSTOMERS
            // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>.

            var c = new Customer();


            //var cstm = c.Register(
            //"Alexandros",
            // "Mpotsari",
            //"09/03/1987",
            //"alex@hotmail.com"
            //    );

            //var cstma = c.Register(
            //"Alex",
            // "Athens",
            //"09/03/1985",
            //"alex@hotmail.gr"
            //    );

            // var cstmb = c.Register(
            //"Kate",
            // "Kavala",
            //"05/03/1991",
            //"zoll@hotmail.gr"
            //    );


            //var cstm1 = c.Update(
            //    "Alexandros",
            //    "Mpotsari",
            //    "09/02/1987",
            //    "alex@hotmail.com");


            //c.Delete("alex@hotmail.com");

            //ADD PRODUCTS TO BASKET
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>.
            //var basket = new Basket();

            //basket.BasketProduct.Add(new Product()
            //{
            //    Name = "Replay",
            //    Category = ProductCategoryId.Shirt,
            //    Price = 120M
            //});

            // basket.BasketProduct.Add(new Product()
            // {
            //     Name = "ArmaniJeans",
            //     Category = ProductCategoryId.Jeans,
            //     Price = 420M
            // });


            // basket.BasketProduct.Add(new Product()
            // {
            //     Name = "Armani",
            //     Category = ProductCategoryId.Shirt,
            //     Price = 344.80M
            // });

            //basket.BasketProduct.Add(new Product()
            // {
            //     Name = "Nak",
            //     Category = ProductCategoryId.Shoes,
            //     Price = 80M
            // });

            // //ADD BASKET
            //// >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>.
            // c.AddBasket("zol@hotmail.gr",basket);


            //GET RECENT CUSTOMERS
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>.

            //foreach (Customer customer in c.GetRecentCustomers())
            //{
            //    Console.WriteLine(customer);
            //}
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BasketManagment
{
    public class Customer 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public DateTime Dor { get; set; }
        [Required]
        public string Email { get; set; }

        public List<Basket> Baskets { get; set; }




        public Customer()
        {

        }

        public Customer( string name, string address, DateTime dob, string email)
        {
            
            Name = name;
            Address = address;
            Dob = dob;
            Dor = DateTime.Today;
            Email = email;
            Baskets = new List<Basket>();
        }

        public override string ToString()
        {
            return $"{Id}:{Name}:{Address}:{Dob}:{Dor}:{Email}";
        }





    }


}

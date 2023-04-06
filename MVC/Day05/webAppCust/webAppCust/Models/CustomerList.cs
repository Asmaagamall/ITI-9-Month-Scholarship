using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webAppCust.Models
{
    public class CustomerList
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer(){Id = 1 , Name = "Asmaa" , Email = "esm@email.com" , Gender = "Female" , Phone = "010234567"},
            new Customer(){Id = 2 , Name = "Ali" , Email = "Ali@email.com" , Gender = "Male" , Phone = "0109848987"},
            new Customer(){Id = 3 , Name = "Amina" , Email = "Amina@email.com" , Gender = "Female" , Phone = "010728763"},
            new Customer(){Id = 4 , Name = "Reem" , Email = "Reem@email.com" , Gender = "Female" , Phone = "0100989238"},
        };
    }
}
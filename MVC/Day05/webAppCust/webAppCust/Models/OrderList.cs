using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webAppCust.Models
{
    public class OrderList
    {
        public static List<Order> orders = new List<Order>()
        {
            new Order(){CustId = 1, Id = 1, TotalPrice = 50 , date = new DateTime(2000 , 2 , 1)},
            new Order(){CustId = 1, Id = 2, TotalPrice = 100 , date = new DateTime(2022 , 8 , 20)},
            new Order(){CustId = 2, Id = 3, TotalPrice = 10 , date = new DateTime(2023 , 9 , 25)},
            new Order(){CustId = 3, Id = 4, TotalPrice = 20 , date = new DateTime(2021 , 12 , 29)},
            new Order(){CustId = 4, Id = 5, TotalPrice = 200 , date = new DateTime(2020 , 11 , 30)},
        };
    }
}
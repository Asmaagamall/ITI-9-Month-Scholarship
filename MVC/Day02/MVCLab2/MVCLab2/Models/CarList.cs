using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLab2.Models
{
    public class CarList
    {
        public static List<Car> Cars = new List<Car>()
        {
            new Car(){Num = 1 , Color = "Red" , Model = "2010" , Manfacture = "Ford"},
            new Car(){Num = 2 , Color = "Blue" , Model = "2015" , Manfacture = "Honda"},
            new Car(){Num = 3 , Color = "Black" , Model = "2009" , Manfacture = "Toyota"},
            new Car(){Num = 4 , Color = "White" , Model = "2005" , Manfacture = "Hyundai "},
            new Car(){Num = 5 , Color = "Bink" , Model = "2020" , Manfacture = "Kia"},
            new Car(){Num = 6 , Color = "Gray" , Model = "2022" , Manfacture = "Mercedes"},
            new Car(){Num = 7 , Color = "Mint" , Model = "2019" , Manfacture = "Suzuki"},
        };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscountAssesment.Models
{
    public class ClearanceSale
    {
        public string ProductName { set; get; }
        public string price { set; get; }
        public string isSale { set; get; }
        public string day1sale { set; get; }
        public string day2sale { set; get; }
        public string day3sale { set; get; }
    }
}
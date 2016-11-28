using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POCOModels.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string city { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contactNo { get; set; }
        public string emailId { get; set; }
    }


}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wirecraft.Web.Models
{
    public class Product
    {
		public Product() {
			name = "sample name here";
			price = 0;
			description = "sample description here";
			timeStamp = DateTime.Now.Date;
			fileIDs = (new int[0]).AsEnumerable();
		}
        public string name { get; set; }
        public int productID { get; set; }
        public double price { get; set; }
        public IEnumerable<int> fileIDs { get; set; }
        public string description { get; set; }
        public DateTime timeStamp { get; set; }
    }
}
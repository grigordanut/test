﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DublinRenting.Models
{
    public class Owner
    {
        public int OwnerID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        //sent PK as FK to
        public virtual ICollection<PropertyForRent> PropertyForRents { get; set; }
    }
}
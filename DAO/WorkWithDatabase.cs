﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using ExecuteIdentityFramework.DAO;

namespace ExecuteIdentityFramework.DAO
{
    public class WorkWithDatabase
    {
        public List<Basket> Basket { get; set; }
        public List<DeliveryMethod> DeliveryMethods {get; set;}
    }
}
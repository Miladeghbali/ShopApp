﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ComputedColumnAttribute:Attribute
    {
    }
}

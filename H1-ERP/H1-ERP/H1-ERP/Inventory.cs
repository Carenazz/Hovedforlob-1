﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP
{
    public class Inventory
    {
        static public List<Item> invList = new List<Item>();
        // Planned: Make the list be able to print out everything in it.
        public void PrintTable()
        {
            foreach (var item in invList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

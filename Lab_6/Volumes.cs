﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Volumes
    {
        public List<ItemBase> Items { get; set; }

        public Volumes(List<ItemBase> items)
        {
            Items = items;
        }

        public override string ToString()
        {
            string volumeString = "";
            volumeString += $"Items: \n {Items}";
            return volumeString;
        }
    }
}

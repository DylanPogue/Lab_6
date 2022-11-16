using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class ItemBase
    {
        public Item Item { get; set; }

        public ItemBase(Item item)
        {
            Item = item;
        }

        /*public override string ToString()
        {
            string itemString = "";
            itemString += $"Id: {Item.Id}\n";
            itemString += $"Title: {Item.Title}\n";
            itemString += $"Authors: {string.Join(", ", Item.Authors)}\n";
            itemString += $"Description: {Item.Description}\n";
            itemString += $"SelfLink: {Item.SelfLink}\n";
            return itemString;
        }*/
    }
}

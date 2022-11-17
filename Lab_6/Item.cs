using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Item
    {
        public List<VolumeInfoBase> Volumes { get; set; }
        public string Id { get; set; }
        public string SelfLink { get; set; }

        public Item(List<VolumeInfoBase> volumes, string id, string selfLink)
        {
            Volumes = volumes;
            Id = id;
            SelfLink = selfLink;
        }

        public override string ToString()
        {
            string itemString = "";
            foreach(var i in Volumes)
            {
                itemString += i;
            }
            return itemString;
        }




    }
}

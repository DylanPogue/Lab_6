using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Item
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public string Description { get; set; }
        public string SelfLink { get; set; }

        public Item(string id, string title, List<string> authors, string description, string selfLink)
        {
            Id = id;
            Title = title;
            Authors = authors;
            Description = description;
            SelfLink = selfLink;
        }

        
    }
}

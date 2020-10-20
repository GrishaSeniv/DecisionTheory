using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        
        public int id { set; get; }

        public String name { set; get; }

        public String shortDesc { set; get; }

        public String longDesc { set; get; }

        public String img { set; get; }

        public ushort price { set; get; }

        public bool isFavourite { set; get; }

        public bool available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }

    }
}

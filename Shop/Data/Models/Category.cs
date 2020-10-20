using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Category
    {

        public int id { set; get; }

        public String categoryName { get; set; }

        public String desc { get; set; }

        public List<Car> cars { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Manager
{
    class Product

    {
        public int id { set; get; }
        public String name { set; get; }
        public String serial { set; get; }


  
        public Product(int id, String name, String serial)
        {
            this.id = id;
            this.name = name;
            this.serial = serial;
        }

        public Product(String name, String serial)
        {
            this.name = name;
            this.serial = serial;
        }

       
    }
}

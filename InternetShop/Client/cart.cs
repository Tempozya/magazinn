using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Client
{
    public class cart
    {

        public List<string> productId { get; set; }
        public List<string> style { get; set; }
        public List<string> amount { get; set; }
        public List<string> title { get; set; }




        public cart()
        {
            productId = new List<string>();
            style = new List<string>();
            amount = new List<string>();
            title = new List<string>();
        }

    }
}

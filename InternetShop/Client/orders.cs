using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetShop.Client
{
    public partial class orders : Form
    {
        cart cart = new cart();
        public orders()
        {
            InitializeComponent();

        }

        public orders(cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void orders_Load(object sender, EventArgs e)
        {
            

        }
    }
}

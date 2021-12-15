using InternetShop.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetShop.Admin
{
    public partial class ranqe : Form
    {
        sqlFunc sf = new sqlFunc();

        public ranqe()
        {
            InitializeComponent();
        }

        private void ranqe_Load(object sender, EventArgs e)
        {
            dataGridViewgoods.DataSource = sf.getgoods();

        }
    }
}

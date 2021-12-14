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
    public partial class clients : Form
    {
        sqlFunc sf = new sqlFunc();

        public clients()
        {
            InitializeComponent();
        }

        private void clients_Load(object sender, EventArgs e)
        {
            dataGridViewclients.DataSource = sf.allclients();
        }
    }
}

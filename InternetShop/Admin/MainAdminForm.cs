using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetShop.Admin;

namespace InternetShop.Admin
{
    public partial class MainAdminForm : Form
    {
        public MainAdminForm()
        {
            InitializeComponent();
        }

        private void buttonclients_Click(object sender, EventArgs e)
        {
            clients clients = new clients();
            clients.ShowDialog();

        }

        private void buttonranqe_Click(object sender, EventArgs e)
        {
            ranqe ranqe = new ranqe();
            ranqe.ShowDialog();
        }

        private void buttonhistori_Click(object sender, EventArgs e)
        {
            history history = new history();
            history.ShowDialog();
        }

        private void buttongetgoods_Click(object sender, EventArgs e)
        {
            getgoodsinfo getgoodsinfo = new getgoodsinfo();
            getgoodsinfo.ShowDialog();
        }

        private void buttongivegoods_Click(object sender, EventArgs e)
        {
            givegoodsinfo givegoodsinfo = new givegoodsinfo();
            givegoodsinfo.ShowDialog();
        }
    }
}

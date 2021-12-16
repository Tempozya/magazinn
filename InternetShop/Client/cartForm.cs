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
    public partial class cartForm : Form
    {
        cart cart = new cart();
        public cartForm()
        {
            InitializeComponent();
            
        }

        public cartForm(cart cart)
        {
            InitializeComponent();
            this.cart = cart;
           
            
        }



        private void addLabelName(int i, FlowLayoutPanel flw)
        {
            Label nbomb = new Label();
            nbomb.Name = "txtNum" + i;
            nbomb.Location = new Point(1, i * 50 + 10);
            nbomb.Margin = new Padding(0);
            //nbomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //nbomb.ForeColor = Color.White;
            // nbomb.Size = new Size(200, 30);
            nbomb.AutoSize = true;  
            nbomb.Text = cart.title[i];
            flw.Controls.Add(nbomb);
        }

        private void addLabelStyle(int i, FlowLayoutPanel flw)
        {
            Label nbomb = new Label();
            nbomb.Name = "txtNum" + i;
            nbomb.Location = new Point(1, i * 50 + 10);
            nbomb.Margin = new Padding(0);
            //nbomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //nbomb.ForeColor = Color.White;
            // nbomb.Size = new Size(200, 30);
            nbomb.Text = cart.style[i];
            nbomb.AutoSize = true;
            flw.Controls.Add(nbomb);
        }

        private void addLabelAmount(int i, FlowLayoutPanel flw)
        {
            TextBox nbomb = new TextBox();
            nbomb.Name = "txtNum" + i;
            nbomb.Location = new Point(1, i * 50 + 10);
            nbomb.Margin = new Padding(0);
            //nbomb.AutoSize = true;
            //nbomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //nbomb.ForeColor = Color.White;
             nbomb.Size = new Size(30, 15);
            nbomb.Text = cart.amount[i];
            flw.Controls.Add(nbomb);
        }


        private void addButton(int i, FlowLayoutPanel flow)
        {
            Button lbl = new Button();
            lbl.Name = "btn" + i.ToString();
            lbl.Tag = i;
            lbl.Width = 70;
            lbl.Height = 30;
            lbl.Text = "Удалить";
            lbl.BackColor = Color.Red;
            lbl.Click += button_click;
            //lbl.Dock = DockStyle.Top;
            flow.Controls.Add(lbl);
        }

        private void deleteGood(int id)
        {
            cart.amount.RemoveAt(id);
            cart.productId.RemoveAt(id);
            cart.style.RemoveAt(id);
            cart.title.RemoveAt(id);
        }

        private void button_click(object sender, EventArgs e)
        {
            var but = (Button)sender;
            deleteGood(Convert.ToInt32(but.Tag));
            FlowLayoutPanel tbx = this.Controls.Find("flw" + but.Tag, true).FirstOrDefault() as FlowLayoutPanel;
            tbx.Dispose();

        }

        private void generateList()
        {
            for (int i = 0; i < cart.productId.Count; i++)
            {
                FlowLayoutPanel flw = new FlowLayoutPanel();
                flw.Name = "flw" + i;
                flw.Location = new Point(40, i * 70 + 35);
                flw.FlowDirection = FlowDirection.LeftToRight;
                flw.Size = new Size(200, 35);
                flw.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(flw);
                addLabelName(i, flw);
                addLabelAmount(i, flw);
                addLabelStyle(i, flw);
                addButton(i, flw);


            }
        }

        private void cartForm_Load(object sender, EventArgs e)
        {
            // label1.Text = cart.product.Count.ToString();
            generateList();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

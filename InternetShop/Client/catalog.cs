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

namespace InternetShop.Client
{
    public partial class catalog : Form
    {
        sqlFunc sql = new sqlFunc();
        DataTable data = new DataTable();
        cart cart = new cart();
        public catalog()
        {
            InitializeComponent();
        }

        public catalog(cart cart)
        {
            InitializeComponent();
            this.cart = cart;
            
        }


        private void addPicture(int i, FlowLayoutPanel flow)
        {
            PictureBox pic = new PictureBox();
            pic.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", "goods.png"));
            
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(75, 75);
            pic.Padding = new Padding(35, 0, 35, 0);
            pic.Dock = DockStyle.Fill;
            //pic.Dock = DockStyle.Top;
            flow.Controls.Add(pic);
        }

        private void addLabelName(int i, FlowLayoutPanel flow)
        {
            Label lbl = new Label();
            lbl.Name = "lbl" + data.Rows[i][0];
            lbl.Font = new Font(lbl.Font.Name,12);
            lbl.Text = data.Rows[i][1].ToString() ;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.AutoSize = false;
            lbl.Dock = DockStyle.Fill;
            //lbl.Dock = DockStyle.Top;
            flow.Controls.Add(lbl);
        }

        private void addLabelPrice(int i, FlowLayoutPanel flow)
        {
            Label lbl = new Label();
            lbl.Name = "lblprice" + i.ToString();
            lbl.Font = new Font(lbl.Font.Name, 12,FontStyle.Bold);

            lbl.Text =  data.Rows[i][2].ToString() + " ₽";
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.AutoSize = false;
            lbl.Dock = DockStyle.Fill;
            //lbl.Dock = DockStyle.Top;
            flow.Controls.Add(lbl);
        }

        private void addLabelAmount(int i, FlowLayoutPanel flow)
        {
            Label lbl = new Label();
            lbl.Name = "lblprice" + i.ToString();
            lbl.Tag = data.Rows[i][0];
            lbl.Font = new Font(lbl.Font.Name, 12);
            lbl.Text = "Кол-во: " + data.Rows[i][3].ToString() + data.Rows[i][5].ToString();
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.AutoSize = false;
            lbl.Dock = DockStyle.Fill;
            //lbl.Dock = DockStyle.Top;
            flow.Controls.Add(lbl);
        }

        private void addTextBox(int i, FlowLayoutPanel flow)
        {
            TextBox lbl = new TextBox();
            lbl.Name = "txt" + data.Rows[i][0];
            lbl.Width = 145;  
            //lbl.Dock = DockStyle.Top;
            flow.Controls.Add(lbl);
        }

        private void addComboBox(int i, FlowLayoutPanel flow)
        {
            ComboBox lbl = new ComboBox();
            lbl.Name = "cmb" + data.Rows[i][0];
            string[] subs = data.Rows[i][4].ToString().Split(',');
            for (int j = 0; j < subs.Length; j++)
                lbl.Items.Add(subs[j]);
              
                
            lbl.Width = 145;
            lbl.Height = 40;
            //lbl.Dock = DockStyle.Top;
            flow.Controls.Add(lbl);
        }

        private void addButton(int i, FlowLayoutPanel flow)
        {
            Button lbl = new Button();
            lbl.Name = "btn" + i.ToString();
            lbl.Tag = data.Rows[i][0];  
            lbl.Width = 145;
            lbl.Height = 40;
            lbl.Text = "В корзину";
            lbl.BackColor = Color.Gray;
            lbl.Click += button_click;
            //lbl.Dock = DockStyle.Top;
            flow.Controls.Add(lbl);
        }

        private void catalog_Load(object sender, EventArgs e)
        {
            
            data = sql.getCatalog();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                
                FlowLayoutPanel flw = new FlowLayoutPanel();
                flw.Name = "flw" + i;
                flw.FlowDirection = FlowDirection.TopDown;

                flw.Size = new Size(153, 270);
                flw.BorderStyle = BorderStyle.FixedSingle;
                flowMain.Controls.Add(flw);
                addPicture(i, flw);
                addLabelName(i, flw);
                addLabelPrice(i, flw);
                addLabelAmount(i, flw);
                addComboBox(i, flw);
                addTextBox(i, flw);
                addButton(i, flw);

            }
        }

        private void button_click(object sender, EventArgs eventArgs)
        {
            
            var but = (Button)sender;
            TextBox tbx = this.Controls.Find("txt" + but.Tag,true).FirstOrDefault() as TextBox;
            ComboBox cmb = this.Controls.Find("cmb" + but.Tag, true).FirstOrDefault() as ComboBox;
            Label lbl = this.Controls.Find("lbl" + but.Tag, true).FirstOrDefault() as Label;
            var id = but.Tag.ToString();
            var amount = tbx.Text.ToString();
            var style = cmb.SelectedItem.ToString();
            var title = lbl.Text.ToString();

            cart.productId.Add(id);
            cart.amount.Add(amount);
            cart.style.Add(style);
            cart.title.Add(title);

        }
    }
}

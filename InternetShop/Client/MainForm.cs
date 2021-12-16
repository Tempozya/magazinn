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
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm;
        cart cart = new cart();
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string idUser)
        {
            InitializeComponent();
            MessageBox.Show(idUser );
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(childForm);
            this.panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.BurlyWood;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Bisque;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }






        private void buttonorders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new orders(), sender);
        }

        private void buttoncatalog_Click(object sender, EventArgs e)
        {
            OpenChildForm(new catalog(cart), sender);
        }

        private void buttonkitcatalog_Click(object sender, EventArgs e)
        {
            OpenChildForm(new kitcatalog(), sender);
        }

        private void buttonprofile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new profile(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new cartForm(cart), sender);
        }
    }
}

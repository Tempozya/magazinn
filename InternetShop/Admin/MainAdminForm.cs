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
        private Button currentButton;
        private Form activeForm;
        public MainAdminForm()
        {
            InitializeComponent();
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

        private void buttonclients_Click(object sender, EventArgs e)
        {

            OpenChildForm(new clients(), sender);

        }

        private void buttonranqe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ranqe(), sender);
        }

        private void buttonhistori_Click(object sender, EventArgs e)
        {
            OpenChildForm(new history(), sender);
        }

        private void buttongetgoods_Click(object sender, EventArgs e)
        {
            OpenChildForm(new getgoodsinfo(), sender);
        }

        private void buttongivegoods_Click(object sender, EventArgs e)
        {
            OpenChildForm(new givegoodsinfo(), sender);
        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new simulation(), sender);
        }
    }
}

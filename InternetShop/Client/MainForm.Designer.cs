namespace InternetShop.Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelForm = new System.Windows.Forms.Panel();
            this.buttonprofile = new System.Windows.Forms.Button();
            this.buttonorders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonkitcatalog = new System.Windows.Forms.Button();
            this.buttoncatalog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(180, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(720, 521);
            this.panelForm.TabIndex = 9;
            // 
            // buttonprofile
            // 
            this.buttonprofile.BackColor = System.Drawing.Color.Bisque;
            this.buttonprofile.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttonprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprofile.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonprofile.Location = new System.Drawing.Point(6, 48);
            this.buttonprofile.Name = "buttonprofile";
            this.buttonprofile.Size = new System.Drawing.Size(172, 66);
            this.buttonprofile.TabIndex = 0;
            this.buttonprofile.Text = "Профиль";
            this.buttonprofile.UseVisualStyleBackColor = false;
            this.buttonprofile.Click += new System.EventHandler(this.buttonprofile_Click);
            // 
            // buttonorders
            // 
            this.buttonorders.BackColor = System.Drawing.Color.Bisque;
            this.buttonorders.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttonorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonorders.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonorders.Location = new System.Drawing.Point(3, 129);
            this.buttonorders.Name = "buttonorders";
            this.buttonorders.Size = new System.Drawing.Size(175, 71);
            this.buttonorders.TabIndex = 1;
            this.buttonorders.Text = "Мои заказы";
            this.buttonorders.UseVisualStyleBackColor = false;
            this.buttonorders.Click += new System.EventHandler(this.buttonorders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Информация";
            // 
            // buttonkitcatalog
            // 
            this.buttonkitcatalog.BackColor = System.Drawing.Color.Bisque;
            this.buttonkitcatalog.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttonkitcatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonkitcatalog.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonkitcatalog.Location = new System.Drawing.Point(5, 302);
            this.buttonkitcatalog.Name = "buttonkitcatalog";
            this.buttonkitcatalog.Size = new System.Drawing.Size(172, 69);
            this.buttonkitcatalog.TabIndex = 3;
            this.buttonkitcatalog.Text = "Каталог готовых комплектов";
            this.buttonkitcatalog.UseVisualStyleBackColor = false;
            this.buttonkitcatalog.Click += new System.EventHandler(this.buttonkitcatalog_Click);
            // 
            // buttoncatalog
            // 
            this.buttoncatalog.BackColor = System.Drawing.Color.Bisque;
            this.buttoncatalog.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttoncatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncatalog.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttoncatalog.Location = new System.Drawing.Point(3, 217);
            this.buttoncatalog.Name = "buttoncatalog";
            this.buttoncatalog.Size = new System.Drawing.Size(175, 67);
            this.buttoncatalog.TabIndex = 2;
            this.buttoncatalog.Text = "Каталог";
            this.buttoncatalog.UseVisualStyleBackColor = false;
            this.buttoncatalog.Click += new System.EventHandler(this.buttoncatalog_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonprofile);
            this.panel1.Controls.Add(this.buttonorders);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonkitcatalog);
            this.panel1.Controls.Add(this.buttoncatalog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 521);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(2, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Корзина";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 521);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonprofile;
        private System.Windows.Forms.Button buttonorders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonkitcatalog;
        private System.Windows.Forms.Button buttoncatalog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
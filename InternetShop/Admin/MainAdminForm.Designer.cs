namespace InternetShop.Admin
{
    partial class MainAdminForm
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
            this.buttonclients = new System.Windows.Forms.Button();
            this.buttonranqe = new System.Windows.Forms.Button();
            this.buttonhistori = new System.Windows.Forms.Button();
            this.buttongetgoods = new System.Windows.Forms.Button();
            this.buttongivegoods = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonclients
            // 
            this.buttonclients.BackColor = System.Drawing.Color.Bisque;
            this.buttonclients.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttonclients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclients.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonclients.Location = new System.Drawing.Point(6, 48);
            this.buttonclients.Name = "buttonclients";
            this.buttonclients.Size = new System.Drawing.Size(172, 53);
            this.buttonclients.TabIndex = 0;
            this.buttonclients.Text = "клиенты";
            this.buttonclients.UseVisualStyleBackColor = false;
            this.buttonclients.Click += new System.EventHandler(this.buttonclients_Click);
            // 
            // buttonranqe
            // 
            this.buttonranqe.BackColor = System.Drawing.Color.Bisque;
            this.buttonranqe.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttonranqe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonranqe.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonranqe.Location = new System.Drawing.Point(2, 116);
            this.buttonranqe.Name = "buttonranqe";
            this.buttonranqe.Size = new System.Drawing.Size(175, 58);
            this.buttonranqe.TabIndex = 1;
            this.buttonranqe.Text = "ассортимент";
            this.buttonranqe.UseVisualStyleBackColor = false;
            this.buttonranqe.Click += new System.EventHandler(this.buttonranqe_Click);
            // 
            // buttonhistori
            // 
            this.buttonhistori.BackColor = System.Drawing.Color.Bisque;
            this.buttonhistori.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttonhistori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhistori.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonhistori.Location = new System.Drawing.Point(2, 189);
            this.buttonhistori.Name = "buttonhistori";
            this.buttonhistori.Size = new System.Drawing.Size(175, 54);
            this.buttonhistori.TabIndex = 2;
            this.buttonhistori.Text = "история заказов";
            this.buttonhistori.UseVisualStyleBackColor = false;
            this.buttonhistori.Click += new System.EventHandler(this.buttonhistori_Click);
            // 
            // buttongetgoods
            // 
            this.buttongetgoods.BackColor = System.Drawing.Color.Bisque;
            this.buttongetgoods.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttongetgoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongetgoods.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttongetgoods.Location = new System.Drawing.Point(3, 259);
            this.buttongetgoods.Name = "buttongetgoods";
            this.buttongetgoods.Size = new System.Drawing.Size(172, 56);
            this.buttongetgoods.TabIndex = 3;
            this.buttongetgoods.Text = "приход товара";
            this.buttongetgoods.UseVisualStyleBackColor = false;
            this.buttongetgoods.Click += new System.EventHandler(this.buttongetgoods_Click);
            // 
            // buttongivegoods
            // 
            this.buttongivegoods.BackColor = System.Drawing.Color.Bisque;
            this.buttongivegoods.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttongivegoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongivegoods.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttongivegoods.Location = new System.Drawing.Point(3, 330);
            this.buttongivegoods.Name = "buttongivegoods";
            this.buttongivegoods.Size = new System.Drawing.Size(172, 56);
            this.buttongivegoods.TabIndex = 4;
            this.buttongivegoods.Text = "расход товара";
            this.buttongivegoods.UseVisualStyleBackColor = false;
            this.buttongivegoods.Click += new System.EventHandler(this.buttongivegoods_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonclients);
            this.panel1.Controls.Add(this.buttonranqe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttongivegoods);
            this.panel1.Controls.Add(this.buttongetgoods);
            this.panel1.Controls.Add(this.buttonhistori);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 497);
            this.panel1.TabIndex = 6;
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(180, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(620, 497);
            this.panelForm.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(5, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "симуляция";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainAdminForm";
            this.Text = "MainAdminForm";
            this.Load += new System.EventHandler(this.MainAdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonclients;
        private System.Windows.Forms.Button buttonranqe;
        private System.Windows.Forms.Button buttonhistori;
        private System.Windows.Forms.Button buttongetgoods;
        private System.Windows.Forms.Button buttongivegoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button button1;
    }
}
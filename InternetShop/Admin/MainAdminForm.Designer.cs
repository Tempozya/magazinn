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
            this.SuspendLayout();
            // 
            // buttonclients
            // 
            this.buttonclients.Location = new System.Drawing.Point(28, 89);
            this.buttonclients.Name = "buttonclients";
            this.buttonclients.Size = new System.Drawing.Size(129, 34);
            this.buttonclients.TabIndex = 0;
            this.buttonclients.Text = "клиенты";
            this.buttonclients.UseVisualStyleBackColor = true;
            this.buttonclients.Click += new System.EventHandler(this.buttonclients_Click);
            // 
            // buttonranqe
            // 
            this.buttonranqe.Location = new System.Drawing.Point(28, 146);
            this.buttonranqe.Name = "buttonranqe";
            this.buttonranqe.Size = new System.Drawing.Size(129, 34);
            this.buttonranqe.TabIndex = 1;
            this.buttonranqe.Text = "ассортимент";
            this.buttonranqe.UseVisualStyleBackColor = true;
            this.buttonranqe.Click += new System.EventHandler(this.buttonranqe_Click);
            // 
            // buttonhistori
            // 
            this.buttonhistori.Location = new System.Drawing.Point(28, 206);
            this.buttonhistori.Name = "buttonhistori";
            this.buttonhistori.Size = new System.Drawing.Size(129, 34);
            this.buttonhistori.TabIndex = 2;
            this.buttonhistori.Text = "история заказов";
            this.buttonhistori.UseVisualStyleBackColor = true;
            this.buttonhistori.Click += new System.EventHandler(this.buttonhistori_Click);
            // 
            // buttongetgoods
            // 
            this.buttongetgoods.Location = new System.Drawing.Point(28, 267);
            this.buttongetgoods.Name = "buttongetgoods";
            this.buttongetgoods.Size = new System.Drawing.Size(129, 34);
            this.buttongetgoods.TabIndex = 3;
            this.buttongetgoods.Text = "приход товара";
            this.buttongetgoods.UseVisualStyleBackColor = true;
            this.buttongetgoods.Click += new System.EventHandler(this.buttongetgoods_Click);
            // 
            // buttongivegoods
            // 
            this.buttongivegoods.Location = new System.Drawing.Point(28, 326);
            this.buttongivegoods.Name = "buttongivegoods";
            this.buttongivegoods.Size = new System.Drawing.Size(129, 34);
            this.buttongivegoods.TabIndex = 4;
            this.buttongivegoods.Text = "расход товара";
            this.buttongivegoods.UseVisualStyleBackColor = true;
            this.buttongivegoods.Click += new System.EventHandler(this.buttongivegoods_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Информация";
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttongivegoods);
            this.Controls.Add(this.buttongetgoods);
            this.Controls.Add(this.buttonhistori);
            this.Controls.Add(this.buttonranqe);
            this.Controls.Add(this.buttonclients);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainAdminForm";
            this.Text = "MainAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonclients;
        private System.Windows.Forms.Button buttonranqe;
        private System.Windows.Forms.Button buttonhistori;
        private System.Windows.Forms.Button buttongetgoods;
        private System.Windows.Forms.Button buttongivegoods;
        private System.Windows.Forms.Label label1;
    }
}
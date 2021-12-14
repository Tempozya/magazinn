
namespace InternetShop.Admin
{
    partial class clients
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
            this.dataGridViewclients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewclients
            // 
            this.dataGridViewclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewclients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewclients.Name = "dataGridViewclients";
            this.dataGridViewclients.RowTemplate.Height = 25;
            this.dataGridViewclients.Size = new System.Drawing.Size(633, 398);
            this.dataGridViewclients.TabIndex = 0;
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewclients);
            this.Name = "clients";
            this.Text = "clients";
            this.Load += new System.EventHandler(this.clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewclients;
    }
}

namespace InternetShop.Admin
{
    partial class ranqe
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
            this.dataGridViewgoods = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewgoods
            // 
            this.dataGridViewgoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewgoods.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewgoods.Name = "dataGridViewgoods";
            this.dataGridViewgoods.RowTemplate.Height = 25;
            this.dataGridViewgoods.Size = new System.Drawing.Size(666, 392);
            this.dataGridViewgoods.TabIndex = 0;
            // 
            // ranqe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewgoods);
            this.Name = "ranqe";
            this.Text = "ranqe";
            this.Load += new System.EventHandler(this.ranqe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewgoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewgoods;
    }
}
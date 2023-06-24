
namespace agri_connect_winforms_client
{
    partial class VendorTransactionForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GetAllVendorTransactionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // GetAllVendorTransactionsButton
            // 
            this.GetAllVendorTransactionsButton.Location = new System.Drawing.Point(275, 160);
            this.GetAllVendorTransactionsButton.Name = "GetAllVendorTransactionsButton";
            this.GetAllVendorTransactionsButton.Size = new System.Drawing.Size(137, 23);
            this.GetAllVendorTransactionsButton.TabIndex = 1;
            this.GetAllVendorTransactionsButton.Text = "Get All Transactions";
            this.GetAllVendorTransactionsButton.UseVisualStyleBackColor = true;
            this.GetAllVendorTransactionsButton.Click += new System.EventHandler(this.GetAllVendorTransactionsButton_Click);
            // 
            // VendorTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetAllVendorTransactionsButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VendorTransactionForm";
            this.Text = "VendorTransactionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VendorTransactionForm_FormClosing);
            this.Load += new System.EventHandler(this.VendorTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetAllVendorTransactionsButton;
    }
}
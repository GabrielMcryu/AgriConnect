
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
            this.label1 = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.TextBox();
            this.GetVendorTransactionButton = new System.Windows.Forms.Button();
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
            this.GetAllVendorTransactionsButton.Location = new System.Drawing.Point(64, 151);
            this.GetAllVendorTransactionsButton.Name = "GetAllVendorTransactionsButton";
            this.GetAllVendorTransactionsButton.Size = new System.Drawing.Size(137, 23);
            this.GetAllVendorTransactionsButton.TabIndex = 1;
            this.GetAllVendorTransactionsButton.Text = "Get All Transactions";
            this.GetAllVendorTransactionsButton.UseVisualStyleBackColor = true;
            this.GetAllVendorTransactionsButton.Click += new System.EventHandler(this.GetAllVendorTransactionsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.Location = new System.Drawing.Point(99, 52);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 23);
            this.idField.TabIndex = 3;
            // 
            // GetVendorTransactionButton
            // 
            this.GetVendorTransactionButton.Location = new System.Drawing.Point(64, 105);
            this.GetVendorTransactionButton.Name = "GetVendorTransactionButton";
            this.GetVendorTransactionButton.Size = new System.Drawing.Size(137, 23);
            this.GetVendorTransactionButton.TabIndex = 4;
            this.GetVendorTransactionButton.Text = "Get Transaction";
            this.GetVendorTransactionButton.UseVisualStyleBackColor = true;
            this.GetVendorTransactionButton.Click += new System.EventHandler(this.GetVendorTransactionButton_Click);
            // 
            // VendorTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetVendorTransactionButton);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetAllVendorTransactionsButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VendorTransactionForm";
            this.Text = "VendorTransactionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VendorTransactionForm_FormClosing);
            this.Load += new System.EventHandler(this.VendorTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetAllVendorTransactionsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Button GetVendorTransactionButton;
    }
}
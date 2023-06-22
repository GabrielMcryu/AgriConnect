
namespace agri_connect_winforms_client
{
    partial class SupplierTransactionForm
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
            this.idField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetSupplierTransactionButton = new System.Windows.Forms.Button();
            this.GetAllTransactionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // idField
            // 
            this.idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idField.Location = new System.Drawing.Point(108, 46);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 23);
            this.idField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Id:";
            // 
            // GetSupplierTransactionButton
            // 
            this.GetSupplierTransactionButton.Location = new System.Drawing.Point(108, 100);
            this.GetSupplierTransactionButton.Name = "GetSupplierTransactionButton";
            this.GetSupplierTransactionButton.Size = new System.Drawing.Size(137, 23);
            this.GetSupplierTransactionButton.TabIndex = 3;
            this.GetSupplierTransactionButton.Text = "Get Transaction";
            this.GetSupplierTransactionButton.UseVisualStyleBackColor = true;
            this.GetSupplierTransactionButton.Click += new System.EventHandler(this.GetSupplierTransactionButton_Click);
            // 
            // GetAllTransactionsButton
            // 
            this.GetAllTransactionsButton.Location = new System.Drawing.Point(108, 155);
            this.GetAllTransactionsButton.Name = "GetAllTransactionsButton";
            this.GetAllTransactionsButton.Size = new System.Drawing.Size(161, 23);
            this.GetAllTransactionsButton.TabIndex = 4;
            this.GetAllTransactionsButton.Text = "Get All Transactions";
            this.GetAllTransactionsButton.UseVisualStyleBackColor = true;
            this.GetAllTransactionsButton.Click += new System.EventHandler(this.GetAllTransactionsButton_Click);
            // 
            // SupplierTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetAllTransactionsButton);
            this.Controls.Add(this.GetSupplierTransactionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SupplierTransactionForm";
            this.Text = "SupplierTransactionForm";
            this.Load += new System.EventHandler(this.SupplierTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetSupplierTransactionButton;
        private System.Windows.Forms.Button GetAllTransactionsButton;
    }
}